using UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using DL.Entities;
using BL;
using DL;
using System.IO;
using Serilog;
using System;

// be careful making assumptions about Directory.GetCurrentDirectory() --
// visual studio and dotnet run make that the project source code directory,
// but that's only how devs run .net apps, not how they get run for real users.

var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

string connectionString = configuration.GetConnectionString("petdb");

DbContextOptions<petdbContext> options = new DbContextOptionsBuilder<petdbContext>()
    .UseSqlServer(connectionString)
    .Options;

var context = new petdbContext(options);

// HealthStatus status;
// var obj=status.getInstance;

try
{

    IMenu menu = new MainMenu(new PetBL(new PetRepo(context)));
    menu.Start();
}
catch (Exception e)
{
    Log.Fatal(e, "program must exit");
}


// ON DELETE CASCADE on a foreign key makes it so:
// DELETE FROM Cat WHERE Id = 5
//   rather than an error...
// "1 row affected" (in cat table)
// "3000 rows affected" (all the meals that referenced it)
// sometimes this is what you want, other times not.
// decision to be made for each foreign key relationship constraint.
