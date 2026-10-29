static double CalcRectangleArea(double length, double width)
        {
            if (length < 0 || width < 0)
            {
                Console.WriteLine("Хатогӣ: Тарафҳои росткунҷа наметавонанд манфӣ бошанд.");
                return double.NaN;
            }
            return length * width;
        }