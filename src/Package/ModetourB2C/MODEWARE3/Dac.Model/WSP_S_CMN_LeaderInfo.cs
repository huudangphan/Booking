namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_인솔자정보
/// </summary>
public class WSP_S_CMN_LeaderInfo
{
	public const string SP_NAME = "WSP_S_CMN_인솔자정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 사번
		/// </summary>
		[Column("사번")]
		public string EmployeeIdentifiedNumber { get; set; }
		/// <summary>
		/// 한글성명
		/// </summary>
		[Column("한글성명")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Column("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 인솔경력
		/// </summary>
		[Column("인솔경력")]
		public int LeadingExperience { get; set; }
		/// <summary>
		/// 출장경력
		/// </summary>
		[Column("출장경력")]
		public string BusinessTripExperience { get; set; }
		/// <summary>
		/// 자격사항
		/// </summary>
		[Column("자격사항")]
		public string QualificationItem { get; set; }
		/// <summary>
		/// 본인소개
		/// </summary>
		[Column("본인소개")]
		public string SelfIntroduction { get; set; }
		/// <summary>
		/// 사진노출여부
		/// </summary>
		[Column("사진노출여부")]
		public string PictureDisplayOrNot { get; set; }
	}
}