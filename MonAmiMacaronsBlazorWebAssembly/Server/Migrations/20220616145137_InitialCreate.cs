using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonAmiMacaronsBlazorWebAssembly.Server.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { 1, "Macarons", "macarons" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { 2, "Cakes", "cakes" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { 3, " Choux pastry", "choux-pastry" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Das Macaron ist ein französisches Baisergebäck aus Mandelmehl, dessen Herkunft bis ins Mittelalter zurückreicht. In Frankreich werden viele Varianten von traditionellen Macarons gebacken, davon ist heute das bunte Macaron in Form einer kleinen Doppelscheibe mit einer Cremeschicht dazwischen am weitesten verbreitet.", "https://www.einfachbacken.de/sites/einfachbacken.de/files/styles/700_530/public/2020-03/macarons.jpg?h=4521fff0&itok=w8VpTt7p", 19.99m, "Shoko Macarons" },
                    { 2, 2, "Das Macaron ist ein französisches Baisergebäck aus Mandelmehl, dessen Herkunft bis ins Mittelalter zurückreicht. In Frankreich werden viele Varianten von traditionellen Macarons gebacken, davon ist heute das bunte Macaron in Form einer kleinen Doppelscheibe mit einer Cremeschicht dazwischen am weitesten verbreitet.", "https://img.chefkoch-cdn.de/rezepte/1659951274094329/bilder/802341/crop-600x400/macarons.jpg", 15.99m, " Citronen Macarons" },
                    { 3, 3, "Das Macaron ist ein französisches Baisergebäck aus Mandelmehl, dessen Herkunft bis ins Mittelalter zurückreicht. In Frankreich werden viele Varianten von traditionellen Macarons gebacken, davon ist heute das bunte Macaron in Form einer kleinen Doppelscheibe mit einer Cremeschicht dazwischen am weitesten verbreitet.", "https://www.kuechengoetter.de/uploads/media/630x630/00/80750-luftige-schoko-macarons.webp?v=2-15", 16.99m, "Vanilie Macarons" },
                    { 4, 2, "Das Macaron ist ein französisches Baisergebäck aus Mandelmehl, dessen Herkunft bis ins Mittelalter zurückreicht. In Frankreich werden viele Varianten von traditionellen Macarons gebacken, davon ist heute das bunte Macaron in Form einer kleinen Doppelscheibe mit einer Cremeschicht dazwischen am weitesten verbreitet.", "https://www.einfachbacken.de/sites/einfachbacken.de/files/styles/700_530/public/2020-03/macarons.jpg?h=4521fff0&itok=w8VpTt7p", 19.99m, "Shoko Macarons" },
                    { 5, 2, "Das Macaron ist ein französisches Baisergebäck aus Mandelmehl, dessen Herkunft bis ins Mittelalter zurückreicht. In Frankreich werden viele Varianten von traditionellen Macarons gebacken, davon ist heute das bunte Macaron in Form einer kleinen Doppelscheibe mit einer Cremeschicht dazwischen am weitesten verbreitet.", "https://img.chefkoch-cdn.de/rezepte/1659951274094329/bilder/802341/crop-600x400/macarons.jpg", 15.99m, " Citronen Macarons" },
                    { 6, 1, "Das Macaron ist ein französisches Baisergebäck aus Mandelmehl, dessen Herkunft bis ins Mittelalter zurückreicht. In Frankreich werden viele Varianten von traditionellen Macarons gebacken, davon ist heute das bunte Macaron in Form einer kleinen Doppelscheibe mit einer Cremeschicht dazwischen am weitesten verbreitet.", "https://www.kuechengoetter.de/uploads/media/630x630/00/80750-luftige-schoko-macarons.webp?v=2-15", 16.99m, "Vanilie Macarons" },
                    { 7, 3, "Das Macaron ist ein französisches Baisergebäck aus Mandelmehl, dessen Herkunft bis ins Mittelalter zurückreicht. In Frankreich werden viele Varianten von traditionellen Macarons gebacken, davon ist heute das bunte Macaron in Form einer kleinen Doppelscheibe mit einer Cremeschicht dazwischen am weitesten verbreitet.", "https://www.kuechengoetter.de/uploads/media/630x630/00/80750-luftige-schoko-macarons.webp?v=2-15", 16.99m, "Vanilie Macarons" },
                    { 8, 2, "Das Macaron ist ein französisches Baisergebäck aus Mandelmehl, dessen Herkunft bis ins Mittelalter zurückreicht. In Frankreich werden viele Varianten von traditionellen Macarons gebacken, davon ist heute das bunte Macaron in Form einer kleinen Doppelscheibe mit einer Cremeschicht dazwischen am weitesten verbreitet.", "https://www.einfachbacken.de/sites/einfachbacken.de/files/styles/700_530/public/2020-03/macarons.jpg?h=4521fff0&itok=w8VpTt7p", 19.99m, "Shoko Macarons" },
                    { 9, 2, "Das Macaron ist ein französisches Baisergebäck aus Mandelmehl, dessen Herkunft bis ins Mittelalter zurückreicht. In Frankreich werden viele Varianten von traditionellen Macarons gebacken, davon ist heute das bunte Macaron in Form einer kleinen Doppelscheibe mit einer Cremeschicht dazwischen am weitesten verbreitet.", "https://img.chefkoch-cdn.de/rezepte/1659951274094329/bilder/802341/crop-600x400/macarons.jpg", 15.99m, " Citronen Macarons" },
                    { 10, 1, "Das Macaron ist ein französisches Baisergebäck aus Mandelmehl, dessen Herkunft bis ins Mittelalter zurückreicht. In Frankreich werden viele Varianten von traditionellen Macarons gebacken, davon ist heute das bunte Macaron in Form einer kleinen Doppelscheibe mit einer Cremeschicht dazwischen am weitesten verbreitet.", "https://www.kuechengoetter.de/uploads/media/630x630/00/80750-luftige-schoko-macarons.webp?v=2-15", 16.99m, "Vanilie Macarons" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
