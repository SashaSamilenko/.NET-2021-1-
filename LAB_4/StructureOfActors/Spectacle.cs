using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureOfActors
{
    public enum GenreOfSpectacles
    {
        vaudeville,
        buffoonery,
        comedy,
        drama,
        melodrama,
        tragedy,
        musical
    }
    public class Spectacle
    {
        public string title { get; set; }
        public GenreOfSpectacles genge { get; set; }
        public override string ToString()
        {
            return "Title is '" + title + "'; Genge is " + genge;
        }
    }
}
