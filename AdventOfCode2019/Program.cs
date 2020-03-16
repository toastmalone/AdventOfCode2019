using System;
using System.IO;
using System.Threading.Tasks;

namespace AdventOfCode2019
{
    class Program
    {
        private static AdventOfCodeSolution2019 _codeSolution2019 = new AdventOfCodeSolution2019();
        static string day1Input = File.ReadAllText(@"C:\Users\Josh\Source\Repos\AdventOfCode2019\AdventOfCodeTests\Inputs\day1.txt");
        static void Main(string[] args)
        {
            var input = File.ReadAllText(@"C:\Users\Josh\Source\Repos\AdventOfCode2019\AdventOfCodeTests\Inputs\day1.txt");
            _codeSolution2019.Day1Solution(day1Input);
        }

    }
}
