using System;
using System.Collections.Generic;

namespace NoteTakingApp.ConsoleApp
{
    // Entity Framework Core
    // database-first approach steps...
    /*
     * 1. recommended: have a separate data access library project.
     * 2. install Microsoft.EntityFrameworkCore.Design and Microsoft.EntityFrameworkCore.SqlServer
     *    to the project you'll put the EF model in.
     * 3. using Git Bash / terminal, from the project folder run (split into several lines for clarity):
     *    dotnet ef dbcontext scaffold <connection-string-in-quotes>
     *      Microsoft.EntityFrameworkCore.SqlServer
     *      --force
     *      --no-onconfiguring
     *    https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet#dotnet-ef-dbcontext-scaffold
     *    (if you don't have dotnet ef installed, run: "dotnet tool install --global dotnet-ef")
     *    (this will fail if your projects do not compile)
     * 4. any time you change the structure of the tables (DDL), go to step 3.
     */

    class Program
    {
        static List<Note> s_notes = new List<Note>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Note Taking App");

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1: List notes");
                Console.WriteLine("2: Add new note");
                Console.WriteLine("3: Quit");
                Console.WriteLine();
                Console.Write("> ");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    ListNotes();
                }
                else if (input == "2")
                {
                    AddNewNote();
                }
                else if (input == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Input not recognized, try again");
                }
            }
        }

        private static void AddNewNote()
        {
            Console.WriteLine();
            Console.WriteLine("Enter note contents:");
            Console.Write("> ");

            string input2 = Console.ReadLine();
            var note = new Note { Text = input2 };

            s_notes.Add(note);
        }

        private static void ListNotes()
        {
            Console.WriteLine();
            if (s_notes.Count == 0)
            {
                Console.WriteLine("(none)");
            }
            else
            {
                foreach (var note in s_notes)
                {
                    Console.WriteLine(note.Text);
                }
            }
        }
    }
}
