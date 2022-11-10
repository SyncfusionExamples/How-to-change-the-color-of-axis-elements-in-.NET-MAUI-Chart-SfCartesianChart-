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
			Data.Add(new Model() { Brand = "Adidas", ItemsCount = 416 });
			Data.Add(new Model() { Brand = "Nike", ItemsCount = 520 });
			Data.Add(new Model() { Brand = "Reebok", ItemsCount = 470 });
			Data.Add(new Model() { Brand = "Fila", ItemsCount = 500 });
			Data.Add(new Model() { Brand = "Puma", ItemsCount = 449 });
			Data.Add(new Model() { Brand = "New Balance", ItemsCount = 360 });
			Data.Add(new Model() { Brand = "Asics", ItemsCount = 437 });
			Data.Add(new Model() { Brand = "Skechers", ItemsCount = 458 });
			Data.Add(new Model() { Brand = "Bata", ItemsCount = 500 });
			Data.Add(new Model() { Brand = "Burberry", ItemsCount = 473 });
		}
	}
}
