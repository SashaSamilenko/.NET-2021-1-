using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureOfActors
{
    public class LinkToSpectacle
    {
        public string nameOfActor { get; private set; }
        public string title { get; private set; }
        public LinkToSpectacle(string nameOfActor, string title)
        {
            this.nameOfActor = nameOfActor;
            this.title = title;
        }
    }
}
