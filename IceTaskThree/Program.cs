namespace IceTaskThree
{
    internal class Program
    {
        public interface ICalculateArea
        {
            double CalculateArea();
        }

        static void Main(string[] args)
        {
            /*
             * create a shape Area calculator program that contains the following:
             * an interface which contains on method to calculate the are:
             * ICalculateArea
             * 
             * A abtract shape class containing a virtual diaplay method 
             * - conatains one property for name 
             * - constructor
             * - Virtual display method
             * 
             * A rectangle class that extends shape and implents inteface
             * - two properties
             * - constructor 
             * - calculate area method
             * 
             * A circle class that extends shape and implements interface
             */
           
                Rectangle rect = new Rectangle("Rectangle", 5, 10);
                rect.Display();

                Console.WriteLine();

                Circle circle = new Circle("Circle", 7);
                circle.Display();
            Console.WriteLine();
            }
        }

    }

