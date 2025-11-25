using Tyuiu.PashkovGV.Sprint4.Task7.V21.Lib;
namespace Tyuiu.PashkovGV.Sprint4.Task7.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds  = new DataService();
            int n = 4;
            int m = 3;
            string str = "425963128528";
            var res = ds.Calculate(n,m,str);
            int f = 32;
            Assert.AreEqual(f,res);

        }
    }
}
