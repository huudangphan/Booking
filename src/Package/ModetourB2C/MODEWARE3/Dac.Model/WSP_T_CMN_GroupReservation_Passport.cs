namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_단체예약_여권
/// </summary>
public class WSP_T_CMN_GroupReservation_Passport
{
	public const string SP_NAME = "WSP_T_CMN_단체예약_여권";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Description("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 여권파일명
		/// </summary>
		[Description("여권파일명")]
		public string PassportFileName { get; set; }
		/// <summary>
		/// 여권파일명_뒷면
		/// </summary>
		[Description("여권파일명_뒷면")]
		public string PassportFileName_Backside { get; set; }
		/// <summary>
		/// 암호화여부
		/// </summary>
		[Description("암호화여부")]
		public string EncrypeOrNot { get; set; }
	}

}