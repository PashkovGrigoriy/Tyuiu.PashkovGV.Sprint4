using Tyuiu.PashkovGV.Sprint4.Task5.V7.Lib;
namespace Tyuiu.PashkovGV.Sprint4.Task5.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            int len;
            Console.WriteLine("Введите стр ");
            len = Convert.ToInt32(Console.ReadLine());
            int def;
            Console.WriteLine("Введите столб ");
            def = Convert.ToInt32(Console.ReadLine());
            int[,] res = new int[len,def];
            for (int i = 0; i < len - 1; i++)
            {
                for (int j = 0; j < def; j++)
                {
                    res[i,j] = rnd.Next(-7, 7);
                }
            }

            int m2 = ds.Calculate(res);
            Console.WriteLine(m2);
            Console.ReadLine();
        }
    }
}