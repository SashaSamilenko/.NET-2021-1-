using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carriers
{
    public class MatrixOfContiguity
    {
        public List<string> cities=null;
        public List<List<int>> matrixOfContiguity = new List<List<int>> { };
        public void AddCity(string city)
        {
            cities.Add(city);
        }
        private void CreateMatrix()
        {
            matrixOfContiguity.Add(new List<int> { 1, 1, 0, 0, 0, 0, 1, 1, 0, 0 });
            matrixOfContiguity.Add(new List<int> { 1, 1, 1, 0, 1, 0, 1, 0, 0, 0 });
            matrixOfContiguity.Add(new List<int> { 0, 1, 1, 1, 1, 0, 0, 0, 0, 0 });
            matrixOfContiguity.Add(new List<int> { 0, 0, 1, 1, 1, 1, 0, 0, 1, 0 });
            matrixOfContiguity.Add(new List<int> { 0, 1, 1, 1, 1, 1, 1, 0, 0, 0 });
            matrixOfContiguity.Add(new List<int> { 0, 0, 0, 1, 1, 1, 1, 1, 1, 1 });
            matrixOfContiguity.Add(new List<int> { 1, 1, 0, 0, 1, 1, 1, 1, 0, 0 });
            matrixOfContiguity.Add(new List<int> { 1, 0, 0, 0, 0, 1, 1, 1, 0, 1 });
            matrixOfContiguity.Add(new List<int> { 0, 0, 0, 1, 0, 1, 0, 0, 1, 1 });
            matrixOfContiguity.Add(new List<int> { 0, 0, 0, 0, 0, 1, 0, 1, 1, 1 });
        }
    }
}
