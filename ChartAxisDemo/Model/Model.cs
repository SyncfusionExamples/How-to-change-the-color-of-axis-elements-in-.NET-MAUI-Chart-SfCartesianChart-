using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartAxisDemo
{
	public class Model
    {
        public Model(string xValue, double yValue)
        {
            XValue = xValue;
            YValue = yValue;
        }

        public string XValue { get; set; }

        public double YValue { get; set; }
    }
}
