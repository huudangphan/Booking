namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_BTMS_여권
/// </summary>
public class WSP_T_CMN_BTMS_Passport
{
	public const string SP_NAME = "WSP_T_CMN_BTMS_여권";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 여권번호
		/// </summary>
		[Description("여권번호")]
		public string PassportNumber { get; set; }
		/// <summary>
		/// 여권발급일
		/// </summary>
		[Description("여권발급일")]
		public DateTime PassportIssuanceDate { get; set; }
		/// <summary>
		/// 여권만료일
		/// </summary>
		[Description("여권만료일")]
		public DateTime PassportExpirationDate { get; set; }
		/// <summary>
		/// 여권파일번호
		/// </summary>
		[Description("여권파일번호")]
		public int PassportFileNumber { get; set; }
	}

}