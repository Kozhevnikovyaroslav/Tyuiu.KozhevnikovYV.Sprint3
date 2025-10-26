namespace Tyuiu.KozhevnikovYV.Sprint3.Task1.V7.Test
{
    using Tyuiu.KozhevnikovYV.Sprint3.Task1.V7.Lib;
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double Value = 0.25;
            int startValue = 1;
            int stopValue = 9;
            double wait = -0.93;
            double res = ds.GetMultiplySeries(Value, startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}
