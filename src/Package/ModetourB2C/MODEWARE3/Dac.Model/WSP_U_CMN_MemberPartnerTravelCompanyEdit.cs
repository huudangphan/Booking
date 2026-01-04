namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_U_CMN_회원파트너여행사수정
/// </summary>
public class WSP_U_CMN_MemberPartnerTravelCompanyEdit
{
	public const string SP_NAME = "WSP_U_CMN_회원파트너여행사수정";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 회원번호
		/// </summary>
		[Description("회원번호")]
		public int MemberNumber { get; set; }
		/// <summary>
		/// 파트너여행사번호
		/// </summary>
		[Description("파트너여행사번호")]
		public int PartnerTravelCompanyNumber { get; set; }
		/// <summary>
		/// 파트너여행사여부
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("파트너여행사여부")]
		public string PartnerTravelCompanyOrNot { get; set; }
	}

}