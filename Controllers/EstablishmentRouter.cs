using System;
using backend_test_dotnet_API.Data;
using backend_test_dotnet_API.Dtos;
using backend_test_dotnet_API.Model;
using Microsoft.EntityFrameworkCore;

namespace backend_test_dotnet_API.Controllers;

public static class EstablishmentRouter
{
    public static void AddEstablishmentRouter(this WebApplication app)
    {
        var router = app.MapGroup("estabelecimento");

        router.MapPost("post", async (EstablishmentDTO request, AppDbContext _context) => { 
            var errors = ValidatorDTO.ValidationModel(request);
            if(errors.Any())
            {
                return Results.BadRequest(errors);
            }

            var Establishment = new EstablishmentTable(
                request.Nome,
                request.Cnpj,
                request.Endereco,
                request.Telefone,
                request.vagasMotos,
                request.vagasCarros
            );
            await _context.Estabelecimento.AddAsync(Establishment);
            await _context.SaveChangesAsync();

            return Results.Ok();
        });

        router.MapGet("buscar", async (AppDbContext _context) => {
            var result = await _context.Estabelecimento
                .Select( e => new {
                    e.id
                }).ToListAsync();
            return Results.Ok(result);
        });
        // rota que buscar os veiculos no estabelecimento/id do estabelecimento
    }
}
