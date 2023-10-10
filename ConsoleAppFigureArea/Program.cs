using FigureAreaLib;
using FigureAreaLib.FiguresFactories;

namespace ConsoleAppFigureArea
{
    class Program
    {
        static void Main(string[] args)
        {

            BaseFigureFactory factory = new TriangleFigureFactory();
            try
            {
                var figure = factory.CreateFigure(new List<double>() {3,3,3});
                Console.WriteLine(figure.GetArea());
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}