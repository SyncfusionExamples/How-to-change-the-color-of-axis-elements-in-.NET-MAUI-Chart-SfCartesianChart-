using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartAxisDemo
{
	public class ViewModel
	{
		public ObservableCollection<Model> Data { get; set; }

		public ViewModel()
		{
			Data = new ObservableCollection<Model>();
			var random = new Random();
			var randomSpeed = new List<double>() { 1000, 1100, 1500, 2000, 2100, 2200 };
			var randomPressure = new List<double>() { 74, 77, 78, 79, 80, 82 };
			DateTime date = new DateTime(2000, 1, 1, 7, 0, 0);
			for (int i = 0; i < 100; i++)
			{
				Data.Add(new Model()
				{
					Time = date,
					Speed = randomSpeed[random.Next(0, 5)],
					Pressure = randomPressure[random.Next(0, 5)],
				});
				date = date.AddMinutes(10);
			}
		}
	}
}
