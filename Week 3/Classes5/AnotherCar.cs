using System;
using System.Reflection;

namespace Classes5
{
	/// <summary>
	/// Summary description for AnotherCar.
	/// </summary>
	public class AnotherCar
	{
			private string colour;
			private string type;
			private string make;
			private string country;
			private double cost; 

            public static string display(AnotherCar car)
            {
                string objectAsXmlString;

                System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(car.GetType());
                using (System.IO.StringWriter sw = new System.IO.StringWriter())
                {
                    try
                    {
                        xs.Serialize(sw, car);
                        objectAsXmlString = sw.ToString();
                    }
                    catch (Exception ex)
                    {
                        objectAsXmlString = ex.ToString();
                    }
                }

                return objectAsXmlString;
            }

			public AnotherCar() // constructor methods
			{
				country="UK"; 
			}
			public AnotherCar(string m)
			{
				country="UK";
				make=m;
			}
			public AnotherCar(string m, string t)
			{
				country="UK";
				make=m; 	
				type=t;
			}

			public string Country // read only Property
			{
				get { return country; }
			
			}
		
			public string Colour //property for manipulating colour
			{
				get {return colour; }
				set {colour=value; 	}
			}
			public string Type //property for manipulating type
			{
				get {return type;}
				set {type=value;}
			} 
		
			public string Make //property for manipulating make
			{
				get { return make; }
				set { make=value; }	
			}
			public double Cost //property for manipulating cost
			{
				get { return cost; }
				set { cost=value; }	
			}
	}
}
