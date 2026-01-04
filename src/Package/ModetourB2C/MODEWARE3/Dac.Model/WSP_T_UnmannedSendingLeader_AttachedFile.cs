namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_무인센딩인솔자_첨부파일
/// </summary>
public class WSP_T_UnmannedSendingLeader_AttachedFile
{
	public const string SP_NAME = "WSP_T_무인센딩인솔자_첨부파일";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 파일명
		/// </summary>
		[Description("파일명")]
		public string FileName { get; set; }
		/// <summary>
		/// 이슈일련번호
		/// </summary>
		[Description("이슈일련번호")]
		public int IssueSerialNumber { get; set; }
	}

}