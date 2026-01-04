namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_자주찾는패스
/// </summary>
public class WSP_S_BookmarkPASS
{
	public const string SP_NAME = "WSP_S_자주찾는패스";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 패스구분
		/// </summary>
		[Description("패스구분")]
		public string PASSClassification { get; set; }
		/// <summary>
		/// 패스명
		/// </summary>
		[Description("패스명")]
		public string PASSName { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 패스번호
		/// </summary>
		[Column("패스번호")]
		public string PASSNumber { get; set; }
		/// <summary>
		/// 패스구분
		/// </summary>
		[Column("패스구분")]
		public string PASSClassification { get; set; }
		/// <summary>
		/// 패스명
		/// </summary>
		[Column("패스명")]
		public string PASSName { get; set; }
		/// <summary>
		/// 사용
		/// </summary>
		[Column("사용")]
		public string Use { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 패스구분
		/// </summary>
		[Column("패스구분")]
		public string PASSClassification { get; set; }
		/// <summary>
		/// 패스번호
		/// </summary>
		[Column("패스번호")]
		public string PASSNumber { get; set; }
		/// <summary>
		/// 패스명
		/// </summary>
		[Column("패스명")]
		public string PASSName { get; set; }
		/// <summary>
		/// 사용
		/// </summary>
		[Column("사용")]
		public string Use { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 성인요금
		/// </summary>
		[Column("성인요금")]
		public int AdultFare { get; set; }
		/// <summary>
		/// 성인요금2
		/// </summary>
		[Column("성인요금2")]
		public int AdultFare2 { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Column("지역")]
		public string Region { get; set; }
		/// <summary>
		/// 통화단위
		/// </summary>
		[Column("통화단위")]
		public string CallUnit { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 패스구분
		/// </summary>
		[Column("패스구분")]
		public string PASSClassification { get; set; }
		/// <summary>
		/// 패스번호
		/// </summary>
		[Column("패스번호")]
		public string PASSNumber { get; set; }
		/// <summary>
		/// 패스명
		/// </summary>
		[Column("패스명")]
		public string PASSName { get; set; }
		/// <summary>
		/// 사용
		/// </summary>
		[Column("사용")]
		public string Use { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 성인요금
		/// </summary>
		[Column("성인요금")]
		public decimal AdultFare { get; set; }
		/// <summary>
		/// 성인요금2
		/// </summary>
		[Column("성인요금2")]
		public int AdultFare2 { get; set; }
		/// <summary>
		/// 셀렉트구분
		/// </summary>
		[Column("셀렉트구분")]
		public string SelectClassification { get; set; }
		/// <summary>
		/// 국가수
		/// </summary>
		[Column("국가수")]
		public int CountryNumber { get; set; }
		/// <summary>
		/// 통화단위
		/// </summary>
		[Column("통화단위")]
		public string CallUnit { get; set; }
	}
}