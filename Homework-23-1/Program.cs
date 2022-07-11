namespace Homework_23_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parallelepiped p1 = new Parallelepiped("Parralelepiped", 0, 0, 0);
            try
            {
                Console.WriteLine("Enter length of Parallelepiped");
                p1.lengthOfPar = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter width of Parallelepiped");
                p1.widthOfPar = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter heigth of Parallelepiped");
                p1.heightOfPar = double.Parse(Console.ReadLine());

                if (p1.lengthOfPar < 0 || p1.widthOfPar < 0 || p1.heightOfPar < 0)
                {
                    throw new Exception("Entering negative numbers is not allowed");
                }
               

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                p1.lengthOfPar = 0;
                p1.widthOfPar = 0;
                p1.heightOfPar = 0;

            }
            Console.WriteLine("Volume is: " + p1.name + " = " + p1.GetVolume());
            Console.WriteLine("Total area is:" + p1.name + " = " + p1.GetTotalSurfaceArea());
            Console.WriteLine();

        }
    }

    struct Parallelepiped : IFigure
    {
        public string name;
        public double lengthOfPar;
        public double widthOfPar;
        public double heightOfPar;

        public Parallelepiped(string Name, double LengthOfPar, double WidthOfPar, double HeightOfPar)
        {
            this.name = Name;
            this.lengthOfPar = LengthOfPar;
            this.widthOfPar = WidthOfPar;
            this.heightOfPar = HeightOfPar;
        }

        public double GetVolume()
        {
            return this.widthOfPar * this.heightOfPar * this.lengthOfPar;
        }
        public double GetTotalSurfaceArea()
        {
            return 2 * ((this.lengthOfPar * this.widthOfPar) + (this.lengthOfPar * this.heightOfPar) + (this.widthOfPar * this.heightOfPar));
        }

    }
    struct Pyramid : IFigure
    {
        public string name;
        public double lengthOfPir;
        public double widthOfPar;
        public double heightOfPir;

        public Pyramid(string Name, double LengthOfPir, double HeightOfPir, double WidthOfPar)
        {
            this.name = Name;
            this.lengthOfPir = LengthOfPir;
            this.widthOfPar = WidthOfPar;
            this.heightOfPir = HeightOfPir;
        }

        public double GetVolume()
        {
            double BaseAreaOfPyramid = (Math.Pow(this.lengthOfPir, 2) * 0.33) / 4;
            return 0.33 * BaseAreaOfPyramid * this.heightOfPir;
        }
        public double GetTotalSurfaceArea()
        {
            double BaseAreaOfPyramid = (Math.Pow(this.lengthOfPir, 2) * 0.33) / 4;
            double LateralAreaOfPyramid = 0.50 * (this.lengthOfPir + this.widthOfPar) * this.heightOfPir;
            return BaseAreaOfPyramid + LateralAreaOfPyramid;
        }
    }
    struct Sphere : IFigure
    {
        public string name;
        public double radiusOfSphere;
        public Sphere(string Name, double RadiusOfSphere)
        {
            this.name = Name;
            this.radiusOfSphere = RadiusOfSphere;
        }
        public double GetVolume()
        {
            return 1.33 * Math.PI * Math.Pow(this.radiusOfSphere, 3);
        }
        public double GetTotalSurfaceArea()
        {
            return 4 * Math.PI * Math.Pow(this.radiusOfSphere, 2);

        }

    }
    struct Cylinder : IFigure
    {
        public string name;
        public double radiusOfCylinder;
        public double heightOfCylinder;

        public Cylinder(string Name, double radiusOfCylinder, double HeightOfCylinder)
        {
            this.name = Name;
            this.radiusOfCylinder = radiusOfCylinder;
            this.heightOfCylinder = HeightOfCylinder;
        }
        public double GetVolume()
        {
            return this.heightOfCylinder * Math.PI * Math.Pow(this.radiusOfCylinder, 2);
        }
        public double GetTotalSurfaceArea()
        {
            return 2 * Math.PI * this.radiusOfCylinder * this.heightOfCylinder;
        }
    }

    struct Cone : IFigure
    {
        public string name;
        public double radiusOfCone;
        public double heightOfCone;

        public Cone(string Name, double RadiusOfCone, double HeightOfCone)
        {
            this.name = Name;
            this.radiusOfCone = RadiusOfCone;
            this.heightOfCone = HeightOfCone;
        }
        public double GetVolume()
        {
            return (this.heightOfCone * Math.PI * Math.Pow(this.radiusOfCone, 2)) / 3;
        }
        public double GetTotalSurfaceArea()
        {
            double LengthOfcone = Math.Sqrt(Math.Pow(this.radiusOfCone, 2) + Math.Pow(this.heightOfCone, 2));
            return Math.PI * this.radiusOfCone * LengthOfcone;
        }


    }

    public interface IFigure
    {
        double GetVolume();
        double GetTotalSurfaceArea();
    }

}