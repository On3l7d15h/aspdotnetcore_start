using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using
using Application.ViewModel;
using Application.Repository;
using Application.Enum;

namespace Application.Service
{
    public class DataLendingService
    {
        private int GetMonth(int value) 
        {
            switch (value)
            {
                case ((int)YearQuantityInsteadMonth.YEAR):
                    {
                        return 6 * (int)YearQuantityInsteadMonth.YEAR;
                    }

                case ((int)YearQuantityInsteadMonth.YEARANDHALF):
                    {
                        return 6 * (int)YearQuantityInsteadMonth.YEARANDHALF;
                    }

                case ((int)YearQuantityInsteadMonth.TWOYEARS):
                    {
                        return 6 * (int)YearQuantityInsteadMonth.TWOYEARS;
                    }

                case ((int)YearQuantityInsteadMonth.TWOYEARSANDHALF):
                    {
                        return 6 * (int)YearQuantityInsteadMonth.TWOYEARSANDHALF;
                    }

                case ((int)YearQuantityInsteadMonth.THREEYEARS):
                    {
                        return 6 * (int)YearQuantityInsteadMonth.THREEYEARS;
                    }

                case ((int)YearQuantityInsteadMonth.THREEYEARSANDHALF):
                    {
                        return 6 * (int)YearQuantityInsteadMonth.THREEYEARSANDHALF;
                    }

                case ((int)YearQuantityInsteadMonth.FOURYEARS):
                    {
                        return 6 * (int)YearQuantityInsteadMonth.FOURYEARS;
                    }

                case ((int)YearQuantityInsteadMonth.FOURYEARSANDHALF):
                    {
                        return 6 * (int)YearQuantityInsteadMonth.FOURYEARSANDHALF;
                    }

                case ((int)YearQuantityInsteadMonth.FIVEYEARS):
                    {
                        return 6 * (int)YearQuantityInsteadMonth.FIVEYEARS;
                    }

                case ((int)YearQuantityInsteadMonth.FIVEYEARSANDHALF):
                    {
                        return 6 * (int)YearQuantityInsteadMonth.FIVEYEARSANDHALF;
                    }

                case ((int)YearQuantityInsteadMonth.SIXYEARS):
                    {
                        return 6 * (int)YearQuantityInsteadMonth.SIXYEARS;
                    }

                case ((int)YearQuantityInsteadMonth.SIXYEARSANDHALF):
                    {
                        return 6 * (int)YearQuantityInsteadMonth.SIXYEARSANDHALF;
                    }

                case ((int)YearQuantityInsteadMonth.SEVENYEARS):
                    {
                        return 6 * (int)YearQuantityInsteadMonth.SEVENYEARS;
                    }

                case ((int)YearQuantityInsteadMonth.SEVENYEARSANDHALF):
                    {
                        return 6 * (int)YearQuantityInsteadMonth.SEVENYEARSANDHALF;
                    }

                case ((int)YearQuantityInsteadMonth.EIGHTYEARS):
                    {
                        return 6 * (int)YearQuantityInsteadMonth.EIGHTYEARS;
                    }

                case ((int)YearQuantityInsteadMonth.EIGHTYEARSANDHALF):
                    {
                        return 6 * (int)YearQuantityInsteadMonth.EIGHTYEARSANDHALF;
                    }

                case ((int)YearQuantityInsteadMonth.NINEYEARS):
                    {
                        return 6 * (int)YearQuantityInsteadMonth.NINEYEARS;
                    }

                case ((int)YearQuantityInsteadMonth.NINEYEARSANDHALF):
                    {
                        return 6 * (int)YearQuantityInsteadMonth.NINEYEARSANDHALF;
                    }

                case ((int)YearQuantityInsteadMonth.TENYEARS):
                    {
                        return 6 * (int)YearQuantityInsteadMonth.TENYEARS;
                    }

                default:
                    {
                        return 6;
                    }
            }
        }

        private double GetNumericPorcentage(int lending)
        {
            switch (lending)
            {
                case ((int)LendingToPorcentageEnum.TWENTYTWOPERCENT):
                    {
                        DataLendingRepository.Instance.dataLending.Porcentage = "22%";
                        return 0.22;
                    }

                case ((int)LendingToPorcentageEnum.TWELVEPERCENT):
                    {
                        DataLendingRepository.Instance.dataLending.Porcentage = "12%";
                        return 0.12;
                    }

                case ((int)LendingToPorcentageEnum.EIGHTPERCENT):
                    {
                        DataLendingRepository.Instance.dataLending.Porcentage = "8%";
                        return 0.08;
                    }

                default:
                    {
                        return 0.00;
                    }
            }
        }

        public void CalculateMount(DataLendingViewModel dlm)
        {
            DataLendingRepository.Instance.dataLending.Mount = dlm.Mount;
            DataLendingRepository.Instance.dataLending.Lending = dlm.Lending;
            DataLendingRepository.Instance.dataLending.Months = dlm.Months;

            int months = GetMonth(dlm.Months);
            double percent = GetNumericPorcentage(dlm.Lending);

            switch (dlm.Lending)
            {
                case ((int)Lending.PERSONAL):
                    {
                        double result = (((percent) * dlm.Mount) + dlm.Mount)/(months);
                        DataLendingRepository.Instance.dataLending.Result = Math.Round(result, 2);
                        break;
                    }

                case ((int)Lending.AUTOMOVIL):
                    {
                        double result = (((percent) * dlm.Mount) + dlm.Mount) / (months);
                        DataLendingRepository.Instance.dataLending.Result = Math.Round(result, 2);
                        break;
                    }

                case ((int)Lending.HIPOTECARIO):
                    {
                        double result = (((percent) * dlm.Mount) + dlm.Mount) / (months);
                        DataLendingRepository.Instance.dataLending.Result = Math.Round(result, 2);
                        break;
                    }
            }

        }

        public DataLendingViewModel GetResults()
        {
            return DataLendingRepository.Instance.dataLending;
        }

    }
}
