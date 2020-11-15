using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class spCustomerUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Create procedure spCustomerUpdate
                                    @Id int,
                                    @Tc varchar(11),
                                    @Name varchar(50) ,
                                    @Surname varchar(50),
                                    @Telefone varchar(11) ,
                                    @Adress varchar(50),
                                    @City varchar(50)   
                                    as
                                 Begin
                                    Update Customers Set Tc=@Tc,Name=@Name,Surname=@Surname,Telefone=@Telefone,Adress=@Adress,City=@City
                                    where Id=@Id
                                 End";
            migrationBuilder.Sql(procedure);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Create procedure spCustomerUpdate";
                                  
            migrationBuilder.Sql(procedure);
        }
    }
}
