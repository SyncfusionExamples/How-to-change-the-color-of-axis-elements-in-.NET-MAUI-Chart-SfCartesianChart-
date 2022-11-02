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
			Data = new ObservableCollection<Model>()
			{
				new Model("Naveen", 25000),
				new Model("John", 15000),
				new Model("James", 35000),
				new Model("Magesh", 20000),
				new Model("Karthi", 25000),
				new Model("Ram", 17000),
			};
		}
	}
}
