using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using carriers;


namespace Laba_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrixOfDistance matrix = new MatrixOfDistance();
            matrix.GoAlgoritmFloyda();
            Console.ReadKey();
        }
    }
}
