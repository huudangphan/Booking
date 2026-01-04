namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// GSP_T_인솔자_출장보고
/// </summary>
public class GSP_T_Leader_BusinessTripReport
{
	public const string SP_NAME = "GSP_T_인솔자_출장보고";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Description("출발일")]
		public DateTime DepartureDate { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Description("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 단체명
		/// </summary>
		[Description("단체명")]
		public string GroupName { get; set; }
		/// <summary>
		/// 코멘트
		/// </summary>
		[Description("코멘트")]
		public string Comment { get; set; }
		/// <summary>
		/// 사건사고
		/// </summary>
		[Description("사건사고")]
		public string Accident { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
		/// <summary>
		/// 에러메시지
		/// </summary>
		[DapperParameter(DbType.String, ParameterDirection.InputOutput, 1000)]
		[Description("에러메시지")]
		public string ErrorMessage { get; set; }
	}

}