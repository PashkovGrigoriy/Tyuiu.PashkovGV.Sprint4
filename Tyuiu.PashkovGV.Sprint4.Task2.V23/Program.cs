using Tyuiu.PashkovGV.Sprint4.Task2.V23.Lib;
namespace Tyuiu.PashkovGV.Sprint4.Task2.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            int len;
            Console.WriteLine("Введите длину ");
            len = Convert.ToInt32(Console.ReadLine());
            int[] res = new int[len];
            for (int i = 0; i < len - 1; i++)
            {
                res[i] = rnd.Next(3,8);
            }

            int m2 = ds.Calculate(res);
            Console.WriteLine(m2);
        }
    }
}