using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Entity.Package
{
    public class TravelScheduleViewModel
    {
        /// <summary>
        /// 출발편_경유도시명
        /// </summary>
        public string D_ThroughCityName { get; set; }
        /// <summary>
        /// 한국출발도시명
        /// </summary>

        public string KorDepartureCity { get; set; }

        /// <summary>
        /// 한국출발도시명
        /// </summary>

        public string KorDepartureCityName { get; set; }


        public string TravelPeriod { get; set; }
        /// <summary>
        /// 출발항공편
        /// </summary>

        public string DepartureFlight { get; set; }
        /// <summary>
        /// 출발시간
        /// </summary>
        public string DepartureTime { get; set; }
        public string FlightCode { get; set; }
        /// <summary>
        /// 항공사명
        /// </summary>
        public string AirlineName { get; set; }

        /// <summary>
        /// 출발도시
        /// </summary>
        public string DepartureCity { get; set; }
        /// <summary>
        /// 출발도시명
        /// </summary>
        public string DepartureCityName { get; set; }
        /// <summary>
        /// 출발공항명
        /// </summary>
        public string DepartureAirportName { get; set; }
      

        public DateTime DepartureDate { get; set; }
        /// <summary>
        /// 도착일
        /// </summary>
        public DateTime ArrivalDate { get; set; }

        /// <summary>
        /// 출발편_경유도시코드
        /// </summary>
        public string D_ThroughCity { get; set; }

        /// <summary>
        /// 도착도시
        /// </summary>
        public string ArrivalCity { get; set; }
        /// <summary>
        /// 도착도시명
        /// </summary>
        public string ArrivalCityName { get; set; }

        /// <summary>
        /// 귀국편_경유도시코드
        /// </summary>
        public string A_ThroughCity { get; set; }

        /// <summary>
        /// 출발편_도착일자
        /// </summary>
        public DateTime D_ArrivalDate { get; set; }

        /// <summary>
        /// 한국도착도시명
        /// </summary>
        public string KorArrivalCityName { get; set; }
        /// <summary>
        /// 출발편_경유도시_도착일
        /// </summary>
        public DateTime D_T_ArrivalDate { get; set; }
        /// <summary>
        /// 출발편_경유도시_도착시간
        /// </summary>
        public string D_T_ArrivalTime { get; set; }
        /// <summary>
        /// 현지도착시간
        /// </summary>
        public string LocalArrivalTime { get; set; }
        /// <summary>
        /// 현지출발시간
        /// </summary>
        public string LocalDepartureTime { get; set; }

        /// <summary>
        /// 귀국편_출발일자
        /// </summary>
        public DateTime A_DepartureDate { get; set; }
        /// <summary>
        /// 출발항공편
        /// </summary>
        public string DepartureAirFlight { get; set; }
        /// <summary>
        /// 도착시간
        /// </summary>
        public string ArrivalTime { get; set; }
        /// <summary>
        /// 귀국편_경유도시_출발일자
        /// </summary>
        public DateTime A_T_DepartureDate { get; set; }
        /// <summary>
        /// 귀국편_경유도시명
        /// </summary>
        public string A_ThroughCityName { get; set; }
        /// <summary>
        /// 경유출발일정표시
        /// </summary>
        public string ThroughDepartureFlag { get; set; }
        /// <summary>
        /// 도착항공편
        /// </summary>
        public string ArrivalAirFlight { get; set; }
        /// <summary>
        /// 경유도착일정표시
        /// </summary>
        public string ThroughArrivalFlag { get; set; }
        /// <summary>
        /// 귀국편_경유도시_출발시간
        /// </summary>
        public string A_T_DepartureTime { get; set; }

        public string AddPerson { get; set; }
        
        public int? BookingSeatNumber { get; set; }
        public int? LND { get; set; }
        public int? MinimumDepartureNumberOfPeople { get; set; }


        public List<string> VisitCity { get; set; }
        

    }
}
