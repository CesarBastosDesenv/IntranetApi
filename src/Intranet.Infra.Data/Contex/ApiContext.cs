using System;
using Intranet.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Intranet.Infra.Data.Contex;

public class ApiContext : DbContext
{
    public ApiContext(DbContextOptions<ApiContext> options) : base(options)
    {
        
    }

    public DbSet<Agenda> Agendas { get; set;}

}
