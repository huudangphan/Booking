namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_무인센딩인솔자_정산_거래처
/// </summary>
public class WSP_S_UnmannedSendingLeader_Settlement_Customer
{
	public const string SP_NAME = "WSP_S_무인센딩인솔자_정산_거래처";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 정산자
		/// </summary>
		[Description("정산자")]
		public int SettlePerson { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Column("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 랜드사
		/// </summary>
		[Column("랜드사")]
		public string LandCompany { get; set; }
		/// <summary>
		/// 랜드사번호
		/// </summary>
		[Column("랜드사번호")]
		public int LandCompanyNumber { get; set; }
	}
}