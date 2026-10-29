 public static class GeometryCalculator
    {
        public static double CalcCircleArea(double radius)
        {
            if (radius < 0)
            {
                Console.WriteLine("Хатогӣ: Радиус наметавонад манфӣ бошад.");
                return double.NaN;
            }
            return Math.PI * Math.Pow(radius, 2);
        }

        public static double CalcCirclePerimeter(double radius)
        {
            if (radius < 0)
            {
                Console.WriteLine("Хатогӣ: Радиус наметавонад манфӣ бошад.");
                return double.NaN;
            }
            return 2 * Math.PI * radius;
        }


        public static double CalcRectangleArea(double length, double width)
        {
            if (length < 0 || width < 0)
            {
                Console.WriteLine("Хатогӣ: Тарафҳои росткунҷа наметавонанд манфӣ бошанд.");
                return double.NaN;
            }
            return length * width;
        }

        public static double CalcRectanglePerimeter(double length, double width)
        {
            if (length < 0 || width < 0)
            {
                Console.WriteLine("Хатогӣ: Тарафҳои росткунҷа наметавонанд манфӣ бошанд.");
                return double.NaN;
            }
            return 2 * (length + width);
        }


        public static double CalcTriangleArea(double @base, double height)
        {
            if (@base < 0 || height < 0)
            {
                Console.WriteLine("Хатогӣ: Асос ва баландии секунҷа наметавонанд манфӣ бошанд.");
                return double.NaN;
            }
            return 0.5 * @base * height;
        }

        public static double CalcTrianglePerimeter(double side1, double side2, double side3)
        {
            if (side1 < 0 || side2 < 0 || side3 < 0)
            {
                Console.WriteLine("Хатогӣ: Тарафҳои секунҷа наметавонанд манфӣ бошанд.");
                return double.NaN;
            }
            return side1 + side2 + side3;
        }
    }
