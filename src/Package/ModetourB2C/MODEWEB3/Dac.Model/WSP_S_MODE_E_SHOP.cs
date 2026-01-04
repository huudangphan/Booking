namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_MODE_E_SHOP
/// </summary>
public class WSP_S_MODE_E_SHOP
{
	public const string SP_NAME = "WSP_S_MODE_E_SHOP";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Description("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 사이트주소
		/// </summary>
		[Description("사이트주소")]
		public string SiteAddress { get; set; }
		/// <summary>
		/// 아이피
		/// </summary>
		[Description("아이피")]
		public string IP { get; set; }
		/// <summary>
		/// 정보제공동의
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("정보제공동의")]
		public string InfoProvisionAgree { get; set; }
		/// <summary>
		/// 회원등급
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("회원등급")]
		public string MemberClass { get; set; }
		/// <summary>
		/// 주민번호
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 13)]
		[Description("주민번호")]
		public string CitizenIDNumber { get; set; }
		/// <summary>
		/// 부서명
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 100)]
		[Description("부서명")]
		public string DepartmentName { get; set; }
	}

}