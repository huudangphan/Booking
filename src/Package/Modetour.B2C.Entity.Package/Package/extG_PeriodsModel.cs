namespace Modetour.B2C.Entity.Package
{
    public class ExtG_PeriodsModel
    {
        /// <summary>
        /// arr 닫/여는 시간 
        /// </summary>
        public List<ExtG_CloseOpenModel> periods { get; set; }
        /// <summary>
        /// arr 닫/여는 시간 str = Monday: 6:00 AM ~ 6:00 PM 포맷
        /// </summary>
        public List<string> weekday_text { get; set; }
    }

    public class ExtG_CloseOpenModel
    {
        /// <summary>
        /// 닫는시간
        /// closing time
        /// </summary>
        public ExtG_DayTimeModel close { get; set; }
        /// <summary>
        /// 여는시간
        /// opening hours
        /// </summary>
        public ExtG_DayTimeModel open { get; set; }
    }

    public class ExtG_DayTimeModel
    {
        /// <summary>
        /// 요일 0:월, 1:화, ~ 5:토, 6:일
        /// Day 0:Mon, 1:Tue, ~ 5:Sat, 6:Sun
        /// </summary>
        public string day { get; set; }
        /// <summary>
        /// 시간 0600, 1800 포맷
        /// Time 0600, 1800 format
        /// </summary>
        public string time { get; set; }
    }
}
