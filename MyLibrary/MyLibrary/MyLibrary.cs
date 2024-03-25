namespace Proj
{
    public static class MyLibrary
    {
        public static double Add(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
        public static double Substract(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
        public static double Multiply(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }
        public static double Divide(double firstValue, double secondValue)
        {
            if (firstValue == 0)
            {
                return 0;
            }
            return firstValue / secondValue;
        }
    }
}
