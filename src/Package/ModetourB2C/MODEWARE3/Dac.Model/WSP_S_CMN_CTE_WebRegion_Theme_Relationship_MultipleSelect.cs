namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_CTE_웹지역_테마_관계_다중선택
/// </summary>
public class WSP_S_CMN_CTE_WebRegion_Theme_Relationship_MultipleSelect
{
	public const string SP_NAME = "WSP_S_CMN_CTE_웹지역_테마_관계_다중선택";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 지역번호
		/// </summary>
		[Description("지역번호")]
		public string RegionNumber { get; set; }
		/// <summary>
		/// 테마번호
		/// </summary>
		[Description("테마번호")]
		public string ThemeNumber { get; set; }
		/// <summary>
		/// HiddenYN
		/// </summary>
		[Description("HiddenYN")]
		public string HiddenYN { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 상위일련번호
		/// </summary>
		[Column("상위일련번호")]
		public int HighRankSerialNumber { get; set; }
		/// <summary>
		/// 명칭
		/// </summary>
		[Column("명칭")]
		public string Name { get; set; }
		/// <summary>
		/// 서브메인
		/// </summary>
		[Column("서브메인")]
		public string SubMain { get; set; }
		/// <summary>
		/// 숨김
		/// </summary>
		[Column("숨김")]
		public string Hide { get; set; }
		/// <summary>
		/// LEVEL
		/// </summary>
		[Column("LEVEL")]
		public int LEVEL { get; set; }
		/// <summary>
		/// SORT
		/// </summary>
		[Column("SORT")]
		public string SORT { get; set; }
	}
}