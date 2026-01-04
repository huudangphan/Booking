namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// GSP_S_년월차_사용현황_2019_MOBILE
/// </summary>
public class GSP_S_YearAndMonth_CurrentStateOfUse_2019_MOBILE
{
	public const string SP_NAME = "GSP_S_년월차_사용현황_2019_MOBILE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 년도
		/// </summary>
		[Description("년도")]
		public string Year { get; set; }
		/// <summary>
		/// 부서
		/// </summary>
		[Description("부서")]
		public string Department { get; set; }
		/// <summary>
		/// 퇴직년도
		/// </summary>
		[Description("퇴직년도")]
		public string RetirementYear { get; set; }
		/// <summary>
		/// 휴가일1
		/// </summary>
		[Description("휴가일1")]
		public DateTime VacationDate1 { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 성명
		/// </summary>
		[Column("성명")]
		public string Name { get; set; }
		/// <summary>
		/// 사원번호
		/// </summary>
		[Column("사원번호")]
		public int StaffNumber { get; set; }
		/// <summary>
		/// 입사일자
		/// </summary>
		[Column("입사일자")]
		public DateTime CompanyJoiningDate { get; set; }
		/// <summary>
		/// 경력기준일자
		/// </summary>
		[Column("경력기준일자")]
		public DateTime WorkExperienceStandardDate { get; set; }
		/// <summary>
		/// 퇴직일자
		/// </summary>
		[Column("퇴직일자")]
		public DateTime RetirementDate { get; set; }
		/// <summary>
		/// 사번
		/// </summary>
		[Column("사번")]
		public string EmployeeIdentifiedNumber { get; set; }
		/// <summary>
		/// 총년차
		/// </summary>
		[Column("총년차")]
		public decimal TotalAnnual { get; set; }
		/// <summary>
		/// 년차
		/// </summary>
		[Column("년차")]
		public decimal Annual { get; set; }
		/// <summary>
		/// 사용년차1
		/// </summary>
		[Column("사용년차1")]
		public decimal UseAnnual1 { get; set; }
		/// <summary>
		/// 사용년차2
		/// </summary>
		[Column("사용년차2")]
		public decimal UseAnnual2 { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 성명
		/// </summary>
		[Column("성명")]
		public string Name { get; set; }
		/// <summary>
		/// 사원번호
		/// </summary>
		[Column("사원번호")]
		public int StaffNumber { get; set; }
		/// <summary>
		/// 입사일자
		/// </summary>
		[Column("입사일자")]
		public DateTime CompanyJoiningDate { get; set; }
		/// <summary>
		/// 경력기준일자
		/// </summary>
		[Column("경력기준일자")]
		public DateTime WorkExperienceStandardDate { get; set; }
		/// <summary>
		/// 퇴직일자
		/// </summary>
		[Column("퇴직일자")]
		public DateTime RetirementDate { get; set; }
		/// <summary>
		/// 사번
		/// </summary>
		[Column("사번")]
		public string EmployeeIdentifiedNumber { get; set; }
		/// <summary>
		/// 총년차
		/// </summary>
		[Column("총년차")]
		public decimal TotalAnnual { get; set; }
		/// <summary>
		/// 년차
		/// </summary>
		[Column("년차")]
		public decimal Annual { get; set; }
		/// <summary>
		/// 월차
		/// </summary>
		[Column("월차")]
		public byte Monthly { get; set; }
		/// <summary>
		/// 휴가일1
		/// </summary>
		[Column("휴가일1")]
		public DateTime VacationDate1 { get; set; }
		/// <summary>
		/// 휴가일2
		/// </summary>
		[Column("휴가일2")]
		public DateTime VacationDate2 { get; set; }
		/// <summary>
		/// 기간
		/// </summary>
		[Column("기간")]
		public decimal Period { get; set; }
		/// <summary>
		/// 사유
		/// </summary>
		[Column("사유")]
		public string Reason { get; set; }
		/// <summary>
		/// 종류
		/// </summary>
		[Column("종류")]
		public string Type { get; set; }
		/// <summary>
		/// 년차사용일
		/// </summary>
		[Column("년차사용일")]
		public DateTime AnnualUseDate { get; set; }
		/// <summary>
		/// 년차사유
		/// </summary>
		[Column("년차사유")]
		public string AnnualReason { get; set; }
		/// <summary>
		/// 년차기간
		/// </summary>
		[Column("년차기간")]
		public decimal AnnualPeriod { get; set; }
		/// <summary>
		/// 월차_휴가일1
		/// </summary>
		[Column("월차_휴가일1")]
		public DateTime Monthly_VacationDate1 { get; set; }
		/// <summary>
		/// 월차_휴가일2
		/// </summary>
		[Column("월차_휴가일2")]
		public DateTime Monthly_VacationDate2 { get; set; }
		/// <summary>
		/// 월차_기간
		/// </summary>
		[Column("월차_기간")]
		public decimal Monthly_Period { get; set; }
		/// <summary>
		/// 월차_사유
		/// </summary>
		[Column("월차_사유")]
		public string Monthly_Reason { get; set; }
		/// <summary>
		/// 월차_종류
		/// </summary>
		[Column("월차_종류")]
		public string Monthly_Type { get; set; }
		/// <summary>
		/// 월차사용일
		/// </summary>
		[Column("월차사용일")]
		public DateTime MonthlyUseDate { get; set; }
		/// <summary>
		/// 월차사유
		/// </summary>
		[Column("월차사유")]
		public string MonthlyReason { get; set; }
		/// <summary>
		/// 월차기간
		/// </summary>
		[Column("월차기간")]
		public decimal MonthlyPeriod { get; set; }
		/// <summary>
		/// 메모
		/// </summary>
		[Column("메모")]
		public string Memo { get; set; }
		/// <summary>
		/// 바탕색
		/// </summary>
		[Column("바탕색")]
		public string BackgroundColor { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 성명
		/// </summary>
		[Column("성명")]
		public string Name { get; set; }
		/// <summary>
		/// 사원번호
		/// </summary>
		[Column("사원번호")]
		public int StaffNumber { get; set; }
		/// <summary>
		/// 년차
		/// </summary>
		[Column("년차")]
		public decimal Annual { get; set; }
		/// <summary>
		/// 휴가일1
		/// </summary>
		[Column("휴가일1")]
		public string VacationDate1 { get; set; }
		/// <summary>
		/// 휴가일2
		/// </summary>
		[Column("휴가일2")]
		public string VacationDate2 { get; set; }
		/// <summary>
		/// 기간
		/// </summary>
		[Column("기간")]
		public decimal Period { get; set; }
		/// <summary>
		/// 사유
		/// </summary>
		[Column("사유")]
		public string Reason { get; set; }
		/// <summary>
		/// 종류
		/// </summary>
		[Column("종류")]
		public string Type { get; set; }
		/// <summary>
		/// 년차기간
		/// </summary>
		[Column("년차기간")]
		public decimal AnnualPeriod { get; set; }
		/// <summary>
		/// 월차_휴가일1
		/// </summary>
		[Column("월차_휴가일1")]
		public DateTime Monthly_VacationDate1 { get; set; }
		/// <summary>
		/// 월차_휴가일2
		/// </summary>
		[Column("월차_휴가일2")]
		public DateTime Monthly_VacationDate2 { get; set; }
		/// <summary>
		/// 월차_기간
		/// </summary>
		[Column("월차_기간")]
		public decimal Monthly_Period { get; set; }
		/// <summary>
		/// 월차_사유
		/// </summary>
		[Column("월차_사유")]
		public string Monthly_Reason { get; set; }
		/// <summary>
		/// 월차_종류
		/// </summary>
		[Column("월차_종류")]
		public string Monthly_Type { get; set; }
		/// <summary>
		/// profile_image
		/// </summary>
		[Column("profile_image")]
		public string profile_image { get; set; }
	}
}