using System;
using System.Collections;

namespace Classes10
{
	/// <summary>
	/// Summary description for Rainbow.
	/// </summary>
	public class PaintShop
	{
		public ArrayList colourList = new ArrayList();
		public PaintShop() {
            display();
		}

        public void display() {
            Console.WriteLine(colourList);
        }

		// add a display method that displays all the colours
		// in a PaintShop
	}
}
