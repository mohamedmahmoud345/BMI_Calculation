namespace CAPMI
{
    class MetricFormula : Formula
    {
        public double Calc(double height, double weight)
        {
            return weight / (height * height);
        }
    }
}
