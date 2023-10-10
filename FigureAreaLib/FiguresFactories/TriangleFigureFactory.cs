using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureAreaLib.Figures;

namespace FigureAreaLib.FiguresFactories
{
    public class TriangleFigureFactory : BaseFigureFactory
    {
        public override BaseFigure CreateFigure(List<double> par)
        {
            return new Triangle(par);
        }
    }
}
