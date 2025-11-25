using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PashkovGV.Sprint4.Task5.V7.Lib
{
    public class DataService : ISprint4Task5V7
    {
        public int Calculate(int[,] matrix)
        {
            int count = 0;
            int st = matrix.GetUpperBound(0) + 1;
            int ct = matrix.Length / st;
            for (int i = 0; i < st; i++)
            {
                for (int j = 0; j < ct; j++)
                    if (matrix[i, j] < 0)
                    {
                        count++;
                    }
            }
            return count;
        }
    }
}
