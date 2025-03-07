namespace TesttingSQL
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string info = "alles ok";
            StoredProcedures.SQLTestConnect(ref info);
            Assert.Pass(info);
        }
    }
}