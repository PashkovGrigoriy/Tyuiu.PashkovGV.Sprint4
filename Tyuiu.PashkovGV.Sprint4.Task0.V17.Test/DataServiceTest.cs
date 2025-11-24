using Tyuiu.PashkovGV.Sprint4.Task0.V17.Lib;

namespace Tyuiu.PashkovGV.Sprint4.Task0.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] m = { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };
            int m2 = 34;
            var res = ds.GetSumEvenArrEl(m);
            Assert.AreEqual(m2, res);
        }
    }
}
