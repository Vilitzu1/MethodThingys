namespace MethodThingys
{
    internal class Program
    {
        const double PI = Math.PI;

        static void Main(string[] args)
        {
            //Area of a cirle
            Console.WriteLine("Area of a cirle!");
            Console.Write("Please enter the radius of the cirle: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine(CountArea(x));
            Console.WriteLine(" ");
            // enter numbers to add together
            Console.WriteLine("Adding!");
            Console.Write("Please enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please enter second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Add(a, b));
            Console.WriteLine(" ");
            // enter numbers to multiply together
            Console.WriteLine("Multiplying!");
            Console.Write("Please enter first number: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Please enter second number: ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine(Multiply(c, d));
        }
        static double CountArea(double n)
        {
            return PI * n * n;
        }
        static int Add(int a, int b) 
        { 
            return a + b;
        }
        static int Multiply(int c, int d) 
        {
            return c * d;
        }
    }
}
