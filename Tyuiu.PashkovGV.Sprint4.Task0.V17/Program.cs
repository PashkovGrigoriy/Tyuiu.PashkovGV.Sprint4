using Tyuiu.PashkovGV.Sprint4.Task0.V17.Lib;

namespace Tyuiu.PashkovGV.Sprint4.Task0.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[] m = { 4,8,7,6,5,8,2,4,3,2 };
            int m2 = ds.GetSumEvenArrEl(m);
            Console.WriteLine(m2);

        }
    }
}