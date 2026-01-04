namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_설문조사_리스트
/// </summary>
public class WSP_S_CMN_Survey_List
{
	public const string SP_NAME = "WSP_S_CMN_설문조사_리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 설문일련번호
		/// </summary>
		[Description("설문일련번호")]
		public int SurveySerialNumber { get; set; }
		/// <summary>
		/// 사용용도코드
		/// </summary>
		[Description("사용용도코드")]
		public string UsePurposeCode { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 설문일련번호
		/// </summary>
		[Column("설문일련번호")]
		public int SurveySerialNumber { get; set; }
		/// <summary>
		/// 설문문항
		/// </summary>
		[Column("설문문항")]
		public string SurveyQuestion { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Column("등록자")]
		public int Registerer { get; set; }
		/// <summary>
		/// PTKNAME
		/// </summary>
		[Column("PTKNAME")]
		public string PTKNAME { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 노출여부
		/// </summary>
		[Column("노출여부")]
		public string DisplayOrNot { get; set; }
		/// <summary>
		/// 강제마감여부
		/// </summary>
		[Column("강제마감여부")]
		public string ForcedClosingOrNot { get; set; }
		/// <summary>
		/// 설문시작일
		/// </summary>
		[Column("설문시작일")]
		public DateTime SurveyStartDate { get; set; }
		/// <summary>
		/// 설문종료일
		/// </summary>
		[Column("설문종료일")]
		public DateTime SurveyEndDate { get; set; }
		/// <summary>
		/// 사용용도코드
		/// </summary>
		[Column("사용용도코드")]
		public string UsePurposeCode { get; set; }
		/// <summary>
		/// 사용용도
		/// </summary>
		[Column("사용용도")]
		public string UsePurpose { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 조건일련번호
		/// </summary>
		[Column("조건일련번호")]
		public int ConditionSerialNumber { get; set; }
		/// <summary>
		/// 설문명칭
		/// </summary>
		[Column("설문명칭")]
		public string SurveyName { get; set; }
		/// <summary>
		/// 중복허용
		/// </summary>
		[Column("중복허용")]
		public string DuplicatedAllow { get; set; }
		/// <summary>
		/// 피설문항목코드
		/// </summary>
		[Column("피설문항목코드")]
		public string InsuredSurveyItemCode { get; set; }
		/// <summary>
		/// 피설문항목
		/// </summary>
		[Column("피설문항목")]
		public string InsuredSurveyItem { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public int Sorting { get; set; }
	}
}