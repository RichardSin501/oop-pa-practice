using System;
using System.Collections.Generic;

namespace KitchenManagement
{
	public class Kitchen
	{
		private bool _outOfIngredients = false;
		private List<Employee> EmployeeList { get; } = new List<Employee>();

		public Kitchen()
		{
			Hire();
			GiveKnifes();
			TaxReport();
		}

		private void Hire()
		{
			EmployeeList.Add(new Chef(this, 200, "John", new DateTime(1999, 1, 1)));
			EmployeeList.Add(new Chef(this, 200, "James", new DateTime(1998, 1, 1)));
			EmployeeList.Add(new Cook(this, 100, "Janny", new DateTime(1997, 1, 1)));
			EmployeeList.Add(new Cook(this, 100, "Manny", new DateTime(1997, 1, 1)));
			EmployeeList.Add(new Cook(this, 100, "Frank", new DateTime(1996, 1, 1)));
			EmployeeList.Add(new KitchenHelper(this, 50, "Ben", new DateTime(1995, 1, 1)));
			EmployeeList.Add(new KitchenHelper(this, 50, "Dan", new DateTime(1994, 1, 1)));
			EmployeeList.Add(new KitchenHelper(this, 50, "Betty", new DateTime(1994, 1, 1)));
		}

		private void GiveKnifes()
		{
			foreach (var employee in EmployeeList)
			{
				if (employee is Cook cook)
				{
					cook.HasKnife = true;
				}
			}
		}

		public void Run()
		{
			while (!_outOfIngredients)
			{
				foreach (var employee in EmployeeList)
				{
					if (employee is Cook cook) cook.Work();
				}
			}

			Console.WriteLine("We have ran out of ingredients.");
		}

		private void TaxReport()
		{
			foreach (var employee in EmployeeList)
			{
				employee.TaxReport();
			}
		}

		public void NeedIngredient(Ingredient ingredient)
		{
			var gotIngredient = false;
			foreach (var employee in EmployeeList)
			{
				if (employee is KitchenHelper kitchenHelper)
				{
					if (kitchenHelper.ProvideIngredient(ingredient))
					{
						gotIngredient = true;
						break;
					}
				}
			}

			if (!gotIngredient)
			{
				_outOfIngredients = true;
			}
		}
	}
}