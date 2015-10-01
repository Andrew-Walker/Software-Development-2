using System;

namespace Classes2
{
	//In general it is considered good practice for 
	//Class data members (e.g. variables) to be declared
	//as being private.  This example shows the use of a 
	//technique called properties that provides access 
	//protection for the Class variables.  A property acts 
	//like a method (e.g. an accessor method in Java)  
	//It uses the keywords get (also known as an accessor) 
	//and set (also known as a mutator).  You do not declare 
	//the variable value, C# deals with this for you. 
 
	class Class2
	{
		static void Main(string[] args)
		{
			Car car1 = new Car();
			car1.Colour="Black";
			car1.Make="Mercedes-Benz";
			car1.Type="C220";
			car1.Country="Germany";
			car1.Cost=31000;
            car1.EngineSize=2.1;
			Console.WriteLine(
				"Car is a " + car1.Cost + " " + car1.Colour + " " + car1.EngineSize + " " + car1.Make + " " + car1.Type + " from " + car1.Country);

		
			Console.ReadLine();
		}
	}

	//1) Step through the running of this code using F11.  
	//Watch the variables in the 'Locals' window.

	//2) Add the other Car properties to the Console.WriteLine 
	//statement  to the car instance then run the program again.

	//3) Add some more of your own car instances with values for 
	//all the properties.   Note that autocomplete works for the
	//properties of the Car classStep through the running of this 
	//code using F11.  Watch the variables in the 'Locals' window.

	//4 Put the Car Class in a separate code file (named Car.cs 
	//with the same namespace).  Step through the running of this 
	//code using F11.  Watch the variables in the 'Locals' window.

	//(Hint use: File/Add New Item/ Code File)
}
