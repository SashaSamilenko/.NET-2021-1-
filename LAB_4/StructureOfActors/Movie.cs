using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureOfActors
{
    public enum GenreOfMovies
    {
        action,
        adventure,
        comedy,
        drama,
        melodrama,
        fantasy,
        historical,
        horror,
        scienceFiction,
        thriller,
        western,
        musical,
        tragedy
    }
    public class Movie
    {
        public string title { get; set; }
        public int year { get; set; }
        public GenreOfMovies genge { get; set; }
        public string director { get; set; }
        public override string ToString()
        {
            return "Title is '" + title + "'; Year is " + year + ";  Genge is" + genge+"; Director`s name is "+director;
        }
    }
}
