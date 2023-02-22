using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_aaronp5.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    movieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    categoryId = table.Column<int>(nullable: false),
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
                    table.ForeignKey(
                        name: "FK_movies_Categories_categoryId",
                        column: x => x.categoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 1, "Action" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 2, "Comedy" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 3, "Horror" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 4, "Drama" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 5, "Chick Flick" });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "movieId", "categoryId", "director", "edited", "lentTo", "note", "rating", "title" },
                values: new object[] { 1, 1, "Steven Spielberg", true, "Jack", "Nothing much", "PG-13", "Indiana Jones" });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "movieId", "categoryId", "director", "edited", "lentTo", "note", "rating", "title" },
                values: new object[] { 2, 1, "Chris Columbus", true, "John", "Boring", "PG", "Home Alone" });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "movieId", "categoryId", "director", "edited", "lentTo", "note", "rating", "title" },
                values: new object[] { 3, 3, "Steven Spielberg", true, "James", "Sharks", "PG-13", "Jaws" });

            migrationBuilder.CreateIndex(
                name: "IX_movies_categoryId",
                table: "movies",
                column: "categoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "movies");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
