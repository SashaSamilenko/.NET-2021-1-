using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureOfActors
{
    public class LinkToMovie
    {
        public string nameOfActor { get; private set; }
        public string title { get; private set; }
        public int year { get; private set; }
        public LinkToMovie(string nameOfActor, string title, int year)
        {
            this.nameOfActor = nameOfActor;
            this.title = title;
            this.year = year;
            //throw new ArgumentOutOfRangeException("Value of year out of range");
        }
    }
}
