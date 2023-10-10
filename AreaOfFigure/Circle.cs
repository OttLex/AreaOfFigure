namespace FigureArea
{
    public class Circle : IFigure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double GetArea()
        {
            if (IsValid())
                return Math.PI * _radius * _radius;
            return 0;
        }

        public bool IsValid()
        {
            return _radius > 0;
        }
    }
}
