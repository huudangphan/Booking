namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_게시판자동저장
/// </summary>
public class WSP_S_CMN_NoticeboardAutoSaving
{
	public const string SP_NAME = "WSP_S_CMN_게시판자동저장";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 아이디
		/// </summary>
		[Description("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 테이블명
		/// </summary>
		[Description("테이블명")]
		public string TableName { get; set; }
		/// <summary>
		/// 게시판구분
		/// </summary>
		[Description("게시판구분")]
		public int NoticeboardClassification { get; set; }
	}

	public class Result : IDbResult
	{
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
	}
}