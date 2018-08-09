using System;
using System.Collections.Generic;

namespace KitchenManagement
{
	public class KitchenHelper : Employee
	{
		public Dictionary<Ingredient, int> Stock { get; } = new Dictionary<Ingredient, int>();

		public KitchenHelper(Kitchen myKitchen, int salary, string name, DateTime birtDate) : base(myKitchen, salary, name, birtDate)
		{
			foreach (Ingredient ingredient in Enum.GetValues(typeof(Ingredient)))
			{
				Stock.Add(ingredient, Util.Random.Next(4));
			}
		}

		public bool ProvideIngredient(Ingredient ingredient)
		{
			if (Stock.ContainsKey(ingredient))
			{
				Stock[ingredient]--;
				if (Stock[ingredient] == 0)
				{
					Stock.Remove(ingredient);
				}
				Yell($"I provided the requested {ingredient}!");
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}