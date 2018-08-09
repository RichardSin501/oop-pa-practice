using System;

namespace KitchenManagement
{
	public class Program
	{
		private static void Main()
		{
			Kitchen kitchen = new Kitchen();
			kitchen.Run();
			Console.ReadKey();
		}
	}
}