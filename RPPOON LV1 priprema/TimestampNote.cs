using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV1_priprema
{
    class TimestampNote : Note
    {
        private DateTime timeOfCreation;
        

        public TimestampNote():base()
        {
            timeOfCreation = DateTime.Now;
        }

        public TimestampNote(string author, string text, int importance) : base(author, text, importance)
        {
            timeOfCreation = DateTime.Now;
        }

        public TimestampNote(string author, string text) : base(author, text)
        {
            timeOfCreation = DateTime.Now;
        }

        public TimestampNote(string text) : base(text)
        {
            timeOfCreation = DateTime.Now;
        }
        
        public DateTime TimeOfCreation
        {
            get { return this.timeOfCreation; }
            private set { this.timeOfCreation = value; }
        }
        
        public override string ToString()
        {
            return  "Time of creation: "+this.TimeOfCreation + "\n"+ base.ToString() + "\n";
        }
    }
}
