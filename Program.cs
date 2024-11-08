namespace Assignment1_4_1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize two instances of the Point class
            // P1 is the first point with X & Y
            Point p1 = new Point(10, 10);

            // P2 is the second point with X & Y
            Point p2 = new Point(20, 20);

            // Compare the X coordinates of P1 and P2 to determine their positions
            if (p1.x < p2.x)
            {
                Console.WriteLine("P1 is to the left of P2");
            }
            else if (p1.x > p2.x)
            {
                Console.WriteLine("P1 is to the right of P2");
            }
            else
            {
                Console.WriteLine("P1 and P2 are at the same position");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey(intercept: true);
        }
    }

    //Define class Point
    public class Point
    {
        //First construvtor for Point class
        //Takes two params,x/yCoord, and init the x/y fields
        public Point(double xCoord, double yCoord)
        {
            x = xCoord;
            y = yCoord;
        }

        //Second constructor for point class.
        //No params & init x/y fields with default 0
        public Point()
        {
            x = 0;
            y = 0;
        }

        //Public fields
        public double x;
        public double y;
    }

}

