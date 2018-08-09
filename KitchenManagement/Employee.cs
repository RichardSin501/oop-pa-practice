using System;

namespace KitchenManagement
{
	public abstract class Employee
	{
		public string Name { get; }
		public DateTime BirtDate { get; }
		public Kitchen MyKitchen { get; }

		private int _salary;

		public int Salary
		{
			get => _salary;
			set
			{
				if (value >= 0) _salary = value;
				else
				{
					throw new ArgumentOutOfRangeException(nameof(value), "Salary needs to be more than 0!");
				}
			}
		}

		protected Employee(ref Kitchen myKitchen, int salary, string name, DateTime birtDate)
		{
			MyKitchen = myKitchen;
			_salary = salary;
			Name = name;
			BirtDate = birtDate;
		}

		public void Work()
		{
			if (ConditionMetForWork()) DoesTheirJob();
			else YellReasoningWhyCantWork();
		}

		protected abstract bool ConditionMetForWork();

		protected abstract void DoesTheirJob();

		protected abstract void YellReasoningWhyCantWork();

		protected void Yell(string sentence)
		{
			Console.WriteLine($"{Name}, {this.GetType().Name} yells: {sentence}");
		}
	}
}