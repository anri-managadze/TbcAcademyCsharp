namespace Task2
{
    class Triangle
    {
        private double _side1;
        private double _side2;
        private double _side3;
        public double Side1 { get; set; } 
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 + side2 < side3 && side1 + side3 < side2 && side2 + side3 < side1)
                throw new ArgumentException("Invalid triangle sides.");
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public double CalculatePerimeter()
        {
            double perimeter = _side1 + _side2 + _side3;
            return perimeter;
        }
        public double CalculateArea()
        {
            double semiperimeter = CalculatePerimeter() / 2;
            double area = Math.Sqrt(semiperimeter * (semiperimeter - _side1) * (semiperimeter - _side2) * (semiperimeter - _side3));
            return area;
        }
        public static bool operator ==(Triangle a, Triangle b)
        {
            if( a._side1 == b._side1 && a._side2 == b._side2 && a._side3 == b._side3)
            {
                return true;
            } else {
                return false;
            }            
        }

        public static bool operator !=(Triangle a, Triangle b)
        {   
            if (a._side1 != b._side1 || a._side2 != b._side2 || a._side3 != b._side3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(Triangle a, Triangle b)
        {
            return a.CalculateArea() < b.CalculateArea();
        }

        public static bool operator >(Triangle a, Triangle b)
        {
            return a.CalculateArea() > b.CalculateArea();
        }

        public static explicit operator Triangle(double side)
        {
            Triangle equilateralTriangle = new Triangle(side, side, side);
            return equilateralTriangle;
        }

    }
}
