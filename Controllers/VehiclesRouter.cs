using System;
using backend_test_dotnet_API.Data;
using backend_test_dotnet_API.Dtos;
using backend_test_dotnet_API.Model;
using Microsoft.EntityFrameworkCore;
using Sprache;

namespace backend_test_dotnet_API.Controllers;

public static class VehiclesRouter
{
    public static void AddVehiclesRouter(this WebApplication app)
    {
        var router = app.MapGroup("veiculos");
        
        router.MapPost("post", async(VehiclesDTO request, AppDbContext _context) => {
            var error = ValidatorDTO.ValidationModel(request);
            if(error.Any()){
                return Results.BadRequest(error);
            }
            var establishment = await _context.Estabelecimento.FindAsync(request.EstabelecimentoID);

            if (establishment == null){
                return Results.NotFound("Estabelecimento não encontrado.");
            }

            int total = await _context.Veiculos.CountAsync(e => e.Tipo == request.Tipo && e.EstabelecimentoID == request.EstabelecimentoID);

            if(request.Tipo == "Carro" && !(total <= establishment.vagasCarros)){
                return Results.Conflict("Não há mais vagas disponíveis para carros neste estabelecimento.");
            }
            if(request.Tipo == "Moto" && !(total <= establishment.vagasMotos)){
                return Results.Conflict("Não há mais vagas disponíveis para carros neste estabelecimento.");
            }

            var Vehicle = new VehiclesTable(
                request.EstabelecimentoID,
                request.Marca,
                request.Modelo,
                request.Cor,
                request.Placa,
                request.Tipo
            );

            await _context.Veiculos.AddAsync(Vehicle);
            await _context.SaveChangesAsync();

            return Results.Ok();
        });

        router.MapGet("estabelecimento/{id:guid}", async(Guid id, AppDbContext _context) => {
            var veiculos = await _context.Veiculos.Where(e => e.EstabelecimentoID == id).ToListAsync();
            if(veiculos == null){
                return Results.NotFound("Nenhum veículo foi encontrado neste estabelecimento");
            }
            return Results.Ok(veiculos);
        });
    }
}
