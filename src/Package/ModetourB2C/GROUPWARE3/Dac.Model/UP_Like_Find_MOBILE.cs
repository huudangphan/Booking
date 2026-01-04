namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// UP_좋아요_조회_MOBILE
/// </summary>
public class UP_Like_Find_MOBILE
{
	public const string SP_NAME = "UP_좋아요_조회_MOBILE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 게시판번호
		/// </summary>
		[Description("게시판번호")]
		public int NoticeboardNumber { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 좋아요수
		/// </summary>
		[Column("좋아요수")]
		public int LikeNumber { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Column("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 게시판테이블명
		/// </summary>
		[Column("게시판테이블명")]
		public string NoticeboardTableName { get; set; }
		/// <summary>
		/// 게시판번호
		/// </summary>
		[Column("게시판번호")]
		public int NoticeboardNumber { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// profile_image
		/// </summary>
		[Column("profile_image")]
		public string profile_image { get; set; }
		/// <summary>
		/// PTKNAME
		/// </summary>
		[Column("PTKNAME")]
		public string PTKNAME { get; set; }
	}
}