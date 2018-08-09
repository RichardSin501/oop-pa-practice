using System;

namespace KitchenManagement
{
	public class Cook : Employee
	{
		private bool _hasKnife = false;

		public Cook(ref Kitchen myKitchen, int salary, string name, DateTime birtDate)
			: base(ref myKitchen, salary, name, birtDate)
		{
		}
	}
}