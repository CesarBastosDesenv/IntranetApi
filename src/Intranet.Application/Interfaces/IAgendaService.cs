using System;
using Intranet.Application.Dto;

namespace Intranet.Application.Interfaces;

public interface IAgendaService
{
    Task<ResultViewModel> AddAsync(AgendaCadastro agenda);

    Task<ResultViewModel> UpdateAsync(AgendaCadastro agenda);

    Task<ResultViewModel> GetAllAsync();

    
}
