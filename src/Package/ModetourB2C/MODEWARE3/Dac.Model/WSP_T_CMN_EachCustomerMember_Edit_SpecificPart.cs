namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_거래처별회원_수정_특정부분
/// </summary>
public class WSP_T_CMN_EachCustomerMember_Edit_SpecificPart
{
	public const string SP_NAME = "WSP_T_CMN_거래처별회원_수정_특정부분";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.String, ParameterDirection.InputOutput, 20)]
		[Description("결과")]
		public string Result { get; set; }
		/// <summary>
		/// 메일수신여부
		/// </summary>
		[Description("메일수신여부")]
		public string MailReceptionOrNot { get; set; }
	}

}