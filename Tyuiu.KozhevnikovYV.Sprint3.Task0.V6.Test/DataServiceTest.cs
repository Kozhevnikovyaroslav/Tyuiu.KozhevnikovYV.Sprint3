namespace Tyuiu.KozhevnikovYV.Sprint3.Task0.V6.Test
{
    using Tyuiu.KozhevnikovYV.Sprint3.Task0.V6.Lib;
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 15;
            double res = ds.GetMultiplySeries(startValue, stopValue);
            double wait = 0.0005577987874650453;
            Assert.AreEqual(wait, res);
        }
    }
}
