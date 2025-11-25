using Tyuiu.PashkovGV.Sprint4.Task4.V12.Lib;
namespace Tyuiu.PashkovGV.Sprint4.Task4.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int len;
            int tte;
            Console.WriteLine("Введите строки ");
            len = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите столбцы ");
            tte = Convert.ToInt32(Console.ReadLine());
            int[,] res = new int[len,tte];
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < tte; j++)
                {
                    Console.WriteLine($"Введите значение {i},{j} Элемента массива");
                    res[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[,] m2 = ds.Calculate(res);
            Console.WriteLine(m2);
            Console.ReadKey();
        }
    }
}