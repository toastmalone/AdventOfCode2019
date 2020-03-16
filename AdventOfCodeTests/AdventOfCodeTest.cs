using AdventOfCode2019;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeTests
{
    [TestClass]
    public class AdventOfCodeTest
    {
        private AdventOfCodeSolution2019 _solution2019;

        [TestInitialize]
        public void TestInit()
        {
            _solution2019 = new AdventOfCodeSolution2019();
        }

        [TestMethod]
        public void Day1Solution_GivenInput_ReturnCorrectOutPut()
        { 
            var input = File.ReadAllText(@"C:\Users\Josh\Source\Repos\AdventOfCode2019\AdventOfCodeTests\Inputs\day1.txt");
            Assert.AreEqual( _solution2019.Day1Solution(input), 5175499);
        }

        [TestMethod]
        public void Day2Solution_GivenInput_ReturnCorrectOutPut()
        {
            var input = File.ReadAllText(@"C:\Users\Josh\Source\Repos\AdventOfCode2019\AdventOfCodeTests\Inputs\day2.txt");
        }
    }
}
