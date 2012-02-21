using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitConverter
{
    class Tests
    {
        Ratios Ratios = new Ratios();
        Convert Convert = new Convert();

        double Tolerance = 0.000001;
        public void test1()
        {
            if (Ratios.GetRatio("Meters", "Feet") == 3.28)
                Console.Write("Test 1: SUCCESS!\n");
            else
                Console.Write("Test 1: FAILURE!\n");
        }

        public void test2()
        {
            if (Ratios.GetRatio("Milimeters", "Inches") == 0.039)
                Console.Write("Test 2: SUCCESS!\n");
            else
                Console.Write("Test 2: FAILURE!\n");
        }
        public void test3()
        {
            if (Convert.MetricToImperial("Kilometers", "Miles", 1) - 0.62 <= Tolerance)
                Console.Write("Test 3: SUCCESS!\n");
            else
                Console.Write("Test 3: FAILURE!\n");
        }

        public void test4()
        {
            if (Convert.MetricToImperial("Kilometers", "Feet", 6) - 19684.8 <= Tolerance)
                Console.Write("Test 4: SUCCESS!\n");
            else
                Console.Write("Test 4: FAILURE!\n");
        }

        public void test5()
        {
            // Back and Forth testing
            if (Convert.MetricToImperial("Kilometers", "Feet", Convert.ImperialToMetric("Feet", "Kilometers", 1337)) == 1337)
                Console.Write("Test 5: SUCCESS!\n");
            else
                Console.Write("Test 5: FAILURE!\n");
        }
    }
}
