using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AMS3ASales.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Product(Id,IsActive,Description,Price,Stock,ImageURL,CreateDate) VALUES ('f0b9f35c-3f7b-4eb9-95b4-97d329f4b244',1,'Água com gás',4,50,'aguacomgas.jpg','2007-01-01 10:00:00' )");
            migrationBuilder.Sql("INSERT INTO Product(Id,IsActive,Description,Price,Stock,ImageURL,CreateDate) VALUES ('cf6d28b4-fcee-4e1a-b77f-d94e1540a855',1,'Trident',3,10,'trident.jpg','2007-01-01 10:10:00' )");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP TABLE Product");
        }
    }
}
