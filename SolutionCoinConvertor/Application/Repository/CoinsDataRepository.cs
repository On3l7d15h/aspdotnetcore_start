using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//added
using Application.ViewModel;

namespace Application.Repository
{
    public sealed class CoinsDataRepository
    {
        //Singleton
        private CoinsDataRepository()
        {

        }

        public static CoinsDataRepository Instance { get; } = new();
        public CoinsDataViewModel coinsData = new();
    }
}
