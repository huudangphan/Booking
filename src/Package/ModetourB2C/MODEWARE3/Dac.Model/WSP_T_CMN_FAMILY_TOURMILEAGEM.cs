namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_FAMILY_TOURMILEAGEM
/// </summary>
public class WSP_T_CMN_FAMILY_TOURMILEAGEM
{
	public const string SP_NAME = "WSP_T_CMN_FAMILY_TOURMILEAGEM";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 마스터번호
		/// </summary>
		[Description("마스터번호")]
		public int MasterNumber { get; set; }
		/// <summary>
		/// 가족일련번호
		/// </summary>
		[Description("가족일련번호")]
		public int FamilySerialNumber { get; set; }
		/// <summary>
		/// 동의여부
		/// </summary>
		[Description("동의여부")]
		public string AgreeOrNot { get; set; }
	}

}