namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_회원체크
/// </summary>
public class USP_S_MemberCheck
{
	public const string SP_NAME = "USP_S_회원체크";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// MT번호
		/// </summary>
		[Description("MT번호")]
		public string MT_Number { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 생년월일
		/// </summary>
		[Column("생년월일")]
		public string BirthYearMonthDay { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Column("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 회원구분
		/// </summary>
		[Column("회원구분")]
		public string MemberClassification { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
	}
}