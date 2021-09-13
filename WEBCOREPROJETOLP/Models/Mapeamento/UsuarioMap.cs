using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBCOREPROJETOLP.Models.Dominio;

namespace WEBCOREPROJETOLP.Models.Mapeamento
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(usuario => usuario.id);
            builder.Property(usuario => usuario.id).ValueGeneratedOnAdd();
            builder.Property(usuario => usuario.email).HasMaxLength(50).IsRequired();
            builder.Property(usuario => usuario.usuario).HasMaxLength(20).IsRequired();
            builder.Property(usuario => usuario.senha).HasMaxLength(256).IsRequired();

            builder.HasOne<Jogador>(usuario => usuario.jogador)
                .WithOne(jogador => jogador.usuario)
                .HasForeignKey<Usuario>(jogador => jogador.jogadorID)
                .OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Usuarios");
        }
    }
}
