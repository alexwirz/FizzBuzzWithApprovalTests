using ApprovalTests.Reporters;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    [UseReporter(typeof(DiffReporter))]
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void TestAllFizzBuzzCombinations()
        {
            var numbers = Enumerable.Range(1, 99).Select(number => number.ToString());
            ApprovalTests.Combinations.CombinationApprovals.VerifyAllCombinations(FizzBuzz, numbers);
        }

        private string FizzBuzz(string number)
        {
            return number;
        }
    }
}
