namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_고객만족도조사_리스트
/// </summary>
public class WSP_S_CustomerSatisfactionRateSurvey_List
{
	public const string SP_NAME = "WSP_S_고객만족도조사_리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 설문지번호
		/// </summary>
		[Description("설문지번호")]
		public short SurveyorNumber { get; set; }
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
		/// 노출여부
		/// </summary>
		[Column("노출여부")]
		public string DisplayOrNot { get; set; }
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
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public int Sorting { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 조건일련번호
		/// </summary>
		[Column("조건일련번호")]
		public int ConditionSerialNumber { get; set; }
		/// <summary>
		/// 항목코드
		/// </summary>
		[Column("항목코드")]
		public string ItemCode { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
		/// <summary>
		/// 키인필수
		/// </summary>
		[Column("키인필수")]
		public string KeyinRequired { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public int Sorting { get; set; }
	}
}