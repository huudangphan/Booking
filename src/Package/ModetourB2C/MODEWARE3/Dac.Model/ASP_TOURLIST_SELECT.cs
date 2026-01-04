namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// ASP_TOURLIST_SELECT
/// </summary>
public class ASP_TOURLIST_SELECT
{
	public const string SP_NAME = "ASP_TOURLIST_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// OID
		/// </summary>
		[Description("OID")]
		public int OID { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// IP
		/// </summary>
		[Description("IP")]
		public string IP { get; set; }
		/// <summary>
		/// APP
		/// </summary>
		[Description("APP")]
		public string APP { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// SALES_NO
		/// </summary>
		[Column("SALES_NO")]
		public int SALES_NO { get; set; }
		/// <summary>
		/// NAME
		/// </summary>
		[Column("NAME")]
		public string NAME { get; set; }
		/// <summary>
		/// ENAME
		/// </summary>
		[Column("ENAME")]
		public string ENAME { get; set; }
		/// <summary>
		/// CHK_주민번호
		/// </summary>
		[Column("CHK_주민번호")]
		public string CHK_CitizenIDNumber { get; set; }
		/// <summary>
		/// PHONE
		/// </summary>
		[Column("PHONE")]
		public string PHONE { get; set; }
		/// <summary>
		/// EMAIL
		/// </summary>
		[Column("EMAIL")]
		public string EMAIL { get; set; }
		/// <summary>
		/// SEX
		/// </summary>
		[Column("SEX")]
		public string SEX { get; set; }
		/// <summary>
		/// STYPE
		/// </summary>
		[Column("STYPE")]
		public string STYPE { get; set; }
		/// <summary>
		/// STATUS
		/// </summary>
		[Column("STATUS")]
		public string STATUS { get; set; }
		/// <summary>
		/// STATUS_NAME
		/// </summary>
		[Column("STATUS_NAME")]
		public string STATUS_NAME { get; set; }
		/// <summary>
		/// MT_NO
		/// </summary>
		[Column("MT_NO")]
		public string MT_NO { get; set; }
		/// <summary>
		/// 판매가
		/// </summary>
		[Column("판매가")]
		public long SellingPrice { get; set; }
		/// <summary>
		/// 여권유무
		/// </summary>
		[Column("여권유무")]
		public string PassportOrNot { get; set; }
		/// <summary>
		/// 여권번호
		/// </summary>
		[Column("여권번호")]
		public string PassportNumber { get; set; }
		/// <summary>
		/// 여권만료일
		/// </summary>
		[Column("여권만료일")]
		public string PassportExpirationDate { get; set; }
		/// <summary>
		/// 판매일
		/// </summary>
		[Column("판매일")]
		public DateTime SalesDate { get; set; }
		/// <summary>
		/// 개인정보수집동의
		/// </summary>
		[Column("개인정보수집동의")]
		public string PersonalInfoCollectionAgree { get; set; }
		/// <summary>
		/// 개인정보제3자제공동의
		/// </summary>
		[Column("개인정보제3자제공동의")]
		public string PersonalInfo3rdPartyProvisionAgree { get; set; }
		/// <summary>
		/// 개인정보위탁동의
		/// </summary>
		[Column("개인정보위탁동의")]
		public string PersonalInfoConsignAgree { get; set; }
		/// <summary>
		/// 여행계약서확인
		/// </summary>
		[Column("여행계약서확인")]
		public string TravelContractConfirm { get; set; }
		/// <summary>
		/// 개인정보동의확인
		/// </summary>
		[Column("개인정보동의확인")]
		public string PersonalInfoAgreeConfirm { get; set; }
		/// <summary>
		/// 해외여행약관확인
		/// </summary>
		[Column("해외여행약관확인")]
		public string OverseaTravelTermsConfirm { get; set; }
		/// <summary>
		/// 이용기간및보유기간
		/// </summary>
		[Column("이용기간및보유기간")]
		public string UsePeriodAndHoldingPeriod { get; set; }
		/// <summary>
		/// 여권파일명
		/// </summary>
		[Column("여권파일명")]
		public string PassportFileName { get; set; }
		/// <summary>
		/// 여권파일명_뒷면
		/// </summary>
		[Column("여권파일명_뒷면")]
		public string PassportFileName_Backside { get; set; }
		/// <summary>
		/// 여권확인여부
		/// </summary>
		[Column("여권확인여부")]
		public string PassportConfirmOrNot { get; set; }
		/// <summary>
		/// 판매종류
		/// </summary>
		[Column("판매종류")]
		public string SalesType { get; set; }
		/// <summary>
		/// 여행계약서동의날짜
		/// </summary>
		[Column("여행계약서동의날짜")]
		public string TravelContractAgreeDate { get; set; }
		/// <summary>
		/// 개인정보동의날짜
		/// </summary>
		[Column("개인정보동의날짜")]
		public string PersonalInfoAgreeDate { get; set; }
		/// <summary>
		/// 적립예상투어마일리지
		/// </summary>
		[Column("적립예상투어마일리지")]
		public int AccumulationExpectedTourMileage { get; set; }
		/// <summary>
		/// 휴대폰체크
		/// </summary>
		[Column("휴대폰체크")]
		public string PhoneCheck { get; set; }
		/// <summary>
		/// 마일리지적립요청
		/// </summary>
		[Column("마일리지적립요청")]
		public string MileageAccumulationRequest { get; set; }
		/// <summary>
		/// 취소일
		/// </summary>
		[Column("취소일")]
		public DateTime CancelDate { get; set; }
	}
}