using System;
using Intranet.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Intranet.Infra.Data.Mappings;

public class AgendaMap : IEntityTypeConfiguration<Agenda>
{
    public void Configure(EntityTypeBuilder<Agenda> builder)
    {
         builder.ToTable("Agenda");

        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Titulo)
        .HasColumnType("varchar(50)");

        builder.Property(x => x.Data)
        .HasColumnType("date(50)");

        builder.Property(x => x.HoraInicio)
        .HasColumnType("varchar(30)");
       
        builder.Property(x => x.HoraFim)
        .HasColumnType("varchar(30)"); 

        builder.Property(x => x.Local)
        .HasColumnType("Varcahar(100)");

        builder.Property(x => x.Descricao)
        .HasColumnType("varchar(250)");
    }
}
