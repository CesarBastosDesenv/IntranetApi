using System;
using System.ComponentModel.DataAnnotations;

namespace Intranet.Application.Dto;

public class AgendaCadastro
{
    [Required(ErrorMessage = "{0}: É obrigatório")]
    [StringLength(50,ErrorMessage = "{0}: Maximo de 50 caracteres")]
    public required string Titulo { get; set; }
    public DateOnly Data { get; set; }
   
    [Required(ErrorMessage = "{0}: É obrigatório")]
    [StringLength(30,ErrorMessage = "{0}: Maximo de 30 caracteres")]
    public required string HoraInicio { get; set; }

    [Required(ErrorMessage = "{0}: É obrigatório")]
    [StringLength(30,ErrorMessage = "{0}: Maximo de 30 caracteres")]
    public required string HoraFim { get; set; }

    [Required(ErrorMessage = "{0}: É obrigatório")]
    [StringLength(100,ErrorMessage = "{0}: Maximo de 100 caracteres")]
    public required string Local { get; set; }

    [Required(ErrorMessage = "{0}: É obrigatório")]
    [StringLength(250,ErrorMessage = "{0}: Maximo de 250 caracteres")]
    public required string Descricao { get; set; }

    public bool Status { get; set; } = true;
}
