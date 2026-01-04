namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// UP_기안금액_조회
/// </summary>
public class UP_DraftAmount_Find
{
	public const string SP_NAME = "UP_기안금액_조회";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 문서코드
		/// </summary>
		[Description("문서코드")]
		public int DocumentCode { get; set; }
		/// <summary>
		/// 근거기안코드
		/// </summary>
		[Description("근거기안코드")]
		public int EvidenceDraftCode { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 총금액
		/// </summary>
		[Column("총금액")]
		public int TotalAmount { get; set; }
		/// <summary>
		/// 지출금액
		/// </summary>
		[Column("지출금액")]
		public int SpendingAmount { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 기안일
		/// </summary>
		[Column("기안일")]
		public DateTime DraftDate { get; set; }
	}
}