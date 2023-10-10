namespace FigureAreaLib.Figures
{
    public class Triangle : BaseFigure
    {
        public Triangle(List<double> edges) : base(edges)
        {
            if (IsValid(edges))
            {
                _edges = edges;             
            }
        }

        public override double GetArea()
        {
            var value = (_edges[0] + _edges[1] + _edges[2]) / 2;
            return Math.Sqrt(value * (value - _edges[0]) * (value - _edges[1]) * (value - _edges[2]));
        }

        public override bool IsValid(in List<double> edges)
        {
            if (edges.Count != 3)
                throw new ArgumentException("Количество сторон должно быть равно трём!");
            if (edges[0] < 0 && edges[1] < 0 && edges[2] < 0)
                throw new ArgumentException("Размер сторон должен быть положительный!");
            if (_edges[0] + _edges[1] > _edges[2] * _edges[2] 
                && _edges[0] + _edges[2] > _edges[1] * _edges[1] 
                && _edges[1] + _edges[2] > _edges[0] * _edges[0])
                throw new ArgumentException("Сумма двух сторон не должна быть больше квадрата третей стороны!");
            return true;
        }

        public bool IsRectangular()
        {
            if (_edges[0] * _edges[0] == _edges[1] * _edges[1] + _edges[2] * _edges[2]
                || _edges[1] * _edges[1] == _edges[0] * _edges[0] + _edges[2] * _edges[2]
                || _edges[2] * _edges[2] == _edges[0] * _edges[0] + _edges[1] * _edges[1])
                return true;
            return false;
        }
    }
}
