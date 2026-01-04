namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// UP_결재문서_첨부파일_MOBILE
/// </summary>
public class UP_ApprovalDocument_AttachedFile_MOBILE
{
	public const string SP_NAME = "UP_결재문서_첨부파일_MOBILE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 문서코드
		/// </summary>
		[Description("문서코드")]
		public int DocumentCode { get; set; }
		/// <summary>
		/// 순서
		/// </summary>
		[Description("순서")]
		public int Order { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 파일
		/// </summary>
		[Column("파일")]
		public string File { get; set; }
	}
}