using Microsoft.EntityFrameworkCore.Migrations;

namespace Microservices.OMS.Users.Migrations
{
    public partial class InsertUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO[dbo].[User] ([Name],[Age],[Email]) VALUES ('John', 22, 'john.doe@google.com')");
            migrationBuilder.Sql("INSERT INTO[dbo].[User] ([Name],[Age],[Email]) VALUES ('James', 25, 'james.luis@google.com')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
