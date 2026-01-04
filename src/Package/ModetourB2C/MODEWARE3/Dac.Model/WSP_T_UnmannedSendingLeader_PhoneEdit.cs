namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_무인센딩인솔자_휴대폰수정
/// </summary>
public class WSP_T_UnmannedSendingLeader_PhoneEdit
{
	public const string SP_NAME = "WSP_T_무인센딩인솔자_휴대폰수정";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Description("휴대폰")]
		public string CellPhone { get; set; }
	}

}