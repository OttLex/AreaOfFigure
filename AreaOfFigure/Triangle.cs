namespace FigureArea
{
    public class Triangle : IFigure
    {
        private readonly double _firstSide;
        private readonly double _secondSide;
        private readonly double _thirdSide;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }

        public double GetArea()
        {
            if (IsValid())
            {
                var value = (_firstSide + _secondSide + _thirdSide) / 2;
                return Math.Sqrt(value * (value - _firstSide) * (value - _secondSide) * (value - _thirdSide));
            }
            return 0;
        }

        public bool IsValid()
        {
            if (_firstSide <= 0 && _secondSide <= 0 && _thirdSide <= 0)
                return false;
            if (_firstSide + _secondSide > _thirdSide && _firstSide + _thirdSide > _secondSide && _secondSide + _thirdSide > _firstSide)
                return true;
            return false;
        }

        public bool IsRectangular()
        {
            if (_firstSide * _firstSide == _secondSide * _secondSide + _thirdSide * _thirdSide || _secondSide * _secondSide == _firstSide * _firstSide + _thirdSide * _thirdSide || _thirdSide * _thirdSide == _firstSide * _firstSide + _secondSide * _secondSide)
                return true;
            return false;
        }
    }
}
