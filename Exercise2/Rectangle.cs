namespace Exercise2
{
    public class Rectangle
    {
        // Красота!
        private double side1;
        private double side2;

        public double Area { get; private set; } = default;
        public double Perimeter { get; private set; } = default;


        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalculator()
        {
            Area = side1 * side2;
            return Area;
        }

        public double PerimeterCalculator()
        {
            Perimeter = 2 * side1 + 2 * side2;
            return Perimeter;
        }
    }
}