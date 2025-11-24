using Tyuiu.PashkovGV.Sprint4.Task3.V14.Lib;
namespace Tyuiu.PashkovGV.Sprint4.Task3.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[,] 
            { 
                { 3, 2, 3, 3, 5, }, 
                { 2, 3, 3, 7, 3, }, 
                { 7, 5, 2, 7, 3, }, 
                { 4, 2, 7, 5, 2, }, 
                { 3, 5, 4, 2, 6, } 
            };
            int res = ds.Calculate(mas2);
            Assert.AreEqual(7, res);
        }
    }
}
