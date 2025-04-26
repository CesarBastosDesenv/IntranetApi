using System;
using Intranet.Domain.Models;

namespace Intranet.Infra.Data.Interfaces;

public interface IAgendaRepository
{
    Task<IEnumerable<Agenda>> BuscaAgenda();
    void AdicionarAgenda(Agenda agenda);
    void AtualizarAgenda(Agenda agenda);
    void DeletarAgenda(Agenda agenda);

    Task<bool> SaveChangesAsync();

}
