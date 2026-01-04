namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_복지몰_가족
/// </summary>
public class WSP_T_WelfareMall_Family
{
	public const string SP_NAME = "WSP_T_복지몰_가족";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 임직원PTID
		/// </summary>
		[Description("임직원PTID")]
		public int EmployeePTID { get; set; }
		/// <summary>
		/// 회원유형
		/// </summary>
		[Description("회원유형")]
		public string MemberType { get; set; }
		/// <summary>
		/// 회원관계
		/// </summary>
		[Description("회원관계")]
		public string MemberRelationship { get; set; }
		/// <summary>
		/// RETURN
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 200)]
		[Description("RETURN")]
		public string RETURN { get; set; }
	}

}