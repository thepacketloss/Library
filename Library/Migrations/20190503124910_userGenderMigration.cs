﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class userGenderMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
//            migrationBuilder.AlterColumn<string>(
//                name: "BookGroupName",
//                table: "BookGroups",
//                nullable: false,
//                oldClrType: typeof(string),
//                oldNullable: true);

//            migrationBuilder.AlterColumn<string>(
//                name: "BookGroupDescription",
//                table: "BookGroups",
//                nullable: false,
//                oldClrType: typeof(string),
//                oldNullable: true);
//
//            migrationBuilder.AlterColumn<string>(
//                name: "AuthorName",
//                table: "Authors",
//                nullable: false,
//                oldClrType: typeof(string),
//                oldNullable: true);

//            migrationBuilder.AlterColumn<string>(
//                name: "AuthorDescription",
//                table: "Authors",
//                nullable: false,
//                oldClrType: typeof(string),
//                oldNullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "gender",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "gender",
                table: "AspNetUsers");

//            migrationBuilder.AlterColumn<string>(
//                name: "BookGroupName",
//                table: "BookGroups",
//                nullable: true,
//                oldClrType: typeof(string));
//
//            migrationBuilder.AlterColumn<string>(
//                name: "BookGroupDescription",
//                table: "BookGroups",
//                nullable: true,
//                oldClrType: typeof(string));
//
//            migrationBuilder.AlterColumn<string>(
//                name: "AuthorName",
//                table: "Authors",
//                nullable: true,
//                oldClrType: typeof(string));
//
//            migrationBuilder.AlterColumn<string>(
//                name: "AuthorDescription",
//                table: "Authors",
//                nullable: true,
//                oldClrType: typeof(string));
        }
    }
}
