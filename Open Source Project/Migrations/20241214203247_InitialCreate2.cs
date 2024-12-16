using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Open_Source_Project.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Table_AspNetUsers_ApplicationUserId",
                table: "User_Table");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Table_AspNetUsers_ApplicationUserId1",
                table: "User_Table");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Table_Table_TableId",
                table: "User_Table");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Table_Table_TableId1",
                table: "User_Table");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User_Table",
                table: "User_Table");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Table",
                table: "Table");

            migrationBuilder.RenameTable(
                name: "User_Table",
                newName: "User_Tables");

            migrationBuilder.RenameTable(
                name: "Table",
                newName: "Tables");

            migrationBuilder.RenameIndex(
                name: "IX_User_Table_TableId1",
                table: "User_Tables",
                newName: "IX_User_Tables_TableId1");

            migrationBuilder.RenameIndex(
                name: "IX_User_Table_ApplicationUserId1",
                table: "User_Tables",
                newName: "IX_User_Tables_ApplicationUserId1");

            migrationBuilder.RenameIndex(
                name: "IX_User_Table_ApplicationUserId",
                table: "User_Tables",
                newName: "IX_User_Tables_ApplicationUserId");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User_Tables",
                table: "User_Tables",
                columns: new[] { "TableId", "ApplicationUserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tables",
                table: "Tables",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Tables_AspNetUsers_ApplicationUserId",
                table: "User_Tables",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Tables_AspNetUsers_ApplicationUserId1",
                table: "User_Tables",
                column: "ApplicationUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Tables_Tables_TableId",
                table: "User_Tables",
                column: "TableId",
                principalTable: "Tables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Tables_Tables_TableId1",
                table: "User_Tables",
                column: "TableId1",
                principalTable: "Tables",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Tables_AspNetUsers_ApplicationUserId",
                table: "User_Tables");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Tables_AspNetUsers_ApplicationUserId1",
                table: "User_Tables");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Tables_Tables_TableId",
                table: "User_Tables");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Tables_Tables_TableId1",
                table: "User_Tables");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User_Tables",
                table: "User_Tables");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tables",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "User_Tables",
                newName: "User_Table");

            migrationBuilder.RenameTable(
                name: "Tables",
                newName: "Table");

            migrationBuilder.RenameIndex(
                name: "IX_User_Tables_TableId1",
                table: "User_Table",
                newName: "IX_User_Table_TableId1");

            migrationBuilder.RenameIndex(
                name: "IX_User_Tables_ApplicationUserId1",
                table: "User_Table",
                newName: "IX_User_Table_ApplicationUserId1");

            migrationBuilder.RenameIndex(
                name: "IX_User_Tables_ApplicationUserId",
                table: "User_Table",
                newName: "IX_User_Table_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User_Table",
                table: "User_Table",
                columns: new[] { "TableId", "ApplicationUserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Table",
                table: "Table",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Table_AspNetUsers_ApplicationUserId",
                table: "User_Table",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Table_AspNetUsers_ApplicationUserId1",
                table: "User_Table",
                column: "ApplicationUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Table_Table_TableId",
                table: "User_Table",
                column: "TableId",
                principalTable: "Table",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Table_Table_TableId1",
                table: "User_Table",
                column: "TableId1",
                principalTable: "Table",
                principalColumn: "Id");
        }
    }
}
