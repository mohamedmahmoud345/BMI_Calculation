namespace CAPMI
{
    class BMI
    {
        private double _weight;
        private double _height;
        private Formula _bmiFormula;

        public BMI(double weight, double height , Formula bmiFormula)
        {
            if(weight < 0 || height < 0)
            {
                throw new ArgumentException("The Weight Or Height Cannot Be Negative.");
            }
            _weight = weight;
            _height = height;
            _bmiFormula = bmiFormula;
        }

        public void CalcuateBmi()
        {
            double value = _bmiFormula.Calc(_height, _weight);
            ShowClassification(value);
        }
        private void ShowClassification(double value)
        {
            Console.WriteLine($"Your Bmi: {value:N}");
            if(value < 18.5)
            {
                Console.WriteLine("UnderWeight");
            }
            else if(value >= 18.5 && value <= 24.9)
            {
                Console.WriteLine("Normal Weight");
            }
            else if(value >= 25 && value< 29.9)
            {
                Console.WriteLine("OverWeight");
            }
            else
            {
                Console.WriteLine("Obesity");
            }
        }
    }
}
