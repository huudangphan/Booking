using ModetourB2C.Dac.Model.NEWEAGLE3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Entity.Package.Package.TravelCore
{
    public class CityInfoModel
    {
        public UsdExchange UsdExchange { get; set; }
        public List<CityInfoItem> CityInfoItems { get; set; }
    }
    public class CityInfoItem
    {
        public string LocalDate { get; set; }
        public decimal ExchangeRateValue { get; set; }
        public string ExchangeRateDisplay { get; set; }
        public string CountryKoreanName { get; set; }
        public int CountryPlaceNumber { get; set; }
        public int CityPlaceNumber { get; set; }
        public string EnglishName { get; set; }

        public string CityDate { get; set; }
        public int INFOTYPE_Number { get; set; }
        public int SerialNumber { get; set; }
        public string CityKoreanName { get; set; }
        public TimeZoneInfo TimeZoneInfo { get; set; }
    }
    public class UsdExchange : WSP_S_EachCountry_ExchangeRate.Result
    {
        public decimal ExchangeRateValue { get; set; }
        public string ExchangeRateDisplay { get; set; }
    }
}
