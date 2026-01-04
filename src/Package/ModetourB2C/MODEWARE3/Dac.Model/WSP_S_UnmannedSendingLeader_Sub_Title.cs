namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_무인센딩인솔자_서브_타이틀
/// </summary>
public class WSP_S_UnmannedSendingLeader_Sub_Title
{
	public const string SP_NAME = "WSP_S_무인센딩인솔자_서브_타이틀";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 행사번호
		/// </summary>
		[Column("행사번호")]
		public int EventNumber { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 메인여부
		/// </summary>
		[Column("메인여부")]
		public string MainOrNot { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 총여행객
		/// </summary>
		[Column("총여행객")]
		public int TotalTravelCustomer { get; set; }
	}
}