using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class spCustomerAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure= @"Create procedure spCustomerAdd
                                   @Tc varchar(11),
                                    @Name varchar(50) ,
                                    @Surname varchar(50),
                                    @Telefone varchar(11) ,
                                    @Adress varchar(50),
                                    @City varchar(50)
                                   as
                                   Begin
                                        Insert Into Customers
                                            (Tc,Name,Surname,Telefone,Adress,City)
                                            Values (@Tc,@Name,@Surname,@Telefone,@Adress,@City)
                                   End";
            migrationBuilder.Sql(procedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Drop procedure spCustomerAdd";

            migrationBuilder.Sql(procedure);
        }
    }
}
