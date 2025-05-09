using System;
using System.ComponentModel.DataAnnotations;

namespace backend_test_dotnet_API.Dtos;

public class VehiclesDTO
{
    public Guid EstabelecimentoID {get; set;}

    [Required(ErrorMessage = "O nome da marca é obrigatório.")]
    [MaxLength(100, ErrorMessage = "O nome do deve conter até 100 caracteres")]
    public string? Marca {get; set;}

    [Required(ErrorMessage = "O nome do modelo é obrigatório.")]
    [MaxLength(17, ErrorMessage = "17 caracteres")]
    public string? Modelo {get; set;}

    [Required(ErrorMessage = "O nome da cor é obrigatório.")]
    [MaxLength(100)]
    public string? Cor {get; set;}

    [Required(ErrorMessage = "A placa é obrigatório.")]
    [MaxLength(7)]
    [RegularExpression(@"^[A-Za-z]{3}\d[A-Za-z]\d{2}$", ErrorMessage = "Placa no formato inválido (ex: ABC1D23).")]
    public string? Placa {get; set;}

    [Required(ErrorMessage = "O tipo é obrigatório.")]
    [MaxLength(50)]
    public string? Tipo {get; set;}

}
