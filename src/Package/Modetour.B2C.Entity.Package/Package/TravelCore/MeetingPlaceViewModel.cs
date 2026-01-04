using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Modetour.B2C.Entity.Package
{
    public class MeetingPlaceViewModel
    {
        /// <summary>
        /// 미팅장소코드 
        /// </summary>
        public string MeetingPlaceCode { get; set; }
        /// <summary>
        /// 미팅장소2
        /// </summary>
        public string MeetingPlace2 { get; set; }
        /// <summary>
        /// 미팅시간
        /// </summary>
        public string MeetingTime { get; set; }
        public string DepartureInfo { get; set; }
        public string ImagePath { get; set; } = "Not found";
    }
}
