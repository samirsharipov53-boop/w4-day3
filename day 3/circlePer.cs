 static double CalcCirclePerimeter(double radius)
        {
            if (radius < 0)
            {
                Console.WriteLine("Хатогӣ: Радиус наметавонад манфӣ бошад.");
                return double.NaN;
            }
            return 2 * Math.PI * radius;
        }
