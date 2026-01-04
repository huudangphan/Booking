namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_일정표_가이드정보
/// </summary>
public class WSP_S_ScheduleTable_GuideInfo
{
	public const string SP_NAME = "WSP_S_일정표_가이드정보";

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
		/// 가이드성명
		/// </summary>
		[Column("가이드성명")]
		public string GuideName { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Column("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 나이
		/// </summary>
		[Column("나이")]
		public int Age { get; set; }
		/// <summary>
		/// 경력
		/// </summary>
		[Column("경력")]
		public int WorkExperience { get; set; }
		/// <summary>
		/// 사진
		/// </summary>
		[Column("사진")]
		public byte[] Picture { get; set; }
		/// <summary>
		/// 연락처
		/// </summary>
		[Column("연락처")]
		public string Contact { get; set; }
	}
}