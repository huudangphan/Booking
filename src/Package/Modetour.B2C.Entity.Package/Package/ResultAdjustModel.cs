using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Entity.Package.Package
{
    public class ResultAdjustModel
    {
        public List<Adjustment> Adjustment { get; set; }
    }
    public class Adjustment
    {
        public string AdjustmentId { get; set; }
        public string AdjustmentName { get; set; }
        public Recommendations Recommendations { get; set; }
        public List<Priority> Priorities { get; set; }
    }
    public class Priority
    {
        public string CountryAreaKeywordId { get; set; }
        public string CityAreaKeywordId { get; set; }
        public List<string> GdsHotelCodes { get; set; }
        public List<string> ProductMasterCodeIds { get; set; }
    }

    public class Recommendations
    {
        public Airlines Airlines { get; set; }
        public DepartureTime DepartureTime { get; set; }
        public HotelGrade HotelGrade { get; set; }
        public LotsOfSeatsLeft LotsOfSeatsLeft { get; set; }
    }
    public class Airlines
    {
        public object Data { get; set; }
        public string Status { get; set; }
    }

    public class DepartureTime
    {
        public string Data { get; set; }
        public string Status { get; set; }
    }

    public class HotelGrade
    {
        public string Data { get; set; }
        public string Status { get; set; }
    }

    public class LotsOfSeatsLeft
    {
        public string Data { get; set; }
        public string Status { get; set; }
    }

}
