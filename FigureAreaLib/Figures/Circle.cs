namespace FigureAreaLib.Figures
{
    public class Circle : BaseFigure
    {

        public Circle(List<double> edges) : base(edges)
        {
            if (IsValid(edges))
                _edges = edges;
        }

        public override double GetArea()
        {
            return Math.PI * _edges[0] * _edges[0];
        }

        public override bool IsValid(in List<double> edges)
        {
            if (edges.Count != 1)
                throw new ArgumentException("Для создания круга нужна одна сторона!");       
            else if (edges[0] <= 0)
                throw new ArgumentException("Параметр радиуса должен быть больше нуля!");
            return true;
        }
    }
}
