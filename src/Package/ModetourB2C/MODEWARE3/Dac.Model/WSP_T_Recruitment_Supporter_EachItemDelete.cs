namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_채용_지원자_항목별삭제
/// </summary>
public class WSP_T_Recruitment_Supporter_EachItemDelete
{
	public const string SP_NAME = "WSP_T_채용_지원자_항목별삭제";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 항목
		/// </summary>
		[Description("항목")]
		public string Item { get; set; }
		/// <summary>
		/// 지원자일련번호
		/// </summary>
		[Description("지원자일련번호")]
		public int SupporterSerialNumber { get; set; }
	}

}