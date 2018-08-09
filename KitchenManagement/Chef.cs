using System;

namespace KitchenManagement
{
	public class Chef : Cook
	{
		private readonly Random _random = new Random();

		public Chef(Kitchen myKitchen, int salary, string name, DateTime birtDate) : base(myKitchen, salary, name, birtDate)
		{ }

		protected override void DoesTheirJob()
		{
			if (_random.Next(2) == 0)
			{
				Yell("I'm instructing the cooks very loudly!!!");
			}
			else
			{
				Ingredient requestedIngredient = Util.RandomIngredient();
				Yell($"I'm asking for some {requestedIngredient}");
				MyKitchen.NeedIngredient(requestedIngredient);
			}
		}
	}
}