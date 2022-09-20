using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using
using Application.ViewModel;

namespace Application.Repository
{
    public sealed class ZodiacalSignRepository
    {
        private ZodiacalSignRepository()
        {
            
        }

        public static ZodiacalSignRepository Instance { get; } = new();
        public EstimateZodiacalSignViewModel zodiacalSign = new();
    }
}
