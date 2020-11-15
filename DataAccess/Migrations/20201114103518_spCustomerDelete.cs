using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class spCustomerDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Create procedure spCustomerDelete
                                   @Id int
                                   as
                                   Begin
                                        Delete From Customers
                                        where Id=@Id
                                   End";
            migrationBuilder.Sql(procedure);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Drop procedure spCustomerDelete";
                                
            migrationBuilder.Sql(procedure);
        }
    }
}
