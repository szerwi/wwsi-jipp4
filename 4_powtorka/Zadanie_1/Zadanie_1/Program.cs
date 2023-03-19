using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zdanie_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type your name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Hello " + name + '\n');

            int result = 5 + 9;

            int number = 10;
            float money = 5.5f;
            string text = "test";
            bool isLogged = false;
            char myChar = 'c';
            decimal price = (decimal)5.554;

            Console.WriteLine("number " + number);
            Console.WriteLine("money " + money);
            Console.WriteLine("text " + text);
            Console.WriteLine("isLogged " + isLogged);
            Console.WriteLine("myChar " + myChar);
            Console.WriteLine("price " + price);

            string myAge = "Age: ";
            int wifeAge = 18;
            string result2 = myAge + wifeAge;
            Console.WriteLine(result2);

            bool isTrue = true;
            bool isFalse = false;
            bool isReallyTrue = true;
            bool and = isTrue && isFalse;
            bool or = isTrue || isReallyTrue;
            bool negative = !isFalse;

            Console.WriteLine("\nand " + and);
            Console.WriteLine("or " + or);
            Console.WriteLine("negative " + negative);

            int a = 5, b = 12;
            int add = a + b;
            int sub = a - b;
            float div = a / (float)b;
            int mul = a * b;
            int mod = a % b;
            Console.WriteLine("\nadd " + add);
            Console.WriteLine("sub " + sub);
            Console.WriteLine("div " + div);
            Console.WriteLine("mul " + mul);
            Console.WriteLine("mod " + mod);

            string a3 = "Ala ", b3 = "ma ", c3 = "kota.";
            string result3 = a3 + b3 + c3;
            Console.WriteLine("\nresult3 " + result3);

            int n1 = 10, n2 = 20;
            if(n1 == n2)
            {
                Console.WriteLine("n1 and n2 are even");
            }
            else if(n1 > n2)
            {
                Console.WriteLine("n1 is bigger");
            }
            else
            {
                Console.WriteLine("n2 is bigger\n");
            }

            int n = 10;
            for(int i = 0; i <= n; i++)
            {
                Console.Write(i + " - ");
                if(i % 2 == 0)
                {
                    Console.WriteLine("even");
                }
                else
                {
                    Console.WriteLine("odd");
                }
            }

            Console.WriteLine();
            int n3 = 5;
            for(int i = 0; i <= n3; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.Write('\n');
            }

            Console.WriteLine();
            int exam = 57;
            if(exam <= 39)
            {
                Console.WriteLine("Ocena niedostateczna");
            }
            else if(exam <= 54)
            {
                Console.WriteLine("Ocena Dopuszczająca");
            }
            else if (exam <= 69)
            {
                Console.WriteLine("Ocena Dostateczna");
            }
            else if (exam <= 84)
            {
                Console.WriteLine("Ocena Dobra");
            }
            else if (exam <= 98)
            {
                Console.WriteLine("Ocena Bardzo Dobra");
            }
            else if (exam <= 100)
            {
                Console.WriteLine("Ocena Celująca");
            }
            else
            {
                Console.WriteLine("Wartość poza zakresem");
            }

            List<string> colors = new List<string>(){ "red", "blue", "yellow", "black" };
            Console.WriteLine("\nFirst color: " + colors.First());
            Console.WriteLine("Last color: " + colors.Last());

            List<int> numbers = new List<int>() { -10, -5, -3, -2, 0, 5, 10, 15, 255, 12 };
            Console.WriteLine("\nFor:");
            for(int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine("Number: " + numbers[i]);
            }

            Console.WriteLine("\nWhile:");
            int iterator = 0;
            while(iterator < numbers.Count)
            {
                Console.WriteLine("Number: " + numbers[iterator]);
                iterator++;
            }

            Console.WriteLine("\nForeach:");
            foreach (int num in numbers)
            {
                Console.WriteLine("Number: " + num);
                iterator++;
            }

            List<string> fruits = new List<string>() { "apple", "banana", "coconut", "orange" };

            Console.Write("\nFruits: ");
            for(int i = 0; i < fruits.Count;  i++)
            {
                Console.Write(fruits[i] + ", ");
            }
            fruits.Remove("apple");
            fruits.RemoveAt(2);

            Console.Write("\nFruits after removal: ");
            for (int i = 0; i < fruits.Count; i++)
            {
                Console.Write(fruits[i] + ", ");
            }

            Console.ReadKey();
        }
    }
}
