using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carriers
{
    static public class MatrixOfDistance
    {
        static internal List<List<double>> matrixOfContiguity = new List<List<double>> { };
        static internal List<List<double>> matrixOfMinimumDistance = new List<List<double>> { };
    static internal void CreateMatrix()
        {
            matrixOfContiguity.Add(new List<double> { 0, 955, -1, -1, -1, -1, 482, 682, -1, -1 });
            matrixOfContiguity.Add(new List<double> { 955, 0, 546, -1, 529, -1, 529, -1, -1, -1 });
            matrixOfContiguity.Add(new List<double> { -1, 546, 0, 393, 523, -1, -1, -1, -1, -1 });
            matrixOfContiguity.Add(new List<double> { -1, -1, 393, 0, 211, 402, -1, -1, 683, -1 });
            matrixOfContiguity.Add(new List<double> { -1, 529, 523, 211, 0, 188, 327, -1, -1, -1 });
            matrixOfContiguity.Add(new List<double> { -1, -1, -1, 402, 188, 0, 140, 501, 787, 652 });
            matrixOfContiguity.Add(new List<double> { 482, 529, -1, -1, 327, 140, 0, 496, -1, -1 });
            matrixOfContiguity.Add(new List<double> { 682, -1, -1, -1, -1, 501, 496, 0, -1, 346 });
            matrixOfContiguity.Add(new List<double> { -1, -1, -1, 683, -1, 787, -1, -1, 0, 268 });
            matrixOfContiguity.Add(new List<double> { -1, -1, -1, -1, -1, 652, -1, 346, 268, 0 });
        }
        static internal void GetMinimumDistance()
        {
            int count = matrixOfContiguity.Count;
            matrixOfMinimumDistance = matrixOfContiguity;
            for (int k = 0; k < count; k++)
            {
                for (int i = 0; i < count; i++)
                {
                    for (int j = 0; j < count; j++)
                    {
                        if (i != j && matrixOfMinimumDistance[i][k] != -1 && matrixOfMinimumDistance[k][j] != -1)
                        {
                            if (matrixOfMinimumDistance[i][j] == -1)
                            {
                                matrixOfMinimumDistance[i][j] = matrixOfMinimumDistance[i][k] + matrixOfMinimumDistance[k][j];
                            }
                            else
                            {
                                matrixOfMinimumDistance[i][j] = Min(matrixOfMinimumDistance[i][j], matrixOfMinimumDistance[i][k] + matrixOfMinimumDistance[k][j]);
                            }
                        }
                    }
                }
            }
            /*for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    Console.Write($"{newMatrix[i][j]}    ");
                }
                Console.WriteLine();
            }*/
        }
        static private double Min(double a, double b)
        {
            if (a > b) return b;
            else return a;
        }
    }
}