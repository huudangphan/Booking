namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSV_S_예약조회
/// </summary>
public class WSV_S_ReservationFind
{
	public const string SP_NAME = "WSV_S_예약조회";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 예약자번호
		/// </summary>
		[Description("예약자번호")]
		public int BookerNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 품목그룹
		/// </summary>
		[Column("품목그룹")]
		public string ProductListGroup { get; set; }
		/// <summary>
		/// 품목코드
		/// </summary>
		[Column("품목코드")]
		public string ProductListCode { get; set; }
		/// <summary>
		/// GDS코드
		/// </summary>
		[Column("GDS코드")]
		public string GDS_Code { get; set; }
		/// <summary>
		/// GDS주문번호
		/// </summary>
		[Column("GDS주문번호")]
		public string GDS_OrderNumber { get; set; }
		/// <summary>
		/// 웹서비스버전명
		/// </summary>
		[Column("웹서비스버전명")]
		public string WebServiceVersionName { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 품목그룹
		/// </summary>
		[Column("품목그룹")]
		public string ProductListGroup { get; set; }
		/// <summary>
		/// 품목코드
		/// </summary>
		[Column("품목코드")]
		public string ProductListCode { get; set; }
		/// <summary>
		/// GDS코드
		/// </summary>
		[Column("GDS코드")]
		public string GDS_Code { get; set; }
		/// <summary>
		/// GDS주문번호
		/// </summary>
		[Column("GDS주문번호")]
		public string GDS_OrderNumber { get; set; }
		/// <summary>
		/// 웹서비스버전명
		/// </summary>
		[Column("웹서비스버전명")]
		public string WebServiceVersionName { get; set; }
		/// <summary>
		/// GUID
		/// </summary>
		[Column("GUID")]
		public string GUID { get; set; }
		/// <summary>
		/// 국가코드
		/// </summary>
		[Column("국가코드")]
		public string CountryCode { get; set; }
	}
}