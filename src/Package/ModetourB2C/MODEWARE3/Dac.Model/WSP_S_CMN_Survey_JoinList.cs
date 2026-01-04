namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_설문조사_참여리스트
/// </summary>
public class WSP_S_CMN_Survey_JoinList
{
	public const string SP_NAME = "WSP_S_CMN_설문조사_참여리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 설문일련번호
		/// </summary>
		[Description("설문일련번호")]
		public int SurveySerialNumber { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Description("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 조건일련번호
		/// </summary>
		[Column("조건일련번호")]
		public int ConditionSerialNumber { get; set; }
		/// <summary>
		/// 선정자
		/// </summary>
		[Column("선정자")]
		public int Selecter { get; set; }
		/// <summary>
		/// 설문자
		/// </summary>
		[Column("설문자")]
		public int Surveyor { get; set; }
		/// <summary>
		/// 선정시간
		/// </summary>
		[Column("선정시간")]
		public DateTime SelectionTime { get; set; }
		/// <summary>
		/// 항목코드
		/// </summary>
		[Column("항목코드")]
		public string ItemCode { get; set; }
		/// <summary>
		/// 의견및건의사항
		/// </summary>
		[Column("의견및건의사항")]
		public string OpinionAndRecommendation { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Column("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
	}
}