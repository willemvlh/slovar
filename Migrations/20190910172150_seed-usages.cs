﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Slovar.Migrations
{
    public partial class seedusages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            UsageSeeder seeder = new UsageSeeder();
            seeder.Seed();
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
