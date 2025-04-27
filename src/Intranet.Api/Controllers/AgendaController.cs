using System;
using Intranet.Application.Dto;
using Intranet.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Intranet.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AgendaController : ControllerBase
{
     private ILogger<AgendaController> _logger;
     private IAgendaService _agendaService;

      public AgendaController(ILogger<AgendaController> logger, IAgendaService agendaService)
    {
        _logger = logger;
        _agendaService = agendaService;
    }

    [HttpGet]
    public async Task<ActionResult> Get()
    {
        try
        {
            var result = await _agendaService.GetAllAsync();
            return Ok(result);
        }
        catch (Exception ex)
        {
            var er = new ResultViewModel();
            er.AddNotification("Erro", ex.Message);
            return BadRequest(er);
        }
    } 

    [HttpPost]
    public async Task<ActionResult> Add(AgendaCadastro args)
    {
        try
        {
            if (!ModelState.IsValid) return Ok(new ResultViewModel(args, ModelState));
            var result = await _agendaService.AddAsync(args);
            return Ok(result);
        }
        catch (Exception ex)
        {
            var er = new ResultViewModel();
            er.AddNotification("Erro", ex.Message);
            return BadRequest(er);
        }
    }


}
