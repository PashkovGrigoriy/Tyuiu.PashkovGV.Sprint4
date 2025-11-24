using System.Runtime.Intrinsics.Arm;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PashkovGV.Sprint4.Task3.V14.Lib
{
    public class DataService : ISprint4Task3V14
    {
        public int Calculate(int[,] array)
        {
            int sim = 0;
            int st = array.GetUpperBound(0)+1;
            int ct = array.Length / st;
            for (int i = 0; i < st; i++)
            {
                for (int j = 0; j < ct; j++)
                    if( array[i,j] > sim )
                    {
                        sim = (array[i, j]);
                    }
            }
            return sim;
        }
    }
}
