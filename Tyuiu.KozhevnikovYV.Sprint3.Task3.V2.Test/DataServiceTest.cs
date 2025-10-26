namespace Tyuiu.KozhevnikovYV.Sprint3.Task3.V2.Test
{ using Tyuiu.KozhevnikovYV.Sprint3.Task3.V2.Lib;
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "asdzzz vfvfzz v gthvz";
            char chr = 'z';
            int res = ds.GetMaxCharCount(str, chr);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
