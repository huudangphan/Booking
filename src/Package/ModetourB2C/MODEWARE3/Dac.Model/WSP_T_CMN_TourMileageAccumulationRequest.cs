namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_투어마일리지적립요청
/// </summary>
public class WSP_T_CMN_TourMileageAccumulationRequest
{
	public const string SP_NAME = "WSP_T_CMN_투어마일리지적립요청";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Description("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// MT번호
		/// </summary>
		[Description("MT번호")]
		public string MT_Number { get; set; }
		/// <summary>
		/// 회원구분
		/// </summary>
		[Description("회원구분")]
		public string MemberClassification { get; set; }
		/// <summary>
		/// 마일리지적립요청
		/// </summary>
		[Description("마일리지적립요청")]
		public string MileageAccumulationRequest { get; set; }
		/// <summary>
		/// MSGCODE
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 2)]
		[Description("MSGCODE")]
		public string MSGCODE { get; set; }
		/// <summary>
		/// MSG
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 100)]
		[Description("MSG")]
		public string MSG { get; set; }
	}

}