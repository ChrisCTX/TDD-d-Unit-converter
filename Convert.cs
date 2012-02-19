
namespace convert
{
    class Convert
    {
        Ratios Ratios = new Ratios();

        public double MetricToImperial(string From, string To, double Value) 
        {
            double Ratio = Ratios.GetRatio(From, To);
            return Value * Ratio;
        }

        public double ImperialToMetric(string From, string To, double Value)
        {
            // Little Switcheroo here reduces the need to have specific ratios for Imperial to Metric
            double Ratio = Ratios.GetRatio(To, From);
            return Value / Ratio;
        }
    }
}
