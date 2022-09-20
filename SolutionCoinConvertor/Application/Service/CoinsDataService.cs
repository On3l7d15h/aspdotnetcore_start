using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//added
using Application.ViewModel;
using Application.Enum;
using Application.Repository;

namespace Application.Service
{
    public class CoinsDataService
    {

        //Make the convertion
        public void MakeConvertion(CoinsDataViewModel cdm)
        {
            CoinsDataRepository.Instance.coinsData.CategoryTo = cdm.CategoryTo;
            CoinsDataRepository.Instance.coinsData.CategoryFrom = cdm.CategoryFrom;
            CoinsDataRepository.Instance.coinsData.Quantity = cdm.Quantity;

            switch (cdm.CategoryFrom)
            {
                case (int)Category.PESO:
                    {
                        if (cdm.CategoryTo == (int)Category.DOLAR)
                        {
                            CoinsDataRepository.Instance.coinsData.Result = Math.Round((float)(cdm.Quantity / 53.7), 2);
                        }

                        if (cdm.CategoryTo == (int)Category.EURO)
                        {
                            CoinsDataRepository.Instance.coinsData.Result = Math.Round((double)(cdm.Quantity / 53.49), 2);
                        }

                        break;
                    }

                case (int)Category.DOLAR:
                    {
                        if (cdm.CategoryTo == (int)Category.PESO)
                        {
                            CoinsDataRepository.Instance.coinsData.Result = Math.Round((double)(cdm.Quantity * 53.7), 2);
                        }

                        if (cdm.CategoryTo == (int)Category.EURO)
                        {
                            CoinsDataRepository.Instance.coinsData.Result = Math.Round((double)(cdm.Quantity * 1), 2);
                        }

                        break;
                    }

                case (int)Category.EURO:
                    {
                        if (cdm.CategoryTo == (int)Category.PESO)
                        {
                            CoinsDataRepository.Instance.coinsData.Result = Math.Round((double)(cdm.Quantity * 53.49), 2);
                        }

                        if (cdm.CategoryTo == (int)Category.DOLAR)
                        {
                            CoinsDataRepository.Instance.coinsData.Result = Math.Round((double)(cdm.Quantity * 1), 2);
                        }

                        break;
                    }
            }
        }

        //get data
        public CoinsDataViewModel GetData()
        {
            return CoinsDataRepository.Instance.coinsData;
        }

    }
}
