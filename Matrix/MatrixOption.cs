using System;
using System.Collections.Generic;

namespace Matrix
{
    public class MatrixOption
    {
        public static int CalculateSum(List<List<int>> matrix)
        {
            int sum = 0;
            foreach (var row in matrix)
            {
                foreach (var element in row)
                {
                    sum += element;
                }
            }
            return sum;
        }
    }
}
