using System;
using Intranet.Domain.Models;
using Intranet.Infra.Data.Contex;
using Intranet.Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Intranet.Infra.Data.Repositories;

public class AgendaRepository : IAgendaRepository
{
     private readonly ApiContext _context;

         public AgendaRepository(ApiContext context)
        {
            _context = context;
        }
    public void AdicionarAgenda(Agenda agenda)
    {
        _context.Add(agenda);
    }

    public void AtualizarAgenda(Agenda agenda)
    {
        _context.Update(agenda);
    }

    public async Task<IEnumerable<Agenda>> BuscaAgenda()
    {
        return await _context.Agendas.ToListAsync();
    }

    public void DeletarAgenda(Agenda agenda)
    {
        _context.Remove(agenda);
    }

    public async Task<bool> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }
}
