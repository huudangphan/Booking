namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_BTMS_견적명단
/// </summary>
public class WSP_T_CMN_BTMS_EstimateNameList
{
	public const string SP_NAME = "WSP_T_CMN_BTMS_견적명단";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 명단번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("명단번호")]
		public int NameListNumber { get; set; }
		/// <summary>
		/// 세부번호
		/// </summary>
		[Description("세부번호")]
		public int DetailNumber { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Description("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 영문성
		/// </summary>
		[Description("영문성")]
		public string EnglishLastName { get; set; }
		/// <summary>
		/// 영문이름
		/// </summary>
		[Description("영문이름")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Description("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Description("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 생년월일
		/// </summary>
		[Description("생년월일")]
		public string BirthYearMonthDay { get; set; }
		/// <summary>
		/// 부서명
		/// </summary>
		[Description("부서명")]
		public string DepartmentName { get; set; }
		/// <summary>
		/// 직급
		/// </summary>
		[Description("직급")]
		public string JobPosition { get; set; }
		/// <summary>
		/// 탑승객정보
		/// </summary>
		[Description("탑승객정보")]
		public string PassengerInfo { get; set; }
		/// <summary>
		/// 수령주소
		/// </summary>
		[Description("수령주소")]
		public string ReceiptAddress { get; set; }
		/// <summary>
		/// 우편번호
		/// </summary>
		[Description("우편번호")]
		public string ZipCode { get; set; }
		/// <summary>
		/// 객실번호
		/// </summary>
		[Description("객실번호")]
		public int GuestRoomNumber { get; set; }
		/// <summary>
		/// 휴대전화
		/// </summary>
		[Description("휴대전화")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 회원번호
		/// </summary>
		[Description("회원번호")]
		public int MemberNumber { get; set; }
	}

}