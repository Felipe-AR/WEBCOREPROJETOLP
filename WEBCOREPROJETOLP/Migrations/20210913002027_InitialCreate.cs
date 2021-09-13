using Microsoft.EntityFrameworkCore.Migrations;

namespace WEBCOREPROJETOLP.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jogadores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    cidade = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    estado = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    pais = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogadores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Pokemon_Tipos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descricao = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon_Tipos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Mochilas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    jogadorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mochilas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Mochilas_Jogadores_jogadorID",
                        column: x => x.jogadorID,
                        principalTable: "Jogadores",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    jogadorID = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    usuario = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    senha = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Jogadores_jogadorID",
                        column: x => x.jogadorID,
                        principalTable: "Jogadores",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    tipoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.id);
                    table.ForeignKey(
                        name: "FK_Pokemons_Pokemon_Tipos_tipoID",
                        column: x => x.tipoID,
                        principalTable: "Pokemon_Tipos",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "ItemMochilas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mochilaID = table.Column<int>(type: "int", nullable: false),
                    pokemonID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemMochilas", x => x.id);
                    table.ForeignKey(
                        name: "FK_ItemMochilas_Mochilas_mochilaID",
                        column: x => x.mochilaID,
                        principalTable: "Mochilas",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_ItemMochilas_Pokemons_pokemonID",
                        column: x => x.pokemonID,
                        principalTable: "Pokemons",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemMochilas_mochilaID",
                table: "ItemMochilas",
                column: "mochilaID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemMochilas_pokemonID",
                table: "ItemMochilas",
                column: "pokemonID");

            migrationBuilder.CreateIndex(
                name: "IX_Mochilas_jogadorID",
                table: "Mochilas",
                column: "jogadorID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_tipoID",
                table: "Pokemons",
                column: "tipoID");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_jogadorID",
                table: "Usuarios",
                column: "jogadorID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemMochilas");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Mochilas");

            migrationBuilder.DropTable(
                name: "Pokemons");

            migrationBuilder.DropTable(
                name: "Jogadores");

            migrationBuilder.DropTable(
                name: "Pokemon_Tipos");
        }
    }
}
