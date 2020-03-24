using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV1_priprema
{
    class Note
    {
        private string author;
        private string text;
        private int importance; // [1-3], 1- highest, 3-lowest

        public string GetAuthor() { return this.author; }
        public string GetText() { return this.text; }
        public void SetText(string text) { this.text = text; }
        public int GetImportance() { return this.importance; }
        public void SetImportance(int importance) { this.importance = importance; }

        public string Text
        {
            get { return this.text; }
            set { this.text = value; }
        }
        public int Importance
        {
            get { return this.importance; }
            set { this.importance = value; }
        }
        public string Author
        {
            get { return this.author; }
            private set { this.author = value; }
        }

        public Note(string text)
        {
            this.text = text;
            this.author = "N/A";
            this.importance = 3;
        }

        public Note()
        {
            this.author = "N/A";
            this.text = "N/A";
            this.importance = 3;
        }
        public Note(string author, string text, int importance)
        {
            this.author = author;
            this.text = text;
            this.importance = importance;
        }

        public Note(string author, string text)
        {
            this.author = author;
            this.text = text;
            this.importance = 3;
        }

        public override string ToString()
        {
            return  "Note author: " + this.Author + "\n" + 
                    "Text: " + this.Text + "\n" +  
                    "Importance lvl: " + this.Importance + "\n";
        }

    }
}
