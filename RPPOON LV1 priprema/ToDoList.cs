using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV1_priprema
{
    class ToDoList
    {
        private List<Note> toDoList=new List<Note>();

        public void AddToList(Note note)
        {
            toDoList.Add(note);
        }
        /*
        public void RemoveFromList(Note noteForRemoval)
        {
            foreach (Note note in this.toDoList)                                
            {
                if (note.Equals(noteForRemoval))
                    toDoList.RemoveAt(toDoList.IndexOf(note));
               
            }
        }
        */

        public void RemoveFromList(Note noteForRemoval)
        {
            toDoList.RemoveAt(toDoList.IndexOf(noteForRemoval));
        }

        public Note GetSpecificNote(Note wantedNote)
        {
            Note specificNote = new Note("Wanted note does not exist!");
            foreach (Note note in this.toDoList)
            {
                if (note.Equals(wantedNote)) break;
                specificNote = note;
            }
            return specificNote;
        }

        public void PrintToDoList()
        {
            foreach (Note note in this.toDoList)
            {
                Console.WriteLine(note.ToString()); 
            }
        }

        public void DoHighestPriorityNotes()
        {
            foreach (Note note in this.toDoList.ToList<Note>())
            {
                if (CheckNotePriority(note))
                    //RemoveFromList(note);
                    this.toDoList.RemoveAt(this.toDoList.IndexOf(note));
            }
        }

        private bool CheckNotePriority(Note note)
        {
            return note.Importance == 1;
        }
        
    }
}