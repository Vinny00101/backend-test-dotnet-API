using System;
using System.ComponentModel.DataAnnotations;

namespace backend_test_dotnet_API.Model;

public class VehiclesTable
{
    public Guid id {get; init;}

    public Guid EstabelecimentoID {get; init;}

    [MaxLength(100)]
    public string? Marca {get; private set;}

    [MaxLength(17)]
    public string? Modelo {get; private set;}

    [MaxLength(100)]
    public string? Cor {get; private set;}

    [MaxLength(7)]
    public string? Placa {get; private set;}

    [MaxLength(50)]
    public string? Tipo {get; private set;}

    public VehiclesTable(){}

    public VehiclesTable(Guid ID, string? marca, string? modelo, string? cor, string? placa, string? tipo)
    {
        id = Guid.NewGuid();
        EstabelecimentoID = ID;
        Marca = marca;
        Modelo = modelo;
        Cor = cor;
        Placa = placa;
        Tipo = tipo;
    }
}
