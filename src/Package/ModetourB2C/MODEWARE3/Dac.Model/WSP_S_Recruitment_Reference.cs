namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_채용_참조
/// </summary>
public class WSP_S_Recruitment_Reference
{
	public const string SP_NAME = "WSP_S_채용_참조";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 공고일련번호
		/// </summary>
		[Description("공고일련번호")]
		public int AnnounceSerialNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 코드
		/// </summary>
		[Column("코드")]
		public string Code { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 코드번호
		/// </summary>
		[Column("코드번호")]
		public int CodeNumber { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
		/// <summary>
		/// COL1
		/// </summary>
		[Column("COL1")]
		public string COL1 { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 코드번호
		/// </summary>
		[Column("코드번호")]
		public int CodeNumber { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// 자기소개서문항일련번호
		/// </summary>
		[Column("자기소개서문항일련번호")]
		public int SelfIntroductionFormQuestionSerialNumber { get; set; }
		/// <summary>
		/// 자기소개서문항
		/// </summary>
		[Column("자기소개서문항")]
		public string SelfIntroductionFormQuestion { get; set; }
		/// <summary>
		/// 글자수제한
		/// </summary>
		[Column("글자수제한")]
		public int CharactersNumberLimit { get; set; }
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// 모집부문일련번호
		/// </summary>
		[Column("모집부문일련번호")]
		public int RecruitmentSectionSerialNumber { get; set; }
		/// <summary>
		/// 직무코드명
		/// </summary>
		[Column("직무코드명")]
		public string DutyCodeName { get; set; }
		/// <summary>
		/// 입사구분코드명
		/// </summary>
		[Column("입사구분코드명")]
		public string CompanyJoiningClassificationCodeName { get; set; }
	}

	public class Result6 : IDbResult
	{
		/// <summary>
		/// 모집부문일련번호
		/// </summary>
		[Column("모집부문일련번호")]
		public int RecruitmentSectionSerialNumber { get; set; }
		/// <summary>
		/// 지역코드명
		/// </summary>
		[Column("지역코드명")]
		public string RegionCodeName { get; set; }
	}

	public class Result7 : IDbResult
	{
		/// <summary>
		/// 코드번호
		/// </summary>
		[Column("코드번호")]
		public string CodeNumber { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
		/// <summary>
		/// 키인
		/// </summary>
		[Column("키인")]
		public string Keyin { get; set; }
	}
}