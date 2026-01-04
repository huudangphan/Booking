namespace Modetour.B2C.Entity.Package
{
    /// <summary>
	/// 다른일정
    /// another schedule
	/// </summary>
	public class OtherDayModel
    {
        /// <summary>
        /// 단체번호
        ///  group number
        /// </summary>
        public int PNum { get; set; }
        /// <summary>
        /// 항공코드
        /// flight code
        /// </summary>
        public string AirCode { get; set; }
        /// <summary>
        /// 항공코드정렬
        ///   Flight Code Sort
        /// </summary>
        public string AirCodeOrder { get; set; }
        /// <summary>
        /// 항공사명  
        /// airline name
        /// </summary>
        public string AirName { get; set; }
        /// <summary>
        /// 항공편명 
        /// flight number
        /// </summary>
        public string AirFlight { get; set; }
        /// <summary>
        /// 판매가_어른   
        /// Price_Adult
        /// </summary>
        public int SPrice_Adult { get; set; }
        /// <summary>
        /// 출발일자
        /// </summary>
        public string DepartureDate { get; set; }
        /// <summary>
        /// 출발시간
        /// </summary>
        public string DepartureTime { get; set; }
        /// <summary>
        /// 상품명
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// 상품등급
        /// </summary>
        public string ProductGrade { get; set; }
        /// <summary>
        /// 보유좌석수
        /// </summary>
        public int OwnsSeat { get; set; }
        /// <summary>
        /// 예약된좌석수
        /// </summary>
        public int BookingSeat { get; set; }
        /// <summary>
        /// 남은좌석수
        /// </summary>
        public int RemainSeat { get; set; }
        /// <summary>
        /// 판매마감
        /// </summary>
        public string DeadConfirm { get; set; }
        /// <summary>
        /// 출발확정
        /// </summary>
        public string DepartureConfirm { get; set; }
        /// <summary>
        /// 제휴여부
        /// </summary>
        public string PartnerFlag { get; set; }
        /// <summary>
        /// 인센티브여부
        /// </summary>
        public string IncentiveFlag { get; set; }
        /// <summary>
        /// 예약상태
        /// </summary>
        public string StateText { get; set; }
        /// <summary>
        /// 최소출발인원
        /// </summary>
        public int MinPerson_Departure { get; set; }
        /// <summary>
        /// 박수
        /// </summary>
        public int Night { get; set; }
        /// <summary>
        /// 일수
        /// </summary>
        public int Days { get; set; }
        /// <summary>
        /// 포인트율
        /// </summary>
        public decimal PointRate { get; set; }
        /// <summary>
        /// 프로모션여부
        /// </summary>
        public string PromotionFlag { get; set; }
        /// <summary>
        /// 대표이미지
        /// </summary>
        public string FaceImg { get; set; }
        /// <summary>
        /// 단체지역명 add by 2020.02.21(신지영)
        /// </summary>
        public string P_Area_Name { get; set; }
    }
}
