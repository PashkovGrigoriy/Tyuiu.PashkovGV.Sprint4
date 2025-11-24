using System.Security.Authentication;
using Tyuiu.PashkovGV.Sprint4.Task1.V28.Lib;
namespace Tyuiu.PashkovGV.Sprint4.Task1.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int len;
            Console.WriteLine("Введите длину ");
            len = Convert.ToInt32(Console.ReadLine());
            int[] res = new int[len];
            for (int i = 0; i < len - 1; i++)
            {
                Console.WriteLine("Введите значение " + i + " Элемента массива");
                res[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            int m2 = ds.Calculate(res);
            Console.WriteLine(m2);
        }
    }
}