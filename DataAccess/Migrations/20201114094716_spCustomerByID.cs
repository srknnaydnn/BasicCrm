using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class spCustomerByID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Create procedure spCustomerGetByID
                                   @Id int
                                   as
                                   Begin
                                        Select * From Customers
                                        where ID=@Id
                                   End";
            migrationBuilder.Sql(procedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Drop procedure spCustomerGetByID";
            migrationBuilder.Sql(procedure);
        }
    }
}
