namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_SO_거래처_인센티브_메모
/// </summary>
public class WSP_SO_Customer_Incentive_Memo
{
	public const string SP_NAME = "WSP_SO_거래처_인센티브_메모";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 마스터일련번호
		/// </summary>
		[Description("마스터일련번호")]
		public int MasterSerialNumber { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Description("작성자")]
		public int Writter { get; set; }
		/// <summary>
		/// 메모내용
		/// </summary>
		[Description("메모내용")]
		public string MemoContent { get; set; }
		/// <summary>
		/// CRUD
		/// </summary>
		[Description("CRUD")]
		public string CRUD { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 메모일련번호
		/// </summary>
		[Column("메모일련번호")]
		public int MemoSerialNumber { get; set; }
		/// <summary>
		/// 마스터일련번호
		/// </summary>
		[Column("마스터일련번호")]
		public int MasterSerialNumber { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 메모내용
		/// </summary>
		[Column("메모내용")]
		public string MemoContent { get; set; }
		/// <summary>
		/// 작성자구분
		/// </summary>
		[Column("작성자구분")]
		public string WritterClassification { get; set; }
		/// <summary>
		/// 작성일
		/// </summary>
		[Column("작성일")]
		public string WrittingDate { get; set; }
	}
}