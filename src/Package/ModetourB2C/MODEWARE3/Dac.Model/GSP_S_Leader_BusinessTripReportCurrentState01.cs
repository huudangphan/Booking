namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// GSP_S_인솔자_출장보고현황01
/// </summary>
public class GSP_S_Leader_BusinessTripReportCurrentState01
{
	public const string SP_NAME = "GSP_S_인솔자_출장보고현황01";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 항목분류
		/// </summary>
		[Column("항목분류")]
		public string ItemClassification { get; set; }
		/// <summary>
		/// 항목분류명
		/// </summary>
		[Column("항목분류명")]
		public string ItemClassificationName { get; set; }
		/// <summary>
		/// 도시번호
		/// </summary>
		[Column("도시번호")]
		public int CityNumber { get; set; }
		/// <summary>
		/// 도시명
		/// </summary>
		[Column("도시명")]
		public string CityName { get; set; }
		/// <summary>
		/// 아이템명
		/// </summary>
		[Column("아이템명")]
		public string ItemName { get; set; }
		/// <summary>
		/// 평점
		/// </summary>
		[Column("평점")]
		public int Rating { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 항목분류
		/// </summary>
		[Column("항목분류")]
		public string ItemClassification { get; set; }
		/// <summary>
		/// 항목분류명
		/// </summary>
		[Column("항목분류명")]
		public string ItemClassificationName { get; set; }
		/// <summary>
		/// 도시명
		/// </summary>
		[Column("도시명")]
		public string CityName { get; set; }
		/// <summary>
		/// 아이템번호
		/// </summary>
		[Column("아이템번호")]
		public int ItemNumber { get; set; }
		/// <summary>
		/// 아이템명
		/// </summary>
		[Column("아이템명")]
		public string ItemName { get; set; }
		/// <summary>
		/// 평점
		/// </summary>
		[Column("평점")]
		public int Rating { get; set; }
	}
}