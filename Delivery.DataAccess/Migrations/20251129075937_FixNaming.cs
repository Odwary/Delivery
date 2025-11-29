using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Delivery.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FixNaming : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FileName",
                table: "RestaurantImage",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "RestaurantName",
                table: "Restaurant",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ImageName",
                table: "DishImage",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "DishName",
                table: "Dish",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "UserRole",
                table: "Users",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "FileExtension",
                table: "RestaurantImage",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentMethod",
                table: "Order",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "OrderStatus",
                table: "Order",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "FileExtension",
                table: "DishImage",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<byte[]>(
                name: "Content",
                table: "DishImage",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AlterColumn<string>(
                name: "DishCategory",
                table: "Dish",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "DishImage");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "RestaurantImage",
                newName: "FileName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Restaurant",
                newName: "RestaurantName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "DishImage",
                newName: "ImageName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Dish",
                newName: "DishName");

            migrationBuilder.AlterColumn<int>(
                name: "UserRole",
                table: "Users",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "FileExtension",
                table: "RestaurantImage",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "PaymentMethod",
                table: "Order",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "OrderStatus",
                table: "Order",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "FileExtension",
                table: "DishImage",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "DishCategory",
                table: "Dish",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
