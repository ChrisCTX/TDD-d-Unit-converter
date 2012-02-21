using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitConverter
{
    public class Ratios
    {
        // Main Dictionary to be accessed
        public Dictionary<string, Dictionary<string, double>> Values = new Dictionary<string, Dictionary<string, double>>(); 

        public Ratios()
        {
            //Lenght
            Dictionary<string, double> Kilometers = new Dictionary<string, double>();
            Dictionary<string, double> Meters = new Dictionary<string, double>();
            Dictionary<string, double> Centimeters = new Dictionary<string, double>();
            Dictionary<string, double> Milimeters = new Dictionary<string, double>();

            // Volume
            Dictionary<string, double> Liters = new Dictionary<string, double>();
            Dictionary<string, double> Mililiters = new Dictionary<string, double>();

            // Mass/Weight
            Dictionary<string, double> Kilograms = new Dictionary<string, double>();
            Dictionary<string, double> Grams = new Dictionary<string, double>();
            Dictionary<string, double> Miligrams = new Dictionary<string, double>();

            // Adding all dictionaries to the main one
            Values.Add("Kilometers", Kilometers);
            Values.Add("Meters", Meters);
            Values.Add("Centimeters", Centimeters);
            Values.Add("Milimeters", Milimeters);
            Values.Add("Kilograms", Kilograms);
            Values.Add("Grams", Grams);
            Values.Add("Miligrams", Miligrams);
            Values.Add("Liters", Liters);
            Values.Add("Mililiters", Mililiters);

            // Adding values to the sub-dictionaries

            // Lenght values
            Kilometers.Add("Miles", 0.621371192);
            Kilometers.Add("Feets", 3280.8399);
            Kilometers.Add("Inches", 39370.0787);

            Meters.Add("Miles", 0.000621371192);
            Meters.Add("Feets", 3.2808399);
            Meters.Add("Inches", 39.3700787);

            Centimeters.Add("Miles", 0.00000621371192);
            Centimeters.Add("Feets", 0.032808399);
            Centimeters.Add("Inches", 0.393700787);

            Milimeters.Add("Miles", 0.000000621371192);
            Milimeters.Add("Feets", 0.0032808399);
            Milimeters.Add("Inches", 0.0393700787);

            // Mass values
            Kilograms.Add("Ounces", 35.2739619);
            Kilograms.Add("Pounds", 2.20462262);
            Kilograms.Add("Stones", 0.157473044);

            Grams.Add("Ounces", 0.0352739619);
            Grams.Add("Pounds", 0.00220462262);
            Grams.Add("Stones", 0.000157473044);

            Miligrams.Add("Ounces", 0.0000353);
            Miligrams.Add("Pounds", 0.00220462262);
            Miligrams.Add("Stones", 0.000157473044);

            // Volume values
            Liters.Add("Pints", 2.11337642);
            Liters.Add("Quarts", 1.05668821);
            Liters.Add("Gallons", 0.264172052);

            Mililiters.Add("Pints", 0.00211337642);
            Mililiters.Add("Quarts", 0.00105668821);
            Mililiters.Add("Gallons", 0.000264172052);
        }

        public double GetRatio(string From, string To)
        {
            return Values[From][To];
        }
    }
}
