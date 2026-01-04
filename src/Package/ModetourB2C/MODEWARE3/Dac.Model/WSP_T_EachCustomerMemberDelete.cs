namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_거래처별회원삭제
/// </summary>
public class WSP_T_EachCustomerMemberDelete
{
	public const string SP_NAME = "WSP_T_거래처별회원삭제";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 사이트거래처코드
		/// </summary>
		[Description("사이트거래처코드")]
		public int SiteCustomerCode { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Description("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 탈퇴사유
		/// </summary>
		[Description("탈퇴사유")]
		public string CancelReason { get; set; }
		/// <summary>
		/// RETURN
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 200)]
		[Description("RETURN")]
		public string RETURN { get; set; }
	}

}