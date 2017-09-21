namespace MythicalNumbers
{
    using System;

    public  class ThirdDigitCalculation
    {
        private double result;

        public ThirdDigitCalculation(double number)
        {
            this.Result = number;
        }

        public double Result
        {
            get { return this.result; }
            set
            {
                if (value.ToString().Length < 3)
                {
                    throw new ArgumentException("Number must contains 3 digits!");
                }

                this.result = CalculateByThirdDigit(value);
            }
        }

        private double CalculateByThirdDigit(double number)
        {
            double fistDigit = GetDigit(number, 1);
            double secondDigit = GetDigit(number, 2);
            double thirdDigit = GetDigit(number, 3);
            
            if (thirdDigit == 0)
            {
                return fistDigit * secondDigit;
            }
            else if (0 <= thirdDigit && thirdDigit <= 5)
            {
                return (fistDigit * secondDigit) / thirdDigit;
            }
            else if (thirdDigit > 5)
            {
                return (fistDigit * secondDigit) * thirdDigit;
            }
            else
            {
                return 0;
            }
        }

        private double GetDigit(double number, int digit)
        {
            string convertedToString = number.ToString();
            double result = double.Parse(convertedToString[digit - 1].ToString());

            return result;
        }
    }
}
