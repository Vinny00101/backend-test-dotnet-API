using System;
using System.ComponentModel.DataAnnotations;

namespace backend_test_dotnet_API.Dtos;

public class EstablishmentDTO
{

    [Required(ErrorMessage = "O nome é obrigatório.")]
    [MaxLength(100)]
    public string? Nome {get; set;}

    [Required(ErrorMessage = "O CNPJ é obrigatório.")]
    [StringLength(14, MinimumLength = 14, ErrorMessage = "CNPJ deve conter exatamente 14 dígitos.")]
    [RegularExpression(@"^\d{14}$", ErrorMessage = "CNPJ deve conter apenas números.")]
    public string? Cnpj {get; set;} 

    [Required(ErrorMessage = "Endereço é obrigatório.")]
    [MaxLength(255, ErrorMessage = "Endereço deve conter somente 255 dígitos.")]
    public string? Endereco {get; set;}

    [Required(ErrorMessage = "O Telefone é obrigatório.")]
    [MaxLength(20, ErrorMessage = "Telefone deve conter exatamente 20 dígitos.")]
    public string? Telefone {get; set;}

    [Required(ErrorMessage = "Quantidade de vagas para motos é obrigatório.")]
    [Range(0, 1000, ErrorMessage = "O valor deve estar entre 0 e 1000.")]
    public int vagasMotos {get; set;}

    [Required(ErrorMessage = "Quantidade de vagas para carros é obrigatório.")]
    [Range(0, 1000, ErrorMessage = "O valor deve estar entre 0 e 1000.")]
    public int vagasCarros {get; set;}

}
