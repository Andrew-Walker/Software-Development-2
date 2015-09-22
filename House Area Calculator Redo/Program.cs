using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Area_Calculator_Redo {
    class Room {
        public String name;
        public int length;
        public int width;
    }
    class Program {
        public static int ValidateValue(String number) {
            int result;

            if (Int32.TryParse(number, out result)) {
                //Success
            } else {
                Console.Write("Please enter a valid value: ");
            }
            return result;
        }

        static void Main(string[] args) {
            Console.Write("Hello. Please enter the number of rooms in your house: ");

            List<Room> roomsList = new List<Room>();
            int roomCounterInt = 0;
            String roomCounter = "";

            while (roomCounterInt <= 0) {
                roomCounter = Console.ReadLine();
                roomCounterInt = ValidateValue(roomCounter);
            }

            for (int i = 1; i < roomCounterInt + 1; i++) {
                Room room = new Room();

                // ================
                // Room Description
                // ================

                String roomDescription = "";
                while (roomDescription.Length < 1) {
                    Console.Write("Enter a name/description for room " + i + ": ");
                    roomDescription = Console.ReadLine();
                }
                room.name = roomDescription;

                Console.Write("Enter the width of " + roomDescription + ": ");

                // ================
                // Room Width
                // ================

                int roomWidthInt = 0;
                String roomWidth = "";

                while (roomWidthInt <= 0) {
                    roomWidth = Console.ReadLine();
                    roomWidthInt = ValidateValue(roomWidth);
                }
                room.width = roomWidthInt;

                Console.Write("Enter the length of " + roomDescription + ": ");

                // ================
                // Room Length
                // ================

                int roomLengthInt = 0;
                String roomLength = "";

                while (roomLengthInt <= 0) {
                    roomLength = Console.ReadLine();
                    roomLengthInt = ValidateValue(roomWidth);
                }
                room.length = roomLengthInt;

                roomsList.Add(room);
            }

            int totalCount = 0;

            Console.WriteLine("{0,-15} {1,15}", "Room", "Size (sq ms)");
            for (int i = 0; i <= roomsList.Count - 1; i++) {
                totalCount += roomsList[i].length * roomsList[i].width;
                Console.WriteLine("{0,-15} {1,15}", roomsList[i].name, roomsList[i].length * roomsList[i].width);
            }
            Console.WriteLine();
            Console.WriteLine("{0,-15} {1,15}", "Total", totalCount);

            Console.Write("Press return to exit");
            Console.ReadLine();
        }
    }
}
