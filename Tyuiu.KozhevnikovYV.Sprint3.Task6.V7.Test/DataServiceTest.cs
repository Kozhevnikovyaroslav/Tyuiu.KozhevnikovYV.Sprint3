namespace Tyuiu.KozhevnikovYV.Sprint3.Task6.V7.Test
{
    using Tyuiu.KozhevnikovYV.Sprint3.Task6.V7.Lib;
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 17;
            int stopValue = 26;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 344;
            Assert.AreEqual(wait, res);
        }
    }
}
