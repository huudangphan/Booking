namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// GSP_S_인솔자_모객대장2
/// </summary>
public class GSP_S_Leader_AudienceLeader2
{
	public const string SP_NAME = "GSP_S_인솔자_모객대장2";

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
		/// 영문이름
		/// </summary>
		[Column("영문이름")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Column("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 주민번호
		/// </summary>
		[Column("주민번호")]
		public string CitizenIDNumber { get; set; }
		/// <summary>
		/// 방번호
		/// </summary>
		[Column("방번호")]
		public int RoomNumber { get; set; }
		/// <summary>
		/// 판매가
		/// </summary>
		[Column("판매가")]
		public long SellingPrice { get; set; }
		/// <summary>
		/// 추가판매
		/// </summary>
		[Column("추가판매")]
		public long AddSales { get; set; }
		/// <summary>
		/// 여권번호
		/// </summary>
		[Column("여권번호")]
		public string PassportNumber { get; set; }
		/// <summary>
		/// 여권만료일
		/// </summary>
		[Column("여권만료일")]
		public DateTime PassportExpirationDate { get; set; }
		/// <summary>
		/// 여권위치
		/// </summary>
		[Column("여권위치")]
		public string PassportPosition { get; set; }
		/// <summary>
		/// 판매비고
		/// </summary>
		[Column("판매비고")]
		public string SalesNote { get; set; }
	}
}