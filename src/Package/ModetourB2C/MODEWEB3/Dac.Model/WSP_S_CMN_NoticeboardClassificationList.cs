namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_게시판구분리스트
/// </summary>
public class WSP_S_CMN_NoticeboardClassificationList
{
	public const string SP_NAME = "WSP_S_CMN_게시판구분리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 테이블명
		/// </summary>
		[Description("테이블명")]
		public string TableName { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public int Classification { get; set; }
		/// <summary>
		/// 게시판명
		/// </summary>
		[Column("게시판명")]
		public string NoticeboardName { get; set; }
		/// <summary>
		/// 테이블명
		/// </summary>
		[Column("테이블명")]
		public string TableName { get; set; }
		/// <summary>
		/// 스킨명1
		/// </summary>
		[Column("스킨명1")]
		public string SkinName1 { get; set; }
		/// <summary>
		/// 스킨명2
		/// </summary>
		[Column("스킨명2")]
		public string SkinName2 { get; set; }
		/// <summary>
		/// 스킨명3
		/// </summary>
		[Column("스킨명3")]
		public string SkinName3 { get; set; }
		/// <summary>
		/// 스킨명4
		/// </summary>
		[Column("스킨명4")]
		public string SkinName4 { get; set; }
		/// <summary>
		/// 스킨명5
		/// </summary>
		[Column("스킨명5")]
		public string SkinName5 { get; set; }
		/// <summary>
		/// 생성일
		/// </summary>
		[Column("생성일")]
		public DateTime CreationDate { get; set; }
	}
}