namespace Tyuiu.KozhevnikovYV.Sprint3.Task7.V8.Test
{
    using Tyuiu.KozhevnikovYV.Sprint3.Task7.V8.Lib;
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -1;
            int stopValue = 2;
            double[] res = ds.GetMassFunction(startValue, stopValue);
            double[] wait = new double[stopValue - startValue + 1];
            wait[0] = -2.33;
            wait[1] = 1;
            wait[2] = 4.38;
            wait[3] = 0;
            CollectionAssert.AreEqual(wait, res);

        }
    }
}
