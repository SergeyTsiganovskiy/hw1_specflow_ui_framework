using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace nunit_example
{
    [TestFixture]
    class DDT_3
    {
        [TestCaseSource(typeof(MyDataClass), nameof(MyDataClass.TestCases))]
        public string TestMethod(string name)
        {
            return MethodUnderTest(name);

        }

        private string MethodUnderTest(string name)
        {
            if (name == "aaa") return "10";
            if (name == "bbb") return "20";
            if (name == "ccc") return "30";

            return "0";
        }
    }

    public class MyDataClass
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData("aaa").Returns("10");
                yield return new TestCaseData("bbb").Returns("20");
                yield return new TestCaseData("ccc").Returns("30");
            }
        }
    }
}
