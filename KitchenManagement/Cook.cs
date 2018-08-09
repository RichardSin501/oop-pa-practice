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

		protected override bool ConditionMetForWork()
		{
			return _hasKnife;
		}

		protected override void DoesTheirJob()
		{
			Yell("I'm cooking!");
		}

		protected override void YellReasoningWhyCantWork()
		{
			Yell("I can't work because I don't have a knife!");
		}
	}
}