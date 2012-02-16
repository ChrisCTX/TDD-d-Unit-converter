using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace convert
{
    public class Ratios
    {
        Hashtable Values = new Hashtable(); // Main Hashtable to be accessed
        public Ratios()
        {
            // Lenght
            Hashtable Kilometers = new Hashtable();
            Hashtable Meters = new Hashtable();
            Hashtable Centimeters = new Hashtable();
            Hashtable Milimeters = new Hashtable();

            // Volume
            Hashtable Liters = new Hashtable();
            Hashtable Mililiters = new Hashtable();

            // Mass/Weight
            Hashtable Kilogram = new Hashtable();
            Hashtable Grams = new Hashtable();
            Hashtable Miligrams = new Hashtable();

            Kilometers.Add("Miles", 0.62);
            Kilometers.Add("Feet", 3280.8);
            Meters.Add("Feet", 3.28);
            Centimeters.Add("Inches", 0.39);
            Milimeters.Add("Inches", 0.039);

            Values.Add("Kilometers", Kilometers);
            Values.Add("Meters", Meters);
            Values.Add("Centimeters", Centimeters);
            Values.Add("Milimeters", Milimeters);
        }

        public double GetRatio(string from, string to)
        {
            Hashtable FromTable = Values[from] as Hashtable;
            double Ratio = (double)FromTable[to];
            return Ratio;
        }
    }
}
