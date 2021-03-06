// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WEBCOREPROJETOLP.Models;

namespace WEBCOREPROJETOLP.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WEBCOREPROJETOLP.Models.Dominio.ItemMochila", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("mochilaID")
                        .HasColumnType("int");

                    b.Property<int>("pokemonID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("mochilaID");

                    b.HasIndex("pokemonID");

                    b.ToTable("ItemMochilas");
                });

            modelBuilder.Entity("WEBCOREPROJETOLP.Models.Dominio.Jogador", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cidade")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("pais")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("usuarioID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("usuarioID")
                        .IsUnique();

                    b.ToTable("Jogadores");
                });

            modelBuilder.Entity("WEBCOREPROJETOLP.Models.Dominio.Mochila", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("jogadorID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("jogadorID")
                        .IsUnique();

                    b.ToTable("Mochilas");
                });

            modelBuilder.Entity("WEBCOREPROJETOLP.Models.Dominio.Pokemon", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nome")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("tipoID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("tipoID");

                    b.ToTable("Pokemons");
                });

            modelBuilder.Entity("WEBCOREPROJETOLP.Models.Dominio.PokemonTipo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("id");

                    b.ToTable("Pokemon_Tipos");
                });

            modelBuilder.Entity("WEBCOREPROJETOLP.Models.Dominio.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("usuario")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("WEBCOREPROJETOLP.Models.Dominio.ItemMochila", b =>
                {
                    b.HasOne("WEBCOREPROJETOLP.Models.Dominio.Mochila", "mochila")
                        .WithMany("itemMochilas")
                        .HasForeignKey("mochilaID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("WEBCOREPROJETOLP.Models.Dominio.Pokemon", "pokemon")
                        .WithMany("itemMochilas")
                        .HasForeignKey("pokemonID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("mochila");

                    b.Navigation("pokemon");
                });

            modelBuilder.Entity("WEBCOREPROJETOLP.Models.Dominio.Jogador", b =>
                {
                    b.HasOne("WEBCOREPROJETOLP.Models.Dominio.Usuario", "usuario")
                        .WithOne("jogador")
                        .HasForeignKey("WEBCOREPROJETOLP.Models.Dominio.Jogador", "usuarioID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("WEBCOREPROJETOLP.Models.Dominio.Mochila", b =>
                {
                    b.HasOne("WEBCOREPROJETOLP.Models.Dominio.Jogador", "jogador")
                        .WithOne("mochila")
                        .HasForeignKey("WEBCOREPROJETOLP.Models.Dominio.Mochila", "jogadorID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("jogador");
                });

            modelBuilder.Entity("WEBCOREPROJETOLP.Models.Dominio.Pokemon", b =>
                {
                    b.HasOne("WEBCOREPROJETOLP.Models.Dominio.PokemonTipo", "tipo")
                        .WithMany("pokemons")
                        .HasForeignKey("tipoID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("tipo");
                });

            modelBuilder.Entity("WEBCOREPROJETOLP.Models.Dominio.Jogador", b =>
                {
                    b.Navigation("mochila");
                });

            modelBuilder.Entity("WEBCOREPROJETOLP.Models.Dominio.Mochila", b =>
                {
                    b.Navigation("itemMochilas");
                });

            modelBuilder.Entity("WEBCOREPROJETOLP.Models.Dominio.Pokemon", b =>
                {
                    b.Navigation("itemMochilas");
                });

            modelBuilder.Entity("WEBCOREPROJETOLP.Models.Dominio.PokemonTipo", b =>
                {
                    b.Navigation("pokemons");
                });

            modelBuilder.Entity("WEBCOREPROJETOLP.Models.Dominio.Usuario", b =>
                {
                    b.Navigation("jogador");
                });
#pragma warning restore 612, 618
        }
    }
}
