using System;

namespace Inheritance
{
	class Bird : Animal
	{
		public string FeatherColor { get; set; }
		
		public int Wings { get; set; }

		public bool IsWarmBlooded { get; set; }

		public bool CanFly { get; set; }

		public void ShowDetails()
        {
			Console.WriteLine($"Their feathers are {FeatherColor}\nThey have {Wings} wings\nWarm blooded: {IsWarmBlooded}\nCan fly: {CanFly}");
        }
	}
}
