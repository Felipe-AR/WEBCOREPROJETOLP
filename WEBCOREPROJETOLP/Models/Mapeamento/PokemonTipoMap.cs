using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBCOREPROJETOLP.Models.Dominio;

namespace WEBCOREPROJETOLP.Models.Mapeamento
{
    public class PokemonTipoMap : IEntityTypeConfiguration<PokemonTipo>
    {
        public void Configure(EntityTypeBuilder<PokemonTipo> builder)
        {
            builder.HasKey(tipo => tipo.id);
            builder.Property(tipo => tipo.id).ValueGeneratedOnAdd();
            builder.Property(tipo => tipo.descricao).HasMaxLength(30).IsRequired();

            builder.HasMany(tipo => tipo.pokemons)
                .WithOne(pokemon => pokemon.tipo)
                .HasForeignKey(pokemon => pokemon.tipoID)
                .OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Pokemon_Tipos");
        }
    }
}
