namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_개인정보동의
/// </summary>
public class WSP_T_PersonalInfoAgree
{
	public const string SP_NAME = "WSP_T_개인정보동의";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Description("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 개인정보_한글이름
		/// </summary>
		[Description("개인정보_한글이름")]
		public string PersonalInfo_KoreanName { get; set; }
		/// <summary>
		/// 개인정보_집전화
		/// </summary>
		[Description("개인정보_집전화")]
		public string PersonalInfo_HomePhoneNumber { get; set; }
		/// <summary>
		/// 개인정보_핸드폰
		/// </summary>
		[Description("개인정보_핸드폰")]
		public string PersonalInfo_Phone { get; set; }
		/// <summary>
		/// 개인정보_집주소
		/// </summary>
		[Description("개인정보_집주소")]
		public string PersonalInfo_HomeAddress { get; set; }
		/// <summary>
		/// 개인정보수집동의
		/// </summary>
		[Description("개인정보수집동의")]
		public string PersonalInfoCollectionAgree { get; set; }
		/// <summary>
		/// 개인정보제3자제공동의
		/// </summary>
		[Description("개인정보제3자제공동의")]
		public string PersonalInfo3rdPartyProvisionAgree { get; set; }
		/// <summary>
		/// 개인정보위탁동의
		/// </summary>
		[Description("개인정보위탁동의")]
		public string PersonalInfoConsignAgree { get; set; }
		/// <summary>
		/// 여행계약서확인
		/// </summary>
		[Description("여행계약서확인")]
		public string TravelContractConfirm { get; set; }
		/// <summary>
		/// 해외여행약관확인
		/// </summary>
		[Description("해외여행약관확인")]
		public string OverseaTravelTermsConfirm { get; set; }
		/// <summary>
		/// 이용기간및보유기간
		/// </summary>
		[Description("이용기간및보유기간")]
		public string UsePeriodAndHoldingPeriod { get; set; }
		/// <summary>
		/// 예약자주민번호
		/// </summary>
		[Description("예약자주민번호")]
		public string BookerCitizenIDNumber { get; set; }
		/// <summary>
		/// 동의서구분
		/// </summary>
		[Description("동의서구분")]
		public string AgreementLetterClassification { get; set; }
	}

}