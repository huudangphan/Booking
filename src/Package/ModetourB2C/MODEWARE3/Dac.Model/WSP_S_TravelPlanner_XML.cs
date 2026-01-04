namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_여행플래너_XML
/// </summary>
public class WSP_S_TravelPlanner_XML
{
	public const string SP_NAME = "WSP_S_여행플래너_XML";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처직원번호
		/// </summary>
		[Description("거래처직원번호")]
		public int CustomerEmployeeNumber { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public int Column1 { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 담당자
		/// </summary>
		[Column("담당자")]
		public string Manager { get; set; }
		/// <summary>
		/// AGENTCODE
		/// </summary>
		[Column("AGENTCODE")]
		public int AGENTCODE { get; set; }
		/// <summary>
		/// AGENTNUM
		/// </summary>
		[Column("AGENTNUM")]
		public int AGENTNUM { get; set; }
		/// <summary>
		/// SERVERIP
		/// </summary>
		[Column("SERVERIP")]
		public string SERVERIP { get; set; }
		/// <summary>
		/// NEWID
		/// </summary>
		[Column("NEWID")]
		public string NEWID { get; set; }
	}
}