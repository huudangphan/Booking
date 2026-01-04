namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_회사소개_견학신청_내용보기
/// </summary>
public class WSP_S_CompanyIntroduction_FieldTripRequest_ContentSeeing
{
	public const string SP_NAME = "WSP_S_회사소개_견학신청_내용보기";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 사용자구분
		/// </summary>
		[Description("사용자구분")]
		public string UserClassification { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
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
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 견학일련번호
		/// </summary>
		[Column("견학일련번호")]
		public int FieldtripSerialNumber { get; set; }
		/// <summary>
		/// 단체구분
		/// </summary>
		[Column("단체구분")]
		public string GroupClassification { get; set; }
		/// <summary>
		/// 견학일
		/// </summary>
		[Column("견학일")]
		public DateTime FieldtripDate { get; set; }
		/// <summary>
		/// 단체이름
		/// </summary>
		[Column("단체이름")]
		public string GroupName { get; set; }
		/// <summary>
		/// 학과명
		/// </summary>
		[Column("학과명")]
		public string MajorDepartmentName { get; set; }
		/// <summary>
		/// 교수명
		/// </summary>
		[Column("교수명")]
		public string ProfessorName { get; set; }
		/// <summary>
		/// 방문인원
		/// </summary>
		[Column("방문인원")]
		public int VisitNumberOfPeople { get; set; }
		/// <summary>
		/// 인솔자성명
		/// </summary>
		[Column("인솔자성명")]
		public string LeaderName { get; set; }
		/// <summary>
		/// 인솔자연락처
		/// </summary>
		[Column("인솔자연락처")]
		public string LeaderContact { get; set; }
		/// <summary>
		/// 주소
		/// </summary>
		[Column("주소")]
		public string Address { get; set; }
		/// <summary>
		/// 신청자이메일
		/// </summary>
		[Column("신청자이메일")]
		public string RequesterEmail { get; set; }
		/// <summary>
		/// 신청자성명
		/// </summary>
		[Column("신청자성명")]
		public string RequesterName { get; set; }
		/// <summary>
		/// 신청자전화번호
		/// </summary>
		[Column("신청자전화번호")]
		public string RequesterPhoneNumber { get; set; }
		/// <summary>
		/// 팩스
		/// </summary>
		[Column("팩스")]
		public string Fax { get; set; }
		/// <summary>
		/// 특이사항
		/// </summary>
		[Column("특이사항")]
		public string Specific { get; set; }
		/// <summary>
		/// 아이피
		/// </summary>
		[Column("아이피")]
		public string IP { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 상태
		/// </summary>
		[Column("상태")]
		public string State { get; set; }
		/// <summary>
		/// 수정일
		/// </summary>
		[Column("수정일")]
		public DateTime EditionDate { get; set; }
		/// <summary>
		/// 견학장소
		/// </summary>
		[Column("견학장소")]
		public string FieldtripPlace { get; set; }
		/// <summary>
		/// 방문목적
		/// </summary>
		[Column("방문목적")]
		public string VisitPurpose { get; set; }
		/// <summary>
		/// ENC_인솔자연락처
		/// </summary>
		[Column("ENC_인솔자연락처")]
		public byte[] ENC_LeaderContact { get; set; }
		/// <summary>
		/// ENC_신청자전화번호
		/// </summary>
		[Column("ENC_신청자전화번호")]
		public byte[] ENC_RequesterPhoneNumber { get; set; }
		/// <summary>
		/// ENC_신청자이메일
		/// </summary>
		[Column("ENC_신청자이메일")]
		public byte[] ENC_RequesterEmail { get; set; }
	}
}