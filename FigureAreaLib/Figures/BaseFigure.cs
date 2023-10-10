using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaLib.Figures
{
    public abstract class BaseFigure
    {        
        private protected List<double> _edges = new List<double>();
        public List<double> Edges { get => _edges; }

        public BaseFigure(List<double> edges)
        {
            _edges = edges;
        }

        public abstract bool IsValid(in List<double> edges);
        public abstract double GetArea();
    }
}
