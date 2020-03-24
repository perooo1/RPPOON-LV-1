using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV1_priprema
{
    class Program_sedmi_zadatak
    {
        static void Main(string[] args)
        {
            ToDoList toDoList = new ToDoList();
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Do you wish to enter author of your note " + (i + 1) + "?");
                Console.WriteLine("Write 'yes' if you do, otherwise press enter.");

                string authorChoice = Console.ReadLine();
                if (authorChoice == "yes")
                {
                    Console.WriteLine("Please enter author of your note " + (i + 1) + ":");
                    string author = Console.ReadLine();
                    Console.WriteLine("Please enter importance lvl of your note, 1 being highest and 3 being lowest: ");
                    int importance = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter your text of note "+(i+1)+":");
                    string text = Console.ReadLine();
                    TimestampNote note = new TimestampNote(author, text, importance);
                    toDoList.AddToList(note);
                }
                else
                {
                    TimestampNote note = new TimestampNote();
                    Console.WriteLine("Please enter importance lvl of your note 1 being highest and 3 being lowest " + (i + 1) + ":");
                    note.Importance = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter your text of note " + (i + 1) + ":");
                    note.Text = Console.ReadLine();
                    toDoList.AddToList(note);
                }
                
            }
            Console.WriteLine("\n\n\nYour ToDo List:\n");
            toDoList.PrintToDoList();

            Console.WriteLine("List after doing highest priority tasks:");
            toDoList.DoHighestPriorityNotes();
            toDoList.PrintToDoList();
        }
    }
}
