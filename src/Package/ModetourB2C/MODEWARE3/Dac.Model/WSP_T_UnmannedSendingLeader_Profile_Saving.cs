namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_무인센딩인솔자_프로필_저장
/// </summary>
public class WSP_T_UnmannedSendingLeader_Profile_Saving
{
	public const string SP_NAME = "WSP_T_무인센딩인솔자_프로필_저장";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 이미지파일명
		/// </summary>
		[Description("이미지파일명")]
		public string ImageFileName { get; set; }
	}

}