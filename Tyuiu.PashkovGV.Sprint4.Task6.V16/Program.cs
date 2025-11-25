using Tyuiu.PashkovGV.Sprint4.Task6.V16.Lib;
namespace Tyuiu.PashkovGV.Sprint4.Task6.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string[] len = { "Автомобиль", "Велосипед", "Самолет", "Поезд", "Трамвай", "Троллейбус", "Метро" };
            string[] strings = ds.Calculate(len);
            Console.WriteLine(strings);
            Console.ReadKey();
        }
    }
}