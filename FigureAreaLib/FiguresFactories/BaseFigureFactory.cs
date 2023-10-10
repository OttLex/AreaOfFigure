using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureAreaLib.Figures;

namespace FigureAreaLib.FiguresFactories
{
    public abstract class BaseFigureFactory
    {
        public abstract BaseFigure CreateFigure(List<double> paramsForFigure);
    }
}
