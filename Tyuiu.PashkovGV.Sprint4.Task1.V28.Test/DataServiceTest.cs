using Tyuiu.PashkovGV.Sprint4.Task1.V28.Lib;
namespace Tyuiu.PashkovGV.Sprint4.Task1.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] m = { 2, 4, 4, 5, 3, 4, 4, 6, 2, 4, 5, 5, 4, 4 };
            int m2 = 375;
            var res = ds.Calculate(m);
            Assert.AreEqual(m2, res);
        }
    }
}
