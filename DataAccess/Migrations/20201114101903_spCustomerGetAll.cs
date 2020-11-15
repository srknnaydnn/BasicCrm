using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class spCustomerGetAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Create procedure spCustomerGetAll
                                   
                                   as
                                   Begin
                                        Select * From Customers
                                       
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
