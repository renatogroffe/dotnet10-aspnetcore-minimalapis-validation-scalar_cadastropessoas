using System.ComponentModel.DataAnnotations;

namespace APIPessoas.Models;

public class DadosPessoa
{
    [Required(ErrorMessage = "Preencha o campo 'nome'")]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "Preencha o campo 'sobrenome'")]
    public string? Sobrenome { get; set; }

    [Required(ErrorMessage = "Preencha o campo 'empresa'")]
    public string? Empresa { get; set; }
}

public class Pessoa
{
    public string? Id { get; set; }
    public string? Nome { get; set; }
    public string? Sobrenome { get; set; }
    public string? Empresa { get; set; }
}