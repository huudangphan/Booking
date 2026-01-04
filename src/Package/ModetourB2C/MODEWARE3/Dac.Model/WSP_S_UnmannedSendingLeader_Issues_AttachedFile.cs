namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_무인센딩인솔자_이슈사항_첨부파일
/// </summary>
public class WSP_S_UnmannedSendingLeader_Issues_AttachedFile
{
	public const string SP_NAME = "WSP_S_무인센딩인솔자_이슈사항_첨부파일";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 이슈일련번호
		/// </summary>
		[Description("이슈일련번호")]
		public int IssueSerialNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 첨부파일일련번호
		/// </summary>
		[Column("첨부파일일련번호")]
		public int AttachFileSerialNumber { get; set; }
		/// <summary>
		/// 이슈일련번호
		/// </summary>
		[Column("이슈일련번호")]
		public int IssueSerialNumber { get; set; }
		/// <summary>
		/// 첨부파일명
		/// </summary>
		[Column("첨부파일명")]
		public string AttachFileName { get; set; }
	}
}