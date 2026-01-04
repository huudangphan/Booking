namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_이벤트당첨자명단
/// </summary>
public class WSP_S_CMN_EventWinnerNameList
{
	public const string SP_NAME = "WSP_S_CMN_이벤트당첨자명단";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 이벤트번호
		/// </summary>
		[Description("이벤트번호")]
		public int EventNumber { get; set; }
		/// <summary>
		/// 시작일자
		/// </summary>
		[Description("시작일자")]
		public DateTime StartDate { get; set; }
		/// <summary>
		/// 종료일자
		/// </summary>
		[Description("종료일자")]
		public DateTime EndDate { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 번호1
		/// </summary>
		[Column("번호1")]
		public int Number1 { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 상태1
		/// </summary>
		[Column("상태1")]
		public string State1 { get; set; }
	}
}