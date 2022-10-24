using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApp
{
    internal class Program
    {

        static void Main(string[] args)
        {

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }


        private static bool MainMenu()
        {

            List<Shape> Shapes = new List<Shape>();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Show All Figures");
            Console.WriteLine("2) Create a Figure");
            Console.WriteLine("3) Change Figure:");
            Console.WriteLine("4) save to file");
            Console.WriteLine("0) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    ShowALlFigures(Shapes);
                    return true;
                case 2:
                    CreateFigure(Shapes);
                    return true;
                case 3:
                    ChangeFigureMenu(Shapes);
                    return true;
                case 4:
                    return true;
                case 0:
                    return false;
                default:
                    return true;
            }
        }

        private static void ChangeFigureMenu(List<Shape> shapes)
        {
            Console.Clear();
            Console.WriteLine("Change Figure:");
            Console.WriteLine("a) Move Figure:");
            Console.WriteLine("b) Rotate Figure:");
            Console.WriteLine("c) Scale Figure:");
            Console.Write("\r\nSelect an option: ");
        }


        private static void CreateFigure(List<Shape> shapes)
        {
            Console.Clear();
            Console.WriteLine("Create Figure:");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Rectangle");
            Console.WriteLine("2) Circle");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    CreateRectangle(shapes);
                    break;
                case 2:
                    CreateCircle(shapes);
                    break;
                default:
                    break;
            }
        }
        private static void CreateRectangle(List<Shape> shapes)
        {
            Console.Clear();
            Console.WriteLine("Create Rectangle:");
            Console.WriteLine("Input Locations:");
            Console.WriteLine("Input Point X:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input Point Y:");
            double y = Convert.ToDouble(Console.ReadLine());
            Location loc = new Location(x,y);
            Console.WriteLine("Input Heigh:");
            double heigh = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input Width:");
            double width = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(heigh, width, loc);
            shapes.Add(rectangle);
        }
        private static void CreateCircle(List<Shape> shapes)
        {
            Console.Clear();
            Console.WriteLine("Create Circle:");
            Console.WriteLine("Input Locations:");
            Console.WriteLine("Input Point X:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input Point Y:");
            double y = Convert.ToDouble(Console.ReadLine());
            Location loc = new Location(x, y);
            Console.WriteLine("Input Radius:");
            double r = Convert.ToDouble(Console.ReadLine());
            Circle circle = new Circle(r, loc);
            shapes.Add(circle);
        }
        private static void ShowALlFigures(List<Shape> shapes)
        {
            foreach (var item in shapes)
            {
                Console.WriteLine(item);
            }
        }
    }
}

