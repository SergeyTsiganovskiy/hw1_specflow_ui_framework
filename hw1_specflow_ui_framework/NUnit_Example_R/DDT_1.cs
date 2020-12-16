using NUnit.Framework;

namespace nunit_example
{
    [TestFixture]
    class DDT_1
    {
        [TestCase("aaa", "10")]
        [TestCase("bbb", "20")]
        [TestCase("ccc", "30")]
        [Test]
        public void TestMethod(string name, string expecteSalary)
        {
            var methodOutput = MethodUnderTest(name);
            Assert.AreEqual(expecteSalary, methodOutput);
        }

        private string MethodUnderTest(string name)
        {
            if (name == "aaa") return "10";
            if (name == "bbb") return "20";
            if (name == "ccc") return "30";

            return "0";
        }
    }
}
