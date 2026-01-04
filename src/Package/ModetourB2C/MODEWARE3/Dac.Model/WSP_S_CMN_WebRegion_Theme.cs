namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_웹지역_테마
/// </summary>
public class WSP_S_CMN_WebRegion_Theme
{
	public const string SP_NAME = "WSP_S_CMN_웹지역_테마";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// Gubun
		/// </summary>
		[Description("Gubun")]
		public string Gubun { get; set; }
		/// <summary>
		/// StartArea
		/// </summary>
		[Description("StartArea")]
		public string StartArea { get; set; }
		/// <summary>
		/// IDX
		/// </summary>
		[Description("IDX")]
		public int IDX { get; set; }
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
		/// 출발지
		/// </summary>
		[Column("출발지")]
		public string Departures { get; set; }
		/// <summary>
		/// SORT
		/// </summary>
		[Column("SORT")]
		public string SORT { get; set; }
		/// <summary>
		/// 경로
		/// </summary>
		[Column("경로")]
		public string Route { get; set; }
	}
}