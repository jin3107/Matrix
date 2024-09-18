using Matrix;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

List<List<int>> matrix = MatrixInput.GetMatrix();

MatrixOutput.PrintMatrix(matrix);
MatrixOutput.PrintMatrixSum(matrix);

Console.ReadLine();