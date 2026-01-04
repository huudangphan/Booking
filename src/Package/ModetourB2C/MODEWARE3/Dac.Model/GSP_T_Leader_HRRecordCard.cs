namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// GSP_T_인솔자_인사기록카드
/// </summary>
public class GSP_T_Leader_HRRecordCard
{
	public const string SP_NAME = "GSP_T_인솔자_인사기록카드";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 인솔자번호
		/// </summary>
		[Description("인솔자번호")]
		public int LeaderNumber { get; set; }
		/// <summary>
		/// 영문성
		/// </summary>
		[Description("영문성")]
		public string EnglishLastName { get; set; }
		/// <summary>
		/// 영문이름
		/// </summary>
		[Description("영문이름")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 여권번호
		/// </summary>
		[Description("여권번호")]
		public string PassportNumber { get; set; }
		/// <summary>
		/// 여권만료일
		/// </summary>
		[Description("여권만료일")]
		public DateTime PassportExpirationDate { get; set; }
		/// <summary>
		/// 본인소개
		/// </summary>
		[Description("본인소개")]
		public string SelfIntroduction { get; set; }
		/// <summary>
		/// 자격사항
		/// </summary>
		[Description("자격사항")]
		public string QualificationItem { get; set; }
		/// <summary>
		/// 자기PR
		/// </summary>
		[Description("자기PR")]
		public string SelfPR { get; set; }
		/// <summary>
		/// 경력
		/// </summary>
		[Description("경력")]
		public int WorkExperience { get; set; }
		/// <summary>
		/// 출장경력
		/// </summary>
		[Description("출장경력")]
		public string BusinessTripExperience { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
		/// <summary>
		/// 에러메시지
		/// </summary>
		[DapperParameter(DbType.String, ParameterDirection.InputOutput, 1000)]
		[Description("에러메시지")]
		public string ErrorMessage { get; set; }
	}

}