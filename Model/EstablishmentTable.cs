using System;
using System.ComponentModel.DataAnnotations;

namespace backend_test_dotnet_API.Model;

public class EstablishmentTable
{
    public Guid id {get; init;}

    [MaxLength(100)]
    public string? Nome {get; private set;}

    [MaxLength(14)]
    public string? Cnpj {get; private set;} 

    [MaxLength(255)]
    public string? Endereco {get; private set;}

    [MaxLength(20)]
    public string? Telefone {get; private set;}

    public int vagasMotos {get; private set;}

    public int vagasCarros {get; private set;}

    public EstablishmentTable(){}

    public EstablishmentTable(string? nome, string? CNPJ, string? endereco, string? telefone, int vMotos, int vCarros)
    {
        id = Guid.NewGuid();
        Nome = nome;
        Cnpj = CNPJ;
        Endereco = endereco;
        Telefone = telefone;
        vagasMotos = vMotos;
        vagasCarros = vCarros;
    }
}
