namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_가족합산_회원_해지
/// </summary>
public class USP_T_TotalFamilyCalculation_Member_Cancellation
{
	public const string SP_NAME = "USP_T_가족합산_회원_해지";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 가족일련번호
		/// </summary>
		[Description("가족일련번호")]
		public int FamilySerialNumber { get; set; }
		/// <summary>
		/// MTNO
		/// </summary>
		[Description("MTNO")]
		public string MTNO { get; set; }
		/// <summary>
		/// 해지작업자
		/// </summary>
		[Description("해지작업자")]
		public int CancelWorker { get; set; }
		/// <summary>
		/// 해지사유
		/// </summary>
		[Description("해지사유")]
		public string CancelReason { get; set; }
	}

}