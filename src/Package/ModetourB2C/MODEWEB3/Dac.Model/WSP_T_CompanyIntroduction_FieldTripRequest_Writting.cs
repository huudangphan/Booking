namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_회사소개_견학신청_쓰기
/// </summary>
public class WSP_T_CompanyIntroduction_FieldTripRequest_Writting
{
	public const string SP_NAME = "WSP_T_회사소개_견학신청_쓰기";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 사용자구분
		/// </summary>
		[Description("사용자구분")]
		public string UserClassification { get; set; }
		/// <summary>
		/// 작업모드
		/// </summary>
		[Description("작업모드")]
		public string WorkingMode { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 단체구분
		/// </summary>
		[Description("단체구분")]
		public string GroupClassification { get; set; }
		/// <summary>
		/// 견학일
		/// </summary>
		[Description("견학일")]
		public DateTime FieldtripDate { get; set; }
		/// <summary>
		/// 견학장소
		/// </summary>
		[Description("견학장소")]
		public string FieldtripPlace { get; set; }
		/// <summary>
		/// 단체이름
		/// </summary>
		[Description("단체이름")]
		public string GroupName { get; set; }
		/// <summary>
		/// 학과명
		/// </summary>
		[Description("학과명")]
		public string MajorDepartmentName { get; set; }
		/// <summary>
		/// 교수명
		/// </summary>
		[Description("교수명")]
		public string ProfessorName { get; set; }
		/// <summary>
		/// 방문인원
		/// </summary>
		[Description("방문인원")]
		public int VisitNumberOfPeople { get; set; }
		/// <summary>
		/// 방문목적
		/// </summary>
		[Description("방문목적")]
		public string VisitPurpose { get; set; }
		/// <summary>
		/// 인솔자성명
		/// </summary>
		[Description("인솔자성명")]
		public string LeaderName { get; set; }
		/// <summary>
		/// 인솔자연락처
		/// </summary>
		[Description("인솔자연락처")]
		public string LeaderContact { get; set; }
		/// <summary>
		/// 주소
		/// </summary>
		[Description("주소")]
		public string Address { get; set; }
		/// <summary>
		/// 신청자이메일
		/// </summary>
		[Description("신청자이메일")]
		public string RequesterEmail { get; set; }
		/// <summary>
		/// 신청자성명
		/// </summary>
		[Description("신청자성명")]
		public string RequesterName { get; set; }
		/// <summary>
		/// 신청자전화번호
		/// </summary>
		[Description("신청자전화번호")]
		public string RequesterPhoneNumber { get; set; }
		/// <summary>
		/// 팩스
		/// </summary>
		[Description("팩스")]
		public string Fax { get; set; }
		/// <summary>
		/// 특이사항
		/// </summary>
		[Description("특이사항")]
		public string Specific { get; set; }
		/// <summary>
		/// 아이피
		/// </summary>
		[Description("아이피")]
		public string IP { get; set; }
		/// <summary>
		/// 상태
		/// </summary>
		[Description("상태")]
		public string State { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 결과코드
		/// </summary>
		[Column("결과코드")]
		public string ResultCode { get; set; }
		/// <summary>
		/// 결과메세지
		/// </summary>
		[Column("결과메세지")]
		public string ResultMessage { get; set; }
	}
}