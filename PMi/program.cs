namespace CAPMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example for Metric System
            BMI bmiCalculate = new BMI(72, 1.75, new MetricFormula());
            bmiCalculate.CalcuateBmi();

            // Example for Imperial System
            BMI bmiCalculateImperial = new BMI(154, 69, new ImperialFormula());
            bmiCalculateImperial.CalcuateBmi();
        }
    }
}
