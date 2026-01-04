namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_ENQUETE_LIST
/// </summary>
public class WSP_S_CMN_ENQUETE_LIST
{
	public const string SP_NAME = "WSP_S_CMN_ENQUETE_LIST";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// EventNo
		/// </summary>
		[Description("EventNo")]
		public int EventNo { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 질문
		/// </summary>
		[Column("질문")]
		public string Question { get; set; }
		/// <summary>
		/// 중복사용
		/// </summary>
		[Column("중복사용")]
		public string DuplicatedUse { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public int Sorting { get; set; }
		/// <summary>
		/// 사용여부
		/// </summary>
		[Column("사용여부")]
		public string UseOrNot { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 앙케이트_질문_일련번호
		/// </summary>
		[Column("앙케이트_질문_일련번호")]
		public int Enquete_Question_SerialNumber { get; set; }
		/// <summary>
		/// 항목
		/// </summary>
		[Column("항목")]
		public string Item { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public int Sorting { get; set; }
		/// <summary>
		/// 사용여부
		/// </summary>
		[Column("사용여부")]
		public string UseOrNot { get; set; }
	}
}