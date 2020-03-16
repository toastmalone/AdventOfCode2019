using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2019
{
    public class AdventOfCodeSolution2019
    {
        #region Day 1
        public int Day1Solution(string input)
        {
            var inputs = input.Split('\n');
           
            int totalFuelMass = 0;
            foreach (string moduleMass in inputs)
            {
                if (moduleMass != string.Empty) GetFuelMass(Convert.ToInt32(moduleMass), ref totalFuelMass);
            }
            return totalFuelMass;
        }

        private void GetFuelMass(int mass, ref int fuelCounter)
        {
            int neededFuel = (int)(Math.Floor((double)mass / 3) - 2);
            if (neededFuel <= 0) return;
            fuelCounter += neededFuel;
            GetFuelMass(neededFuel, ref fuelCounter);
        }
        #endregion
    }
}
