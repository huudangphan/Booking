namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_T_보험_저장
/// </summary>
public class WSP_T_Insurance_Saving
{
	public const string SP_NAME = "WSP_T_보험_저장";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 순서
		/// </summary>
		[Description("순서")]
		public byte Order { get; set; }
		/// <summary>
		/// 보험사
		/// </summary>
		[Description("보험사")]
		public string InsuranceCompany { get; set; }
		/// <summary>
		/// 접수일
		/// </summary>
		[Description("접수일")]
		public string ReceiptDate { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Description("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 피보험자
		/// </summary>
		[Description("피보험자")]
		public string InsuredInsurancePerson { get; set; }
		/// <summary>
		/// 예약번호
		/// </summary>
		[Description("예약번호")]
		public int BookingNumber { get; set; }
		/// <summary>
		/// 주민번호
		/// </summary>
		[Description("주민번호")]
		public string CitizenIDNumber { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Description("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 연락처
		/// </summary>
		[Description("연락처")]
		public string Contact { get; set; }
		/// <summary>
		/// 사고일
		/// </summary>
		[Description("사고일")]
		public string AccidentDate { get; set; }
		/// <summary>
		/// 사고유형
		/// </summary>
		[Description("사고유형")]
		public string AccidentType { get; set; }
		/// <summary>
		/// 유형
		/// </summary>
		[Description("유형")]
		public string Type { get; set; }
		/// <summary>
		/// 영업담당자
		/// </summary>
		[Description("영업담당자")]
		public string BusinessManager { get; set; }
		/// <summary>
		/// 보상완료
		/// </summary>
		[Description("보상완료")]
		public string CompensationFinish { get; set; }
		/// <summary>
		/// 보완서류
		/// </summary>
		[Description("보완서류")]
		public string SupplementDocument { get; set; }
		/// <summary>
		/// 비고
		/// </summary>
		[Description("비고")]
		public string Note { get; set; }
		/// <summary>
		/// 보상일
		/// </summary>
		[Description("보상일")]
		public string CompensationDate { get; set; }
		/// <summary>
		/// 보험금
		/// </summary>
		[Description("보험금")]
		public int InsuranceMoney { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 등록직원
		/// </summary>
		[Description("등록직원")]
		public int RegisterEmployee { get; set; }
	}

}