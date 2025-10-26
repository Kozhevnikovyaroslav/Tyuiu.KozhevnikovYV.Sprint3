namespace Tyuiu.KozhevnikovYV.Sprint3.Task4.V26.Test
{
    using Tyuiu.KozhevnikovYV.Sprint3.Task4.V26.Lib;
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = -0.858;
            Assert.AreEqual(wait, res);
        }
    }
}
