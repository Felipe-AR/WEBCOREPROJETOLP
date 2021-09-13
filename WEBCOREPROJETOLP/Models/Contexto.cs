using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBCOREPROJETOLP.Models.Dominio;
using WEBCOREPROJETOLP.Models.Mapeamento;

namespace WEBCOREPROJETOLP.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options): base (options) { }

        public DbSet<ItemMochila> ItemMochilas { get; set; }
        public DbSet<Jogador> Jogadores { get; set;  }
        public DbSet<Mochila> Mochilas { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<PokemonTipo> PokemonTipos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ItemMochilaMap());
            builder.ApplyConfiguration(new JogadorMap());
            builder.ApplyConfiguration(new MochilaMap());
            builder.ApplyConfiguration(new PokemonMap());
            builder.ApplyConfiguration(new PokemonTipoMap());
            builder.ApplyConfiguration(new UsuarioMap());
        }
    }
}
