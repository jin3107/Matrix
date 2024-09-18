using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    public class MatrixOutput
    {
        public static void PrintMatrix(List<List<int>> matrix)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("\n\t--- Ma trận đã nhập ---\n");
            foreach (var row in matrix)
            {
                foreach (var element in row)
                {
                    Console.Write($"\t{element}");
                }
                Console.WriteLine();
            }
        }

        public static void PrintMatrixSum(List<List<int>> matrix)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int sum = MatrixOption.CalculateSum(matrix);
            Console.WriteLine($"\n\tTổng các phần tử của ma trận: {sum}");
        }
    }
}
