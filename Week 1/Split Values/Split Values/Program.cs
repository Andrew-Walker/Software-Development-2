using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_Values {
    class Program {
        static void Main(string[] args) {
            String valuesEntered = "";
            int totalCount = 0;
            int currentNumber = 0;
            bool valid = false;

            while (valid == false) {
                Console.Write("Enter a set of valid values seperated by a comma: ");
                valuesEntered = Console.ReadLine();

                string[] numbers = valuesEntered.Split(',');

                for (int i = 0; i < numbers.Length + 0; i++) {
                    if (Int32.TryParse(numbers[i], out currentNumber)) {
                        totalCount += currentNumber;
                        valid = true;
                    }
                    else {
                        i = numbers.Length;
                        valid = false;
                    }
                }
            }
            Console.WriteLine(totalCount);
            Console.ReadKey();
        }
    }
}