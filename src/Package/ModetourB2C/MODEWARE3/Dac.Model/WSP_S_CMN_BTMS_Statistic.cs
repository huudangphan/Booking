namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_BTMS_통계
/// </summary>
public class WSP_S_CMN_BTMS_Statistic
{
	public const string SP_NAME = "WSP_S_CMN_BTMS_통계";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Description("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 검색날짜조건
		/// </summary>
		[Description("검색날짜조건")]
		public string SearchingDateCondition { get; set; }
		/// <summary>
		/// 검색시작일
		/// </summary>
		[Description("검색시작일")]
		public DateTime SearchingStartDate { get; set; }
		/// <summary>
		/// 검색종료일
		/// </summary>
		[Description("검색종료일")]
		public DateTime SearchingEndDate { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 요청분류
		/// </summary>
		[Column("요청분류")]
		public string RequestClassification { get; set; }
		/// <summary>
		/// 구분명
		/// </summary>
		[Column("구분명")]
		public string ClassificationName { get; set; }
		/// <summary>
		/// 예약건수
		/// </summary>
		[Column("예약건수")]
		public int BookingNumber { get; set; }
		/// <summary>
		/// 총상품금액
		/// </summary>
		[Column("총상품금액")]
		public long TotalProductAmount { get; set; }
		/// <summary>
		/// 총추가판매액
		/// </summary>
		[Column("총추가판매액")]
		public long TotalAddSalesAmount { get; set; }
		/// <summary>
		/// 총수수료합계
		/// </summary>
		[Column("총수수료합계")]
		public long TotalFeeSum { get; set; }
		/// <summary>
		/// 총결제금액
		/// </summary>
		[Column("총결제금액")]
		public long TotalPaymentAmount { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 구분명
		/// </summary>
		[Column("구분명")]
		public string ClassificationName { get; set; }
		/// <summary>
		/// 예약건수
		/// </summary>
		[Column("예약건수")]
		public int BookingNumber { get; set; }
		/// <summary>
		/// 총상품금액
		/// </summary>
		[Column("총상품금액")]
		public long TotalProductAmount { get; set; }
		/// <summary>
		/// 총추가판매액
		/// </summary>
		[Column("총추가판매액")]
		public long TotalAddSalesAmount { get; set; }
		/// <summary>
		/// 총수수료합계
		/// </summary>
		[Column("총수수료합계")]
		public long TotalFeeSum { get; set; }
		/// <summary>
		/// 총결제금액
		/// </summary>
		[Column("총결제금액")]
		public long TotalPaymentAmount { get; set; }
	}
}