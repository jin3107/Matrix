using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    public class MatrixInput
    {
        public static int GetPositiveInteger(string message)
        {
            int number;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write(message);
            while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
            {
                Console.WriteLine("Dữ liệu nhập không hợp lệ. Vui lòng nhập lại số nguyên dương!\n");
                Console.Write(message);
            }
            return number;
        }

        public static int GetMatrixElement(int row, int col)
        {
            int element;
            Console.Write($"\tA[{row}][{col}] = ");
            while (!int.TryParse(Console.ReadLine(), out element))
            {
                Console.WriteLine("\nDữ liệu nhập không hợp lệ. Vui lòng nhập lại một số nguyên!\n");
                Console.Write($"\tA[{row}][{col}] = ");
            }
            return element;
        }

        public static List<List<int>> GetMatrix()
        {
            int rows = GetPositiveInteger("\nNhập số hàng của ma trận: ");
            int cols = GetPositiveInteger("Nhập số cột của ma trận: ");

            List<List<int>> matrix = new List<List<int>>();
            for (int i = 0; i < rows; i++)
            {
                List<int> row = new List<int>();
                for (int j = 0; j < cols; j++)
                {
                    row.Add(GetMatrixElement(i, j));
                }
                matrix.Add(row);
            }
            return matrix;
        }
    }
}
