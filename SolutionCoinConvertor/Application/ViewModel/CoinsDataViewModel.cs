using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModel
{
    public class CoinsDataViewModel
    {
        public int CategoryTo { get; set; } = 1;

        public int CategoryFrom { get; set; } = 1;

        public double Quantity { get; set; } = 0.00;

        public double Result { get; set; } = 0.00;
    }
}
