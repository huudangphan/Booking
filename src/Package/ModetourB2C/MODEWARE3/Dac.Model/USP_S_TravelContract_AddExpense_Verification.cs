namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_여행계약서_추가경비_검증
/// </summary>
public class USP_S_TravelContract_AddExpense_Verification
{
	public const string SP_NAME = "USP_S_여행계약서_추가경비_검증";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 예약시작일
		/// </summary>
		[Description("예약시작일")]
		public DateTime BookingStartDate { get; set; }
		/// <summary>
		/// 예약종료일
		/// </summary>
		[Description("예약종료일")]
		public DateTime BookingEndDate { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public DateTime DepartureDate { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 예약일
		/// </summary>
		[Column("예약일")]
		public DateTime BookingDate { get; set; }
		/// <summary>
		/// 예약번호
		/// </summary>
		[Column("예약번호")]
		public int BookingNumber { get; set; }
		/// <summary>
		/// 취소
		/// </summary>
		[Column("취소")]
		public string Cancel { get; set; }
		/// <summary>
		/// 인원수
		/// </summary>
		[Column("인원수")]
		public int NumberOfPeopleNumber { get; set; }
		/// <summary>
		/// 추가경비_비자_CNT
		/// </summary>
		[Column("추가경비_비자_CNT")]
		public string AdditionalExpense_Visa_CNT { get; set; }
		/// <summary>
		/// 추가경비_접대_CNT
		/// </summary>
		[Column("추가경비_접대_CNT")]
		public string AdditionalExpense_Reception_CNT { get; set; }
		/// <summary>
		/// 추가경비_일정추가_CNT
		/// </summary>
		[Column("추가경비_일정추가_CNT")]
		public string AdditionalExpense_ScheduleAdd_CNT { get; set; }
		/// <summary>
		/// 추가경비_유료센딩_CNT
		/// </summary>
		[Column("추가경비_유료센딩_CNT")]
		public string AdditionalExpense_PaidSending_CNT { get; set; }
		/// <summary>
		/// 추가경비_호텔추가_CNT
		/// </summary>
		[Column("추가경비_호텔추가_CNT")]
		public string AdditionalExpense_HotelAdd_CNT { get; set; }
		/// <summary>
		/// 추가경비_부가서비스판매_CNT
		/// </summary>
		[Column("추가경비_부가서비스판매_CNT")]
		public string AdditionalExpense_AdditionalServiceSales_CNT { get; set; }
		/// <summary>
		/// 추가경비_항공추가_CNT
		/// </summary>
		[Column("추가경비_항공추가_CNT")]
		public string AdditionalExpense_FlightAdd_CNT { get; set; }
		/// <summary>
		/// 추가경비_기타_CNT
		/// </summary>
		[Column("추가경비_기타_CNT")]
		public string AdditionalExpense_Other_CNT { get; set; }
		/// <summary>
		/// 추가경비_비자
		/// </summary>
		[Column("추가경비_비자")]
		public string AdditionalExpense_Visa { get; set; }
		/// <summary>
		/// 추가경비_접대
		/// </summary>
		[Column("추가경비_접대")]
		public string AdditionalExpense_Reception { get; set; }
		/// <summary>
		/// 추가경비_일정추가
		/// </summary>
		[Column("추가경비_일정추가")]
		public string AdditionalExpense_ScheduleAdd { get; set; }
		/// <summary>
		/// 추가경비_유료센딩
		/// </summary>
		[Column("추가경비_유료센딩")]
		public string AdditionalExpense_PaidSending { get; set; }
		/// <summary>
		/// 추가경비_호텔추가
		/// </summary>
		[Column("추가경비_호텔추가")]
		public string AdditionalExpense_HotelAdd { get; set; }
		/// <summary>
		/// 추가경비_부가서비스판매
		/// </summary>
		[Column("추가경비_부가서비스판매")]
		public string AdditionalExpense_AdditionalServiceSales { get; set; }
		/// <summary>
		/// 추가경비_항공추가
		/// </summary>
		[Column("추가경비_항공추가")]
		public string AdditionalExpense_FlightAdd { get; set; }
		/// <summary>
		/// 추가경비_기타
		/// </summary>
		[Column("추가경비_기타")]
		public string AdditionalExpense_Other { get; set; }
		/// <summary>
		/// TAX_유류
		/// </summary>
		[Column("TAX_유류")]
		public string TAX_Oil { get; set; }
	}
}