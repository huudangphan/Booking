namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_CTE_웹지역_다중선택
/// </summary>
public class WSP_S_CMN_CTE_WebRegion_MultipleSelect
{
	public const string SP_NAME = "WSP_S_CMN_CTE_웹지역_다중선택";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// IDXS
		/// </summary>
		[Description("IDXS")]
		public string IDXS { get; set; }
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
		/// LEVEL
		/// </summary>
		[Column("LEVEL")]
		public int LEVEL { get; set; }
		/// <summary>
		/// 숨김
		/// </summary>
		[Column("숨김")]
		public string Hide { get; set; }
		/// <summary>
		/// 출발지
		/// </summary>
		[Column("출발지")]
		public string Departures { get; set; }
		/// <summary>
		/// SORT
		/// </summary>
		[Column("SORT")]
		public string SORT { get; set; }
	}
}