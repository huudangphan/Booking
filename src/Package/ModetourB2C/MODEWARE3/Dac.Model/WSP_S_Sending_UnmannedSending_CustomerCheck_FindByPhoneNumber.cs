namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_센딩_무인센딩_고객체크_휴대번호로조회
/// </summary>
public class WSP_S_Sending_UnmannedSending_CustomerCheck_FindByPhoneNumber
{
	public const string SP_NAME = "WSP_S_센딩_무인센딩_고객체크_휴대번호로조회";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 출발일
		/// </summary>
		[Description("출발일")]
		public DateTime DepartureDate { get; set; }
		/// <summary>
		/// 장소
		/// </summary>
		[Description("장소")]
		public string Place { get; set; }
		/// <summary>
		/// 장소2
		/// </summary>
		[Description("장소2")]
		public string Place2 { get; set; }
		/// <summary>
		/// 공항
		/// </summary>
		[Description("공항")]
		public string Airport { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Description("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 휴대번호
		/// </summary>
		[Description("휴대번호")]
		public string CellphoneNumber { get; set; }
		/// <summary>
		/// 예약번호
		/// </summary>
		[Description("예약번호")]
		public int BookingNumber { get; set; }
	}

	public class Result : IDbResult
	{
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
		/// <summary>
		/// 계약대표자_판매명세번호
		/// </summary>
		[Column("계약대표자_판매명세번호")]
		public int ContractRepresentativePerson_SalesDetailNumber { get; set; }
		/// <summary>
		/// 여행계약동의일
		/// </summary>
		[Column("여행계약동의일")]
		public DateTime TravelContractAgreementDate { get; set; }
		/// <summary>
		/// 여행계약동의경로
		/// </summary>
		[Column("여행계약동의경로")]
		public string TravelContractAgreementPath { get; set; }
		/// <summary>
		/// 개인정보동의일
		/// </summary>
		[Column("개인정보동의일")]
		public DateTime PersonalInfoAgreeDate { get; set; }
		/// <summary>
		/// 개인정보동의경로
		/// </summary>
		[Column("개인정보동의경로")]
		public string PersonalInfoAgreementPath { get; set; }
		/// <summary>
		/// DEC_HP
		/// </summary>
		[Column("DEC_HP")]
		public string DEC_HP { get; set; }
		/// <summary>
		/// 개인정보동의여부
		/// </summary>
		[Column("개인정보동의여부")]
		public string PersonalInfoAgreeOrNot { get; set; }
		/// <summary>
		/// 여행자계약동의여부
		/// </summary>
		[Column("여행자계약동의여부")]
		public string TravelerContractAgreementOrNot { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
	}
}