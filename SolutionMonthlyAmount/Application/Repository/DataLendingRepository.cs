using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//added
using Application.ViewModel;

namespace Application.Repository
{
    public sealed class DataLendingRepository
    {
        private DataLendingRepository()
        {

        }

        public static DataLendingRepository Instance { get; } = new();
        public DataLendingViewModel dataLending = new();
    }
}
