using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBCOREPROJETOLP.Models.Dominio;

namespace WEBCOREPROJETOLP.Models.Mapeamento
{
    public class ItemMochilaMap : IEntityTypeConfiguration<ItemMochila>
    {
        public void Configure(EntityTypeBuilder<ItemMochila> builder)
        {
            builder.HasKey(itemMochila => itemMochila.id);
            builder.Property(itemMochila => itemMochila.id).ValueGeneratedOnAdd();
            builder.Property(itemMochila => itemMochila.mochilaID).IsRequired();
            builder.Property(itemMochila => itemMochila.pokemonID).IsRequired();

            builder.HasOne(itemMochila => itemMochila.mochila)
                .WithMany(mochila => mochila.itemMochilas)
                .HasForeignKey(itemMochila => itemMochila.mochilaID)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(itemMochila => itemMochila.pokemon)
            .WithMany(pokemon => pokemon.itemMochilas)
            .HasForeignKey(itemMochila => itemMochila.pokemonID)
            .OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("ItemMochilas");
        }
    }
}
