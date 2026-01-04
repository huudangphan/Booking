namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_인센티브_견적상세_답변
/// </summary>
public class WSP_S_CMN_Incentive_EstimateDetail_Answer
{
	public const string SP_NAME = "WSP_S_CMN_인센티브_견적상세_답변";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// TYPE
		/// </summary>
		[Description("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// CODE
		/// </summary>
		[Description("CODE")]
		public string CODE { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Description("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Description("내용")]
		public string Content { get; set; }
		/// <summary>
		/// IDX
		/// </summary>
		[Description("IDX")]
		public int IDX { get; set; }
		/// <summary>
		/// MASTERIDX
		/// </summary>
		[Description("MASTERIDX")]
		public int MASTERIDX { get; set; }
		/// <summary>
		/// ERRORSTATE
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("ERRORSTATE")]
		public int ERRORSTATE { get; set; }
		/// <summary>
		/// 답글일련번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("답글일련번호")]
		public int ReplySerialNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// IDX
		/// </summary>
		[Column("IDX")]
		public int IDX { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 마스터IDX
		/// </summary>
		[Column("마스터IDX")]
		public int Master_IDX { get; set; }
		/// <summary>
		/// CODE
		/// </summary>
		[Column("CODE")]
		public string CODE { get; set; }
	}
}