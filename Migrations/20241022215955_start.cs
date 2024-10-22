using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace managers_back.Migrations
{
    /// <inheritdoc />
    public partial class start : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManagerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stacks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rank = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "Description", "ManagerName", "Rank", "RoleName", "Stacks" },
                values: new object[,]
                {
                    { 1L, "...", "Andre Stamare", null, "FullStack Developer", "[\"C#\",\"Reactjs\",\"PostgreSQL\",\"Kafka\"]" },
                    { 2L, "DDS", "Thiago Vasconcelos", null, "Frontend Developer", "[\"HTML\",\"CSS\",\"SASS\",\"Javascript\",\"Typescript\",\"Jest\",\"MDX\",\"ExpressJS\",\"Copilot\",\"Storybook\"]" },
                    { 3L, "Microfront ends ", "Guilherme Choque", null, "Fullstack Developer", "[\"C#\",\"Angular\"]" },
                    { 4L, "Microfront ends ", "Guilherme Choque", null, "Fullstack Developer", "[\"C#\",\"Angular\"]" },
                    { 5L, "Opal", "Alexandre Pimentel", null, "Backend Developer", "[\"Java\",\"Springboot\",\"RabbitMQ\",\"MongoDB\",\"React\",\"PostgreSQL\",\"Python\"]" },
                    { 6L, "...", "Stefan Albuquerque", null, "Fullstack Developer", "[\"ReactJs\",\"Angular\",\"WordPress\",\"Python\",\".NET Core\",\"Springboot\",\"Java\",\"SQL\",\"MSSQL Type ORM\"]" },
                    { 7L, "...", "Valdomiro Rischtter", null, "Fullstack Developer", "[\"C#\",\".NET Core\",\"Angular\",\"Javascript\",\"Typescript\",\"MongoDB\",\"SQL Server\"]" },
                    { 8L, "...", "Marco Hinz", null, "Backend Developer", "[\"Java\",\"Springboot\",\"Codeium\",\"CI/CD\",\"RabbitMQ\",\"MongoDB\",\"Pivotal Cloud Foundry\",\"Kubernetes\",\"Kafka\"]" },
                    { 9L, "...", "Luciano Santos", null, "???????", "[\"??\",\"???\",\"????\"]" },
                    { 10L, "Asset Team", "Fernanda Gomes", null, "Backend - DevOps", "[\"Java\",\"Springboot\",\"Cloud Foundry\",\"Angular\",\"Oracle\",\"Kafka\",\"Nodejs\",\"Typescript\",\"DDS\",\"Kubernetes\",\"RabbitMQ\",\"Redis\",\"MongoDB\"]" },
                    { 11L, "...", "Leo Tessman", null, "Backend Developer", "[\"Java\",\"Oracle\",\"Microservices\",\"Springboot\",\"Kafka\",\"Elastic\",\"GraphQL\",\"Pivotal Cloud Foundry\",\"Conductor\",\"RabbitMQ\"]" },
                    { 12L, "Banzai", "Luciane Furini", null, "Fullstack Developer", "[\"C#\",\".NET Core\",\"Javascript\",\"React\",\"MongoDB\",\"SQL Server\"]" },
                    { 13L, "...", "Rafael Astrana", null, "Fullstack Developer", "[\"Java\",\"React\",\"Go\",\"Python\",\"PL/SQL\"]" },
                    { 14L, "top1, pair programming", "Cicero Furini", null, "Backend Developer", "[\"Java\",\"Springboot\",\"Pivotal Clound Foundry\",\"Oracle\",\"Elastic\",\"Redis\",\"GraphQL\",\"RabbitMQ\",\"Kafka\",\"Conductor\",\"Splunk\",\"Dynatrace\"]" },
                    { 15L, "????", "Francisco Letwinka", null, "???", "[\"??\",\"???\",\"????\"]" },
                    { 16L, "...", "Lilyan Fernande", null, "Fullstack Developer", "[\"Java\",\"React\",\"Go\",\"Python\",\"PL/SQL\",\"Typescript\",\"PostgreSQL\",\"AI/ML\",\"CI/CD\"]" },
                    { 17L, "??", "Gustavo Tourinho", null, "???", "[\"??\",\"???\",\"????\"]" },
                    { 18L, "...", "Bruno Souza", null, "DevOps", "[\"Python\",\"Javascript\",\"AIOps\",\"Data Science\",\"Analytics\",\"Bot and Conversation AI/Gen AI\"]" },
                    { 19L, "Quicksilver", "Tassia Borochede", null, "Frontend Developer", "[\"Nextjs\",\"React\",\"Typescript\",\"Node\"]" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Managers");
        }
    }
}
