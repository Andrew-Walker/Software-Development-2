using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Area_Calculator {
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

            var lengthList = new List<int>();
            var widthList = new List<int>();
            var nameList = new List<string>();

            int totalCount = 0;

            Console.Write("Hello. Please enter the number of rooms in your house: ");

            int roomCounterInt = 0;
            String roomCounter = "";

            while (roomCounterInt == 0) {
                //Ensures at least one room is entered.
                roomCounter = Console.ReadLine();
                roomCounterInt = ValidateValue(roomCounter);
            }

            for (int i = 1; i < roomCounterInt + 1; i++) {
                // ****************
                // ROOM DESCRIPTION
                // ****************

                String roomDescription = "";
                while (roomDescription.Length < 1) {
                    Console.Write("Enter a name/description for room " + i + ": ");
                    roomDescription = Console.ReadLine();
                }

                // ****************
                // ROOM WIDTH
                // ****************

                Console.Write("Enter the width of room '" + roomDescription + "': ");

                int roomWidthInt = 0;
                String roomWidth = "";

                while (roomWidthInt == 0) {
                    roomWidth = Console.ReadLine();
                    roomWidthInt = ValidateValue(roomWidth);
                }

                // ****************
                // ROOM LENGTH
                // ****************

                Console.Write("Enter the length of room '" + roomDescription + "': ");

                int roomLengthInt = 0;
                String roomLength = "";

                while (roomLengthInt == 0) {
                    roomLength = Console.ReadLine();
                    roomLengthInt = ValidateValue(roomLength);
                }

                nameList.Add(roomDescription);
                widthList.Add(roomWidthInt);
                lengthList.Add(roomLengthInt);
            }

            Console.WriteLine("{0,-20} {1,20}", "Room", "(sq ms)");

            for (int i = 0; i < nameList.Count; i++) {
                //Print individual room totals and calculates overall total.
                Console.WriteLine("{0,-20} {1,20}", nameList[i], widthList[i] * lengthList[i]);

                totalCount += widthList[i] * lengthList[i];
            }

            Console.WriteLine();
            Console.WriteLine("{0,-20} {1,20}", "Total", totalCount);
            Console.WriteLine("Press return to exit");
            Console.ReadLine();
        }
    }
}
