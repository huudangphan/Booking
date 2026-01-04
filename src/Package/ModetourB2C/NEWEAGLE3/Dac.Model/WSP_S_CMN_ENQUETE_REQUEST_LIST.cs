namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_ENQUETE_REQUEST_LIST
/// </summary>
public class WSP_S_CMN_ENQUETE_REQUEST_LIST
{
	public const string SP_NAME = "WSP_S_CMN_ENQUETE_REQUEST_LIST";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// EventNo
		/// </summary>
		[Description("EventNo")]
		public int EventNo { get; set; }
		/// <summary>
		/// Idx
		/// </summary>
		[Description("Idx")]
		public int Idx { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 이벤트번호
		/// </summary>
		[Column("이벤트번호")]
		public int EventNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 이벤트번호
		/// </summary>
		[Column("이벤트번호")]
		public int EventNumber { get; set; }
		/// <summary>
		/// 앙케이트_신청자_일련번호
		/// </summary>
		[Column("앙케이트_신청자_일련번호")]
		public int Enquete_Requester_SerialNumber { get; set; }
		/// <summary>
		/// 앙케이트_질문_일련번호
		/// </summary>
		[Column("앙케이트_질문_일련번호")]
		public int Enquete_Question_SerialNumber { get; set; }
		/// <summary>
		/// 선택항목
		/// </summary>
		[Column("선택항목")]
		public string SelectItem { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
	}
}