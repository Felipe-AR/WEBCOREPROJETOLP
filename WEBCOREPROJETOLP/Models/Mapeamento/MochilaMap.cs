using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBCOREPROJETOLP.Models.Dominio;

namespace WEBCOREPROJETOLP.Models.Mapeamento
{
    public class MochilaMap : IEntityTypeConfiguration<Mochila>
    {
        public void Configure(EntityTypeBuilder<Mochila> builder)
        {
            builder.HasKey(mochila => mochila.id);
            builder.Property(mochila => mochila.id).ValueGeneratedOnAdd();

            builder.HasOne<Jogador>(mochila => mochila.jogador)
                .WithOne(jogador => jogador.mochila)
                .HasForeignKey<Mochila>(mochila => mochila.jogadorID)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(mochila => mochila.itemMochilas)
                .WithOne(itemMochila => itemMochila.mochila)
                .HasForeignKey(m => m.mochilaID)
                .OnDelete(DeleteBehavior.NoAction);
                    
            builder.ToTable("Mochilas");
        }
    }
}
