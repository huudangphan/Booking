namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_키오스크_체크_ADD
/// </summary>
public class WSP_T_CMN_Kiosk_Check_ADD
{
	public const string SP_NAME = "WSP_T_CMN_키오스크_체크_ADD";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 기기번호
		/// </summary>
		[Description("기기번호")]
		public int EquipmentNumber { get; set; }
		/// <summary>
		/// RCODE
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 4)]
		[Description("RCODE")]
		public string RCODE { get; set; }
		/// <summary>
		/// 반영일
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 14)]
		[Description("반영일")]
		public string ReflectDate { get; set; }
	}

}