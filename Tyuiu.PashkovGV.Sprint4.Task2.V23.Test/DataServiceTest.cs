using Tyuiu.PashkovGV.Sprint4.Task2.V23.Lib;
namespace Tyuiu.PashkovGV.Sprint4.Task2.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] m = { 1,2,3,4,5 };
            int m2 = 9;
            var res = ds.Calculate(m);
            Assert.AreEqual(m2, res);
        }
    }
}
