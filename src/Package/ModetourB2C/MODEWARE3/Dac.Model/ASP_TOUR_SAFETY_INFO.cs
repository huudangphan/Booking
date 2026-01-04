namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// ASP_TOUR_SAFETY_INFO
/// </summary>
public class ASP_TOUR_SAFETY_INFO
{
	public const string SP_NAME = "ASP_TOUR_SAFETY_INFO";

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
		/// PLKNAME
		/// </summary>
		[Column("PLKNAME")]
		public string PLKNAME { get; set; }
		/// <summary>
		/// 안전정보1
		/// </summary>
		[Column("안전정보1")]
		public string SafetyInfo1 { get; set; }
		/// <summary>
		/// 안전정보1내용
		/// </summary>
		[Column("안전정보1내용")]
		public string SafetyInfo1Content { get; set; }
		/// <summary>
		/// 안전정보2
		/// </summary>
		[Column("안전정보2")]
		public string SafetyInfo2 { get; set; }
		/// <summary>
		/// 안전정보2내용
		/// </summary>
		[Column("안전정보2내용")]
		public string SafetyInfo2Content { get; set; }
		/// <summary>
		/// 안전정보3
		/// </summary>
		[Column("안전정보3")]
		public string SafetyInfo3 { get; set; }
		/// <summary>
		/// 안전정보3내용
		/// </summary>
		[Column("안전정보3내용")]
		public string SafetyInfo3Content { get; set; }
	}
}