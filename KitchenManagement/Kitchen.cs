using System.Collections.Generic;

namespace KitchenManagement
{
	public class Kitchen
	{
		private static int _nextId = 1;
		private int _id;
		public List<Employee> EmployeeList { get; set; }
		private bool _isKnivesOut = false;

		public Kitchen()
		{
			_id = _nextId++;
		}

		public void Hire()
		{
			//todo
		}

		private void GiveKnifes()
		{
			//todo
		}

		public void Run(int round)
		{
			//todo
		}
	}
}