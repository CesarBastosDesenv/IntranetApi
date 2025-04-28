using System;

namespace Intranet.Application.Dto;

public class AgendaView
{

  public Guid Id { get; set; }
    public required string Titulo { get; set; }
    public DateOnly Data { get; set; }
    public required string HoraInicio { get; set; }
    public required string HoraFim { get; set; }

    public required string Local { get; set; }
    public required string Descricao { get; set; }

    public bool Status { get; set; }
}
