using Tyuiu.PashkovGV.Sprint4.Task7.V21.Lib;
namespace Tyuiu.PashkovGV.Sprint4.Task7.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int n = 4;
            int m = 3;
            string t = "425963128528";
            int res = ds.Calculate(n, m, t);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}