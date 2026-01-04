namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_회원본인인증정보_수정
/// </summary>
public class WSP_T_CMN_MemberOneselfVerificationInfo_Edit
{
	public const string SP_NAME = "WSP_T_CMN_회원본인인증정보_수정";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// CI
		/// </summary>
		[Description("CI")]
		public string CI { get; set; }
		/// <summary>
		/// DI
		/// </summary>
		[Description("DI")]
		public string DI { get; set; }
		/// <summary>
		/// 이름
		/// </summary>
		[Description("이름")]
		public string Name { get; set; }
		/// <summary>
		/// 생일
		/// </summary>
		[Description("생일")]
		public string Birthday { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Description("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 내외국인구분
		/// </summary>
		[Description("내외국인구분")]
		public string CitizenAndForeignerClassification { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Description("휴대폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 통신사코드
		/// </summary>
		[Description("통신사코드")]
		public string TelecomCompanyCode { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// RETURN_CODE
		/// </summary>
		[Column("RETURN_CODE")]
		public string RETURN_CODE { get; set; }
	}
}