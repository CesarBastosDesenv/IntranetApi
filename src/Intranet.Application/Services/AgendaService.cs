using System;
using Intranet.Application.Dto;
using Intranet.Application.Interfaces;
using Intranet.Domain.Models;
using Intranet.Infra.Data.Interfaces;

namespace Intranet.Application.Services;

public class AgendaService : IAgendaService
{
    private IAgendaRepository _agendaRepository;

    public AgendaService(IAgendaRepository agendaRepository)
    {
        _agendaRepository = agendaRepository;
       
    }
    public async Task<ResultViewModel> AddAsync(AgendaCadastro args)
    {
         var agenda = new Agenda()
        {
            Titulo = args.Titulo,
            Data = args.Data,
            HoraInicio = args.HoraInicio,
            HoraFim = args.HoraFim,
            Local = args.Local,
            Descricao = args.Descricao,
         };
        _agendaRepository.AdicionarAgenda(agenda);
        var result = new ResultViewModel(await _agendaRepository.SaveChangesAsync());
       
        if (!(bool)result.Data)
            result.AddNotification("", "Erro ao cadastrar");

        return result;  
    }

    public async Task<ResultViewModel> GetAllAsync()
    {
        var retorno = await _agendaRepository.BuscaAgenda();
        var retornoModel = retorno.Select(x => new AgendaView(){
            Id = x.Id,
            Titulo = x.Titulo,
            Data = x.Data,
            HoraInicio = x.HoraInicio,
            HoraFim  = x.HoraFim,
            Local = x.Local,
            Descricao = x.Descricao 
            });
        return new ResultViewModel(retornoModel);
    }

    public Task<ResultViewModel> UpdateAsync(AgendaCadastro agenda)
    {
        throw new NotImplementedException();
    }
}
