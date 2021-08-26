using System;
using System.Collections.Generic;

namespace NoteTakingApp.ConsoleApp
{
    class Program
    {
        static List<string> s_notes = new List<string>();

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

            s_notes.Add(input2);
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
                    Console.WriteLine(note);
                }
            }
        }
    }
}
