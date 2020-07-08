using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isnumber = false;
            while (isnumber == false)

            {
                Console.WriteLine("Enter the first number:  ");

                string a = Console.ReadLine();
                Console.WriteLine("Enter the second number:  ");
                string b = Console.ReadLine();
                double num1, num2;
                Console.WriteLine("Enter the operation: ");
                if (double.TryParse(a, out num1) & double.TryParse(b, out num2))
                {

                    isnumber = true;
                    switch (Console.ReadLine())
                    {
                        case "+":
                            Console.WriteLine(num1 + "+" + num2 + "=" + (num1 + num2));
                            break;
                        case "-":
                            Console.WriteLine(num1 + "-" + num2 + "=" + (num1 - num2));
                            break;
                        case "*":
                            Console.WriteLine(num1 + "*" + num2 + "=" + (num1 * num2));
                            break;
                        case "/":
                            if (num2 != 0)
                            {
                                Console.WriteLine(num1 + "/" + num2 + "=" + (num1 / num2));

                            }
                            else
                            {
                                Console.WriteLine("You can't devide a number into 0");
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("You entered not a number, try again");
                }
                        
            }

        }
    }
}
