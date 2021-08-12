using System;

namespace HW3Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Question1
            Console.WriteLine("Enter price of  purchase = ");
            var a = double.Parse(Console.ReadLine());
            if(a > 0 && a < 500){
                Console.WriteLine($"Your price purchase with sale is {a}");
            }
            else if(a <= 1000){
                a = 0.97 * a;
                Console.WriteLine($"Your price purchase with sale is {a}");
            }
            else if(a > 1000){
                a = 0.95 * a;
                Console.WriteLine($"Your price purchase with sale is {a}");
            }
            else{
                Console.WriteLine("The price of your purchase is invalid");
            }
            Question2
            Console.Write("Enter first number = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter third number = ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Enter fourth number = ");
            int d = int.Parse(Console.ReadLine());
            if(a == b && b == c && c == d){
                Console.WriteLine($"They are equal, so their multiplication is {a*b*c*d}");
            }
            else if(a == b || b == c || c == d || a == c || a == d || b == d){
                int min = a;
                if(min > b){
                    min = b;
                }
                if(min > c){
                    min = c;
                }
                if(min > d){
                    min = d;
                }
                Console.WriteLine($"Minimum number is {min}");
            }
            else if(a != b && a!= c && a != d && b != c && b != d && c != d)
            {
                Console.WriteLine("Numbers are in ascending order");
            }
            Question3
            Console.WriteLine("Enter first number = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number = ");
            int c = int.Parse(Console.ReadLine());
            // 3 , 2 , 1
            if(a >= b && b>=c){
                Console.WriteLine($"A is {a}, B is {b}, C is{c}");
            }
            //  4 , 2 , 3
            else if(a >= b && b <= c && a >= c){
                b = b + c;
                c = b - c;
                b = b - c;
                Console.WriteLine($"A is {a}, B is {b}, C is{c}");
            }
            // 5 , 4 , 6
            else if(a >= b && b <= c && a <= c){
                a = a + c;
                c = a - c;
                a = a - c;
                b = b + c;
                c = b - c;
                b = b - c;
                Console.WriteLine($"A is {a}, B is {b}, C is {c}");
            }
            // 5 , 7 , 6 
            else if(a <= b && b >= c && a >= c)
            {
                a = a + b;
                b = a - b;
                a = a - b;
                Console.WriteLine($"A is {a}, B is {b}, C is {c}");
            }
            // 5 , 6 ,7
            else if(a <= b && b >= c && a <= c)
            {
                a = a + b;
                b = a - b;
                a = a - b;
                b = b + c;
                c = b - c;
                b = b - c;
                Console.WriteLine($"A is {a}, B is {b}, C is {c}");
            }
            else if(a <= b && b <= c)
            {
                a = a + c;
                c = a - c;
                a = a -c;
                Console.WriteLine($"A is {a}, B is {b}, C is {c}");
            }
        }
    }
}
