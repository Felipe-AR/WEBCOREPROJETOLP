using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBCOREPROJETOLP.Models.Dominio;

namespace WEBCOREPROJETOLP.Models.Mapeamento
{
    public class JogadorMap : IEntityTypeConfiguration<Jogador>
    {
        public void Configure(EntityTypeBuilder<Jogador> builder)
        {
            builder.HasKey(jogador => jogador.id);
            builder.Property(jogador => jogador.id).ValueGeneratedOnAdd();
            builder.Property(jogador => jogador.nome).HasMaxLength(50).IsRequired();
            builder.Property(jogador => jogador.cidade).HasMaxLength(50).IsRequired();
            builder.Property(jogador => jogador.estado).HasMaxLength(2).IsRequired();
            builder.Property(jogador => jogador.pais).HasMaxLength(50).IsRequired();

            builder.HasOne<Usuario>(jogador => jogador.usuario)
                .WithOne(usuario => usuario.jogador)
                .HasForeignKey<Usuario>(usuario => usuario.jogadorID)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne<Mochila>(jogador => jogador.mochila)
                .WithOne(mochila => mochila.jogador)
                .HasForeignKey<Mochila>(mochila => mochila.jogadorID)
                .OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Jogadores");
        }
    }
}
