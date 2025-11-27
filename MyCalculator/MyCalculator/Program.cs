namespace MyCalculator
{
    internal class Program
    {
        const double PRODUCTIVITY_RATE = 20;
        const double TEAM_COST_PER_HOUR = 86.00;

        static void Main(string[] args)
        {
            Console.WriteLine("Finding the cost of tile flooring");

            double area = 0.0;
            

            Console.WriteLine("Please enter 'r' for rectangle area and 'c' for circle area");
            string result = Console.ReadLine();
            
            if (result == "r")
            {
                Console.WriteLine("Input floor length");
                double floorLength = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Input floor width");
                double floorWidth = Convert.ToDouble(Console.ReadLine());
                area = floorLength * floorWidth;
                Console.WriteLine($"The total rectangular area is {area}");
            }
            else if (result == "c")
            {
                Console.WriteLine("Input the radius of a circle");
                double rad = Convert.ToDouble(Console.ReadLine());
                area = Math.PI * rad * rad;
                Console.WriteLine($"The total circular area is {area}");
            }
            Console.WriteLine("Calculating the material cost");          
            Console.WriteLine("Input cost of one unit");
            double costPerUnit = Convert.ToDouble(Console.ReadLine());
            double materialCost = area * costPerUnit;
            Console.WriteLine($"The material Cost is {materialCost}");

            Console.WriteLine("Calculating labour cost");
            double outputPerHr = area / PRODUCTIVITY_RATE;
            Console.WriteLine($"The team's output per hour for the calculated area is {outputPerHr}");
            double labourCost = outputPerHr * TEAM_COST_PER_HOUR;
            Console.WriteLine($"The team's labour cost for the calculated area is {labourCost}");
        }
    }

}

