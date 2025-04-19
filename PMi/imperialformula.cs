namespace CAPMI
{
    class ImperialFormula : Formula
    {
        public double Calc(double height, double weight)
        {
            return (weight * 703) / (height * height);
        }
    }
}
