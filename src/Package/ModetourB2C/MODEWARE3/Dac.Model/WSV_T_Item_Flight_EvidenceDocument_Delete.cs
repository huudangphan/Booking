namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSV_T_아이템_항공_증빙서류_삭제
/// </summary>
public class WSV_T_Item_Flight_EvidenceDocument_Delete
{
	public const string SP_NAME = "WSV_T_아이템_항공_증빙서류_삭제";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 증빙서류번호
		/// </summary>
		[Description("증빙서류번호")]
		public int EvidenceDocumentNumber { get; set; }
		/// <summary>
		/// 제출방법
		/// </summary>
		[Description("제출방법")]
		public string SubmitWay { get; set; }
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