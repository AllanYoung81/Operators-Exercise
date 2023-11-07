namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
           var a = 17;
           var b = 4;
            var sum = a + b;
            var difference = a - b;
            var product = a * b;
            var quotient = a / b;
           var remainder = a % b;

            Console.WriteLine(a + " + " + b + " is " + sum );
            Console.WriteLine(a + " - " + b + " is " + difference );
            Console.WriteLine(a + " * " + b + " is "  + product );
            //String Concatonation
            Console.WriteLine(a + " / " + b + " is " + quotient + " remainder " + remainder);
            //String Interpolation
            //Console.WriteLine($"{a} / {b} is  {quotient} remainder  {remainder}");
            Console.WriteLine("Please enter the radius of your circle:");
            
            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

           Console.WriteLine(AreaOfCircle(radius));

        }


        public static double AreaOfCircle(double radius)

        {
            var area = Math.PI * Math.Pow(radius, 2);

            return area;

        
        }



    }
}
