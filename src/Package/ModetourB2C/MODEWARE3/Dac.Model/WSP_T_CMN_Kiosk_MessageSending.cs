namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_키오스크_문자발송
/// </summary>
public class WSP_T_CMN_Kiosk_MessageSending
{
	public const string SP_NAME = "WSP_T_CMN_키오스크_문자발송";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 기기번호
		/// </summary>
		[Description("기기번호")]
		public int EquipmentNumber { get; set; }
		/// <summary>
		/// 특선상품번호
		/// </summary>
		[Description("특선상품번호")]
		public int SpecialSelectionProductNumber { get; set; }
		/// <summary>
		/// 연락처
		/// </summary>
		[Description("연락처")]
		public string Contact { get; set; }
		/// <summary>
		/// 비고
		/// </summary>
		[Description("비고")]
		public string Note { get; set; }
		/// <summary>
		/// RCODE
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 4)]
		[Description("RCODE")]
		public string RCODE { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("일련번호")]
		public int SerialNumber { get; set; }
	}

}