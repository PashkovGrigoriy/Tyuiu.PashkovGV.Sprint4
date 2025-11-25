using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PashkovGV.Sprint4.Task4.V12.Lib
{
    public class DataService : ISprint4Task4V12
    {
        public int[,] Calculate(int[,] matrix)
        {
            
            int st = matrix.GetUpperBound(0) + 1;
            int ct = matrix.Length / st;
            for (int i = 0; i < st; i++)
            {
                for (int j = 0; j < ct; j++)
                    if (matrix[i, j] % 2 == 0)
                    {
                        matrix[i, j] = 1;
                    }
            }
            return matrix;
        }
    }
}
