  public static class MyMath
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Хатогӣ: Тақсим ба сифр мумкин нест!");
                return double.NaN;
            }
            return a / b;
        }
    }