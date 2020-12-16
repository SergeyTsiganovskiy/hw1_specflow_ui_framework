using NUnit.Framework;
using System.Collections.Generic;
using System.IO;

namespace nunit_example
{
    [TestFixture]
    class DDT_2
    {
        [Test, TestCaseSource("GetTestData")]
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

        private static IEnumerable<string[]> GetTestData()
        {
            string[] clients = File.ReadAllLines("test-data.csv");

            foreach (var client in clients)
            {
                string[] client_data = client.Split(",");
                string name = client_data[0];
                string expecteSalary = client_data[1];
                yield return new string[] { name, expecteSalary };
            }
        }
    }
}
