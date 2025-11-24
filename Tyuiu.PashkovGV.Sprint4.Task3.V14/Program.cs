using Tyuiu.PashkovGV.Sprint4.Task3.V14.Lib;
namespace Tyuiu.PashkovGV.Sprint4.Task3.V14
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
            int[,] mas2 = new int[,]
            {
                { 3, 2, 3, 3, 5, },
                { 2, 3, 3, 7, 3, },
                { 7, 5, 2, 7, 3, },
                { 4, 2, 7, 5, 2, },
                { 3, 5, 4, 2, 6, }
            };
            

            int m2 = ds.Calculate(mas2);
            Console.WriteLine(m2);
        }
    }
}