using System.ComponentModel.DataAnnotations;

namespace AutoCerto.Dtos;



public class RegistrarDto
{
    [Required] public string Usuario { get; set; }
    [Required] public string Nome { get; set; }
    [Required] public string Senha { get; set; }
}