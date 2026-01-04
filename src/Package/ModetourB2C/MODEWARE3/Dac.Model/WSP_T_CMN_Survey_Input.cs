namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_설문조사_입력
/// </summary>
public class WSP_T_CMN_Survey_Input
{
	public const string SP_NAME = "WSP_T_CMN_설문조사_입력";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 조건일련번호
		/// </summary>
		[Description("조건일련번호")]
		public int ConditionSerialNumber { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Description("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 설문자
		/// </summary>
		[Description("설문자")]
		public int Surveyor { get; set; }
		/// <summary>
		/// 항목코드
		/// </summary>
		[Description("항목코드")]
		public string ItemCode { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 10)]
		[Description("결과")]
		public string Result { get; set; }
	}

}