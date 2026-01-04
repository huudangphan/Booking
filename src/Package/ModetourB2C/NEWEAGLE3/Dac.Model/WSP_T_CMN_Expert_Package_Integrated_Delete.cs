namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_T_CMN_전문가_패키지_통합_삭제
/// </summary>
public class WSP_T_CMN_Expert_Package_Integrated_Delete
{
	public const string SP_NAME = "WSP_T_CMN_전문가_패키지_통합_삭제";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 메뉴구분
		/// </summary>
		[Description("메뉴구분")]
		public string MenuClassification { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
	}

}