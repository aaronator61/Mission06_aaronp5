using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_aaronp5.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    movieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    category = table.Column<string>(nullable: false),
                    title = table.Column<string>(nullable: false),
                    director = table.Column<string>(nullable: false),
                    rating = table.Column<string>(nullable: false),
                    edited = table.Column<bool>(nullable: false),
                    lentTo = table.Column<string>(nullable: true),
                    note = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.movieId);
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "movieId", "category", "director", "edited", "lentTo", "note", "rating", "title" },
                values: new object[] { 1, "Action", "Steven Spielberg", true, "Jack", "Nothing much", "PG-13", "Indiana Jones" });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "movieId", "category", "director", "edited", "lentTo", "note", "rating", "title" },
                values: new object[] { 2, "Comdey", "Chris Columbus", true, "John", "Boring", "PG", "Home Alone" });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "movieId", "category", "director", "edited", "lentTo", "note", "rating", "title" },
                values: new object[] { 3, "Action", "Steven Spielberg", true, "James", "Sharks", "PG-13", "Jaws" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
