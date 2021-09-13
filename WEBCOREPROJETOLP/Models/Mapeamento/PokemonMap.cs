using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBCOREPROJETOLP.Models.Dominio;

namespace WEBCOREPROJETOLP.Models.Mapeamento
{
    public class PokemonMap : IEntityTypeConfiguration<Pokemon>
    {
        public void Configure(EntityTypeBuilder<Pokemon> builder)
        {
            builder.HasKey(pokemon => pokemon.id);
            builder.Property(pokemon => pokemon.id).ValueGeneratedOnAdd();
            builder.Property(pokemon => pokemon.nome).HasMaxLength(30);

            builder.HasOne(pokemon => pokemon.tipo)
                .WithMany(tipo => tipo.pokemons)
                .HasForeignKey(pokemon => pokemon.tipoID)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(pokemon => pokemon.itemMochilas)
                .WithOne(itemMochila => itemMochila.pokemon)
                .HasForeignKey(ItemMochila => ItemMochila.pokemonID)
                .OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Pokemons");
        }
    }
}
