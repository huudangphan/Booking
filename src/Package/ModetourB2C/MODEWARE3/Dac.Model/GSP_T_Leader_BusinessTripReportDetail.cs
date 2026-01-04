namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// GSP_T_인솔자_출장보고세부
/// </summary>
public class GSP_T_Leader_BusinessTripReportDetail
{
	public const string SP_NAME = "GSP_T_인솔자_출장보고세부";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 도시번호
		/// </summary>
		[Description("도시번호")]
		public int CityNumber { get; set; }
		/// <summary>
		/// 항목분류
		/// </summary>
		[Description("항목분류")]
		public string ItemClassification { get; set; }
		/// <summary>
		/// PLID
		/// </summary>
		[Description("PLID")]
		public int PLID { get; set; }
		/// <summary>
		/// 만족도
		/// </summary>
		[Description("만족도")]
		public int SatisfactionRate { get; set; }
		/// <summary>
		/// 코멘트
		/// </summary>
		[Description("코멘트")]
		public string Comment { get; set; }
		/// <summary>
		/// 항목세부1
		/// </summary>
		[Description("항목세부1")]
		public string ItemDetail1 { get; set; }
		/// <summary>
		/// 항목세부2
		/// </summary>
		[Description("항목세부2")]
		public string ItemDetail2 { get; set; }
		/// <summary>
		/// 항목세부3
		/// </summary>
		[Description("항목세부3")]
		public string ItemDetail3 { get; set; }
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