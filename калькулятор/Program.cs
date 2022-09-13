namespace калькулятор
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstvalue, secondvalue;
            string action;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter first number");
                firstvalue = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number");
                secondvalue = double.Parse(Console.ReadLine());

                Console.WriteLine("Choose action: '+' '-' '*' '/' '%'");
                action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        
                        Console.WriteLine(firstvalue + secondvalue);

                        break;

                    case "-":
                        Console.WriteLine(firstvalue - secondvalue);
                        break;

                    case "*":
                        Console.WriteLine(firstvalue * secondvalue);
                        break;

                    case "/":
                        if (secondvalue == 0)
                        {
                            Console.WriteLine("Error! Cannot divide by 0 ");
                        }
                        else
                            Console.WriteLine(firstvalue / secondvalue);
                        break;
                    case "%":
                        Console.WriteLine(firstvalue % secondvalue);                        
                        break;

                    default:
                        Console.WriteLine("Unknown action");                       
                        break;
                }

                Console.ReadLine();
            }   

        }
    }
}