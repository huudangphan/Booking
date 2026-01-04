namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// GSP_S_인솔자_인사기록카드
/// </summary>
public class GSP_S_Leader_HRRecordCard
{
	public const string SP_NAME = "GSP_S_인솔자_인사기록카드";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 인솔자번호
		/// </summary>
		[Description("인솔자번호")]
		public int LeaderNumber { get; set; }
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

	public class Result : IDbResult
	{
		/// <summary>
		/// 사번
		/// </summary>
		[Column("사번")]
		public string EmployeeIdentifiedNumber { get; set; }
		/// <summary>
		/// 자기PR
		/// </summary>
		[Column("자기PR")]
		public string SelfPR { get; set; }
		/// <summary>
		/// 경력
		/// </summary>
		[Column("경력")]
		public int WorkExperience { get; set; }
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
		/// 영문성
		/// </summary>
		[Column("영문성")]
		public string EnglishLastName { get; set; }
		/// <summary>
		/// 영문이름
		/// </summary>
		[Column("영문이름")]
		public string EnglishName { get; set; }
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
	}
}