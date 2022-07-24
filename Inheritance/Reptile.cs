using System;

namespace Inheritance
{
	class Reptile : Animal
	{
		public string ScaleColor { get; set; }
		
		public string ClawLength { get; set; }

		public int TailLengthInches { get; set; }

		public bool ColorChanges { get; set; }

		public void ShowDetails()
        {
			Console.WriteLine($"Their scales are {ScaleColor}\nTheir claws are {ClawLength}\nTheir tails are {TailLengthInches} inches in length\nIt is {ColorChanges} that their colors change");
		}
	}
}
