namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_무인센딩인솔자_프로필이미지
/// </summary>
public class WSP_S_UnmannedSendingLeader_ProfileImage
{
	public const string SP_NAME = "WSP_S_무인센딩인솔자_프로필이미지";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 이미지파일명
		/// </summary>
		[Column("이미지파일명")]
		public string ImageFileName { get; set; }
	}
}