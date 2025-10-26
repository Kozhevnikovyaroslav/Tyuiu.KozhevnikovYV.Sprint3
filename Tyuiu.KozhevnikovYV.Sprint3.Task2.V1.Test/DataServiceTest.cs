namespace Tyuiu.KozhevnikovYV.Sprint3.Task2.V1.Test
{ using Tyuiu.KozhevnikovYV.Sprint3.Task2.V1.Lib;
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 10;
            double res = ds.GetSumSeries(startValue, stopValue);
            double wait = 0.353;
            Assert.AreEqual(wait, res);
        }
    }
}
