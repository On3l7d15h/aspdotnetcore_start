using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModel
{
    public class DataLendingViewModel
    {
        public double Mount { get; set; } = 0.00;

        public int Lending { get; set; } = 1;

        public string Porcentage { get; set; } = "";

        public int Months { get; set; } = 2;

        public double Result { get; set; } = 0.00;
    }
}
