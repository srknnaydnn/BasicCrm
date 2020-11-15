using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class spCreateAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Create procedure spCreateAdd
                                    @Username varchar(10),
                                    @Email varchar(50) ,
                                    @Password varchar(11),
                                    @ConfirmPassword varchar(50)
                                   as
                                   Begin
                                        Insert Into Users
                                            (Username,Email,Password,ConfirmPassword)
                                            Values (@Username,@Email,@Password,@ConfirmPassword)
                                   End";
            migrationBuilder.Sql(procedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Drop procedure spCreateAdd";

            migrationBuilder.Sql(procedure);

        }
    }
}
