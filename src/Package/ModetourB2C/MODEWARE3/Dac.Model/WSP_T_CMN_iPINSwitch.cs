namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_아이핀전환
/// </summary>
public class WSP_T_CMN_iPINSwitch
{
	public const string SP_NAME = "WSP_T_CMN_아이핀전환";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 회원명
		/// </summary>
		[Description("회원명")]
		public string MemberName { get; set; }
		/// <summary>
		/// DI
		/// </summary>
		[Description("DI")]
		public string DI { get; set; }
		/// <summary>
		/// 주민번호
		/// </summary>
		[Description("주민번호")]
		public string CitizenIDNumber { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Description("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 외국인
		/// </summary>
		[Description("외국인")]
		public string Foreigner { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 10)]
		[Description("결과")]
		public string Result { get; set; }
	}

}