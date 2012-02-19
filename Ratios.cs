using System.Collections;
using System.Collections.Generic;

namespace convert
{
    public class Ratios
    {
        // Main Dictionary to be accessed
        Dictionary<string, Dictionary<string, double>> Values = new Dictionary<string, Dictionary<string, double>>(); 
        public Ratios()
        {
            // Lenght
            Dictionary<string, double> Kilometers = new Dictionary<string, double>();
            Dictionary<string, double> Meters = new Dictionary<string, double>();
            Dictionary<string, double> Centimeters = new Dictionary<string, double>();
            Dictionary<string, double> Milimeters = new Dictionary<string, double>();

            // Volume
            Dictionary<string, double> Liters = new Dictionary<string, double>();
            Dictionary<string, double> Mililiters = new Dictionary<string, double>();

            // Mass/Weight
            Dictionary<string, double> Kilogram = new Dictionary<string, double>();
            Dictionary<string, double> Grams = new Dictionary<string, double>();
            Dictionary<string, double> Miligrams = new Dictionary<string, double>();

            Kilometers.Add("Miles", 0.62);
            Kilometers.Add("Feet", 3280.8);
            Meters.Add("Feet", 3.28);
            Centimeters.Add("Inches", 0.39);
            Milimeters.Add("Inches", 0.039);

            // Adding Specific Hashtables to the General one
            Values.Add("Kilometers", Kilometers);
            Values.Add("Meters", Meters);
            Values.Add("Centimeters", Centimeters);
            Values.Add("Milimeters", Milimeters);
        }

        public double GetRatio(string From, string To)
        {
            return Values[From][To];
        }
    }
}
