using System;

namespace KitchenManagement
{
	public class Cook : Employee
	{
		public bool HasKnife { get; set; } = false;

		public Cook(Kitchen myKitchen, int salary, string name, DateTime birtDate)
			: base(myKitchen, salary, name, birtDate)
		{
		}

		public void Work()
		{
			if (ConditionMetForWork()) DoesTheirJob();
		}

		protected virtual bool ConditionMetForWork()
		{
			if (!HasKnife) Yell("I can't work because I don't have a knife!");
			return HasKnife;
		}

		protected virtual void DoesTheirJob()
		{
			Yell("I'm cooking!");
		}
	}
}