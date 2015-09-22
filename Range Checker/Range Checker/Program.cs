using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range_Checker {
    class Program {
        static int ValidateValue(String number) {
            int output;

            if (Int32.TryParse(number, out output)) {
                //Success
            } else {
                Console.Write("Please enter a valid value: ");
            }
            return output;
        }
        static void Main(string[] args) {
            String numberEntered = "";
            int numberEnteredInt = 0;

            Console.Write("Enter a value between 1 and 10,000: ");

            while (numberEnteredInt < 1 || numberEnteredInt > 10000) {
                numberEntered = Console.ReadLine();
                numberEnteredInt = ValidateValue(numberEntered);
            }

            for (int x = 2; x < numberEnteredInt; x++)
            {
                int isPrime = 0;
                for (int y = 1; y < x; y++)
                {
                    if (x % y == 0)
                        isPrime++;

                    if (isPrime == 2) break;
                }
                if (isPrime != 2)
                    Console.WriteLine(x);

                isPrime = 0;
            }
            Console.ReadKey();
        }
    }
}
