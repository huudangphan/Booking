namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_회사소개_후기게시판_파일쓰기
/// </summary>
public class WSP_T_CompanyIntroduction_ReviewNoticeboard_FileWritting
{
	public const string SP_NAME = "WSP_T_회사소개_후기게시판_파일쓰기";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 작업모드
		/// </summary>
		[Description("작업모드")]
		public string WorkingMode { get; set; }
		/// <summary>
		/// 후기일련번호
		/// </summary>
		[Description("후기일련번호")]
		public int ReviewSerialNumber { get; set; }
		/// <summary>
		/// 파일일련번호
		/// </summary>
		[Description("파일일련번호")]
		public int FileSerialNumber { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public int Classification { get; set; }
		/// <summary>
		/// 파일명
		/// </summary>
		[Description("파일명")]
		public string FileName { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 파일명
		/// </summary>
		[Column("파일명")]
		public string FileName { get; set; }
	}
}