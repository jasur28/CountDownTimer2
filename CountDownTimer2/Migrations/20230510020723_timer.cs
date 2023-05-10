﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CountDownTimer2.Migrations
{
    /// <inheritdoc />
    public partial class timer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TimerEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimerStarted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimerFinished = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimerEntities", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TimerEntities");
        }
    }
}
