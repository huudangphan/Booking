namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_회원정보상세
/// </summary>
public class USP_S_MemberInfoDetail
{
	public const string SP_NAME = "USP_S_회원정보상세";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 출국목적코드
		/// </summary>
		[Column("출국목적코드")]
		public string LeaveCountryPurposeCode { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 출발지코드
		/// </summary>
		[Column("출발지코드")]
		public string DeparturesCode { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 여행경험지대분류
		/// </summary>
		[Column("여행경험지대분류")]
		public string TravelExperiencePointMajorClassification { get; set; }
		/// <summary>
		/// 여행경험지소분류
		/// </summary>
		[Column("여행경험지소분류")]
		public string TravelExperiencePointSubClassification { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 관심지역대분류
		/// </summary>
		[Column("관심지역대분류")]
		public string InterestingRegionMajorClassification { get; set; }
		/// <summary>
		/// 관심지역소분류
		/// </summary>
		[Column("관심지역소분류")]
		public string InterestingRegionSubClassification { get; set; }
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 관심테마코드
		/// </summary>
		[Column("관심테마코드")]
		public string InterestingThemeCode { get; set; }
	}

	public class Result6 : IDbResult
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 여행시기
		/// </summary>
		[Column("여행시기")]
		public string TravelTime { get; set; }
	}

	public class Result7 : IDbResult
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 관심혜택
		/// </summary>
		[Column("관심혜택")]
		public string InterestingBenefit { get; set; }
	}
}