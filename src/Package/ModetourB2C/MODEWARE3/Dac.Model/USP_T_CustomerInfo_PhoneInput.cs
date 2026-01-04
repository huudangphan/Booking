namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_고객정보_휴대폰입력
/// </summary>
public class USP_T_CustomerInfo_PhoneInput
{
	public const string SP_NAME = "USP_T_고객정보_휴대폰입력";

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
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 핸드폰
		/// </summary>
		[Description("핸드폰")]
		public string CellPhone { get; set; }
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