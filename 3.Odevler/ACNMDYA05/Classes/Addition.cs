using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACNMDYA05.Classes
{
    class Addition
    {
        public double Sum(ArrayList numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += Convert.ToDouble(numbers[i]);
            }
            return sum;
        }
    }
}
