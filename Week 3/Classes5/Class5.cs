using System;

namespace Classes5
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Class1
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
            AnotherCar car1 = new AnotherCar("Vauxhall");// contructor method with one argument passed
            car1.Colour = "Blue";
            car1.Type = "Astra";
            car1.Cost = 20000;

            AnotherCar car2 = new AnotherCar("Vauxhall");// contructor method with one argument passed
            car2.Colour = "Blue";
            car2.Type = "Astra";
            car2.Cost = 20000;

            AnotherCar car3 = new AnotherCar("Vauxhall");// contructor method with one argument passed
            car3.Colour = "Blue";
            car3.Type = "Astra";
            car3.Cost = 20000;

            Console.WriteLine(AnotherCar.display(car3));

            Console.ReadKey();

			// Put code here to create 3 car instances

			// Add a method named 'Display'to the AnotherCar Class
			// This method should output the details of a  car instance
			// to the Console

			// Put code here to call that method to display the 
			// details of a each car instance 
		}
	}
}
