using System;

namespace KitchenManagement
{
	public class Util
	{
		public static readonly Random Random = new Random();

		public static Ingredient RandomIngredient()
		{
			Array ingredientsArr = Enum.GetValues(typeof(Ingredient));
			return (Ingredient)ingredientsArr.GetValue(
				Util.Random.Next(ingredientsArr.Length));
		}
	}
}