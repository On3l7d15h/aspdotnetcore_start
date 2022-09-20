using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//added
using Application.Repository;
using Application.ViewModel;
using Application.Enum;

namespace Application.Service
{
    public class EstimateZodiacalService
    {
        public void Add(EstimateZodiacalSignViewModel zodiacalSign)
        {
            ZodiacalSignRepository.Instance.zodiacalSign.Day = zodiacalSign.Day;
            ZodiacalSignRepository.Instance.zodiacalSign.Month = zodiacalSign.Month; 
            switch (zodiacalSign.Month)
            {
                case (int)ZodiacalSign.ENERO:
                    {
                        if(zodiacalSign.Day <= 20)
                        {
                            ZodiacalSignRepository.Instance.zodiacalSign.Name = "CAPRICORNIO";
                        }

                        if (zodiacalSign.Day >= 21) 
                        {
                            ZodiacalSignRepository.Instance.zodiacalSign.Name = "ACUARIO";
                        }

                        break;
                    }

                case (int)ZodiacalSign.FEBRERO:
                    {
                        if (zodiacalSign.Day <= 19)
                        {
                            ZodiacalSignRepository.Instance.zodiacalSign.Name = "ACUARIO";
                        }

                        if (zodiacalSign.Day >= 20)
                        {
                            ZodiacalSignRepository.Instance.zodiacalSign.Name = "PISCIS";
                        }

                        break;

                    }

                case (int)ZodiacalSign.MARZO:
                    {
                        if (zodiacalSign.Day <= 20)
                        {
                            ZodiacalSignRepository.Instance.zodiacalSign.Name = "PISCIS";
                        }

                        if (zodiacalSign.Day >= 21)
                        {
                            ZodiacalSignRepository.Instance.zodiacalSign.Name = "ARIES";
                        }

                        break;

                    }

                case (int)ZodiacalSign.ABRIL:
                    {
                        if (zodiacalSign.Day <= 19)
                        {
                            ZodiacalSignRepository.Instance.zodiacalSign.Name = "ARIES";
                        }

                        if (zodiacalSign.Day >= 20)
                        {
                            ZodiacalSignRepository.Instance.zodiacalSign.Name = "TAURO";
                        }

                        break;

                    }

                case (int)ZodiacalSign.MAYO:
                    {
                        if (zodiacalSign.Day <= 20)
                        {
                            ZodiacalSignRepository.Instance.zodiacalSign.Name = "TAURO";
                        }

                        if (zodiacalSign.Day >= 21)
                        {
                            ZodiacalSignRepository.Instance.zodiacalSign.Name = "GEMINIS";
                        }

                        break;

                    }

                case (int)ZodiacalSign.JUNIO:
                    {
                        if (zodiacalSign.Day <= 20)
                        {
                            ZodiacalSignRepository.Instance.zodiacalSign.Name = "GEMINIS";
                        }

                        if (zodiacalSign.Day >= 21)
                        {
                            ZodiacalSignRepository.Instance.zodiacalSign.Name = "CANCER";
                        }

                        break;

                    }

                case (int)ZodiacalSign.JULIO:
                    {
                        if (zodiacalSign.Day <= 22)
                        {
                            ZodiacalSignRepository.Instance.zodiacalSign.Name = "CANCER";
                        }

                        if (zodiacalSign.Day >= 23)
                        {
                            ZodiacalSignRepository.Instance.zodiacalSign.Name = "LEO";
                        }

                        break;

                    }

                case (int)ZodiacalSign.AGOSTO:
                    {
                        if (zodiacalSign.Day <= 22)
                        {
                            ZodiacalSignRepository.Instance.zodiacalSign.Name = "LEO";
                        }

                        if (zodiacalSign.Day >= 23)
                        {
                            ZodiacalSignRepository.Instance.zodiacalSign.Name = "VIRGO";
                        }

                        break;

                    }

                case (int)ZodiacalSign.SEPTIEMBRE:
                    {
                        if (zodiacalSign.Day <= 22)
                        {
                            ZodiacalSignRepository.Instance.zodiacalSign.Name = "VIRGO";
                        }

                        if (zodiacalSign.Day >= 23)
                        {
                            ZodiacalSignRepository.Instance.zodiacalSign.Name = "LIBRA";
                        }

                        break;

                    }

                case (int)ZodiacalSign.OCTUBRE:
                    {
                        if (zodiacalSign.Day <= 22)
                        {
                            ZodiacalSignRepository.Instance.zodiacalSign.Name = "LIBRA";
                        }

                        if (zodiacalSign.Day >= 23)
                        {
                            ZodiacalSignRepository.Instance.zodiacalSign.Name = "ESCORPIO";
                        }

                        break;

                    }

                case (int)ZodiacalSign.NOVIEMBRE:
                    {
                        if (zodiacalSign.Day <= 21)
                        {
                            ZodiacalSignRepository.Instance.zodiacalSign.Name = "ESCORPIO";
                        }

                        if (zodiacalSign.Day >= 22)
                        {
                            ZodiacalSignRepository.Instance.zodiacalSign.Name = "SAGITARIO";
                        }

                        break;

                    }

                case (int)ZodiacalSign.DICIEMBRE:
                    {
                        if (zodiacalSign.Day <= 21)
                        {
                            ZodiacalSignRepository.Instance.zodiacalSign.Name = "SAGITARIO";
                        }

                        if (zodiacalSign.Day >= 22)
                        {
                            ZodiacalSignRepository.Instance.zodiacalSign.Name = "CAPRICORNIO";
                        }

                        break;

                    }
            }
        }

        public EstimateZodiacalSignViewModel GetZodiacalSign()
        {
            return ZodiacalSignRepository.Instance.zodiacalSign;
        }
    }
}
