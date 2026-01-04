using Modetour.Attributes;
using Modetour.Models.Datas;
using System.ComponentModel;
using System.Data;

namespace Modetour.B2C.Entity.Package;

/// <summary>
/// WSP_T_CMN_단체예약
/// </summary>
public class WSP_T_CMN_PackageReservation_Insert
{
	public const string SP_NAME = "WSP_T_CMN_닷컴예약";
	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("주문번호")]
		public int? OrderNumber { get; set; }
		/// <summary>
		/// 예약자번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("예약자번호")]
		public int? BookerNumber { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int? GroupNumber { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Description("상품코드")]
		public string ProductCode { get; set; }

		/// <summary>
		/// 구매수단코드
		/// </summary>
		[Description("구매수단코드")]
		public string BuyMethodCode { get; set; }

		/// <summary>
		/// 내부결제가능
		/// </summary>
		[Description("내부결제가능")]
		public string InternalPaymentPossible { get; set; }

		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }

		/// <summary>
		/// 거래처직원번호
		/// </summary>
		[Description("거래처직원번호")]
		public int CustomerEmployeeNumber { get; set; }

		/// <summary>
		/// 웹사이트번호
		/// </summary>
		[Description("웹사이트번호")]
		public int WebSiteNumber { get; set; }

		/// <summary>
		/// 판매종류코드
		/// </summary>
		[Description("판매종류코드")]
		public string SalesTypeCode { get; set; }

		/// <summary>
		/// 예약상태코드
		/// </summary>
		[Description("예약상태코드")]
		public string BookingStateCode { get; set; }

		/// <summary>
		/// 예약자명
		/// </summary>
		[Description("예약자명")]
		public string BookerName { get; set; }

		/// <summary>
		/// 예약자주민번호
		/// </summary>
		[Description("예약자주민번호")]
		public string BookerCitizenIDNumber { get; set; }

		/// <summary>
		/// 예약자핸드폰
		/// </summary>
		[Description("예약자핸드폰")]
		public string BookerPhone { get; set; }

		/// <summary>
		/// 예약자연락처
		/// </summary>
		[Description("예약자연락처")]
		public string BookerContact { get; set; }

		/// <summary>
		/// 예약자메일
		/// </summary>
		[Description("예약자메일")]
		public string BookerMail { get; set; }

		/// <summary>
		/// 예약자중복가입확인정보
		/// </summary>
		[Description("예약자중복가입확인정보")]
		public string BookerDuplicatedSignUpConfirmInfo { get; set; }

		/// <summary>
		/// 고객요청사항
		/// </summary>
		[Description("고객요청사항")]
		public string CustomerRequest { get; set; }

		/// <summary>
		/// 계약서_대표자이메일
		/// </summary>
		[Description("계약서_대표자이메일")]
		public string Contract_RepresentativeEmail { get; set; }
		/// <summary>
		/// 계약서_대표자명
		/// </summary>
		[Description("계약서_대표자명")]
		public string Contract_RepresentativeName { get; set; }
		/// <summary>
		/// 여행자한글명
		/// </summary>
		[Description("여행자한글명")]
		public string TravelerKoreanName { get; set; }
		/// <summary>
		/// 여행자영문성
		/// </summary>
		[Description("여행자영문성")]
		public string TravelerEnglishLastName { get; set; }

		/// <summary>
		/// 여행자영문명
		/// </summary>
		[Description("여행자영문명")]
		public string TravelerEnglishName { get; set; }
		/// <summary>
		/// 여행자주민번호
		/// </summary>
		[Description("여행자주민번호")]
		public string TravelerCitizenIDNumber { get; set; }

		/// <summary>
		/// 여행자성별코드
		/// </summary>
		[Description("여행자성별코드")]
		public string TravelerGenderCode { get; set; }
		/// <summary>
		/// 여행자HP
		/// </summary>
		[Description("여행자HP")]
		public string Traveler_HP { get; set; }

		[Description("예약자핸드폰")]
		public string HomePhone { get; set; }

		
		/// <summary>
		/// 여행자이메일
		/// </summary>
		[Description("여행자이메일")]
		public string TravelerEmail { get; set; }

		/// <summary>
		/// 판매가
		/// </summary>
		[Description("판매가")]
		public int SellingPrice { get; set; }

		/// <summary>
		/// 판매액
		/// </summary>
		[Description("판매액")]
		public int SalesAmount { get; set; }
		/// <summary>
		/// 추가판매
		/// </summary>
		[Description("추가판매")]
		public int AddSales { get; set; }

		/// <summary>
		/// 할인가적용여부
		/// </summary>
		[Description("할인가적용여부")]
		public string DiscountPriceApplyOrNot { get; set; }

		/// <summary>
		/// 특별약관동의
		/// </summary>
		[Description("특별약관동의")]
		public string SpecialTermsAgree { get; set; }

		/// <summary>
		/// 예약자PTID
		/// </summary>
		[Description("예약자PTID")]
		public int Booker_PTID { get; set; }

		/// <summary>
		/// 투어마일리지번호
		/// </summary>
		[Description("투어마일리지번호")]
		public string TourMileageNumber { get; set; }

		/// <summary>
		/// 회원구분
		/// </summary>
		[Description("회원구분")]
		public string MemberClassification { get; set; }


		/// <summary>
		/// 마일리지적립요청
		/// </summary>
		[Description("마일리지적립요청")]
		public string MileageAccumulationRequest { get; set; }

		/// <summary>
		/// 클럽커미션율
		/// </summary>
		[Description("클럽커미션율")]
		public decimal ClubCommisionRate { get; set; }

		/// <summary>
		/// 캠페인ID
		/// </summary>
		[Description("캠페인ID")]
		public string Campaign_ID { get; set; }


		/// <summary>
		/// 판매가구분
		/// </summary>
		[Description("판매가구분")]
		public string SellingPriceClassification { get; set; }

		/// <summary>
		/// 쿠키발급일
		/// </summary>
		[Description("쿠키발급일")]
		public DateTime CookieIssuanceDate { get; set; }

		/// <summary>
		/// 파트너여행사배분여부
		/// </summary>
		[Description("파트너여행사배분여부")]
		public string PartnerTravelCompanyDistributionOrNot { get; set; }

		/// <summary>
		/// 센딩구분
		/// </summary>
		[Description("센딩구분")]
		public int SendingClassification { get; set; }
	}
	public class TravelerParameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("주문번호")]
		public int? OrderNumber { get; set; }
		/// <summary>
		/// 예약자번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("예약자번호")]
		public int? BookerNumber { get; set; }

		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int? GroupNumber { get; set; }

		/// <summary>
		/// 상품코드
		/// </summary>
		[Description("상품코드")]
		public string ProductCode { get; set; }

		/// <summary>
		/// 구매수단코드
		/// </summary>
		[Description("구매수단코드")]
		public string BuyMethodCode { get; set; }

		/// <summary>
		/// 내부결제가능
		/// </summary>
		[Description("내부결제가능")]
		public string InternalPaymentPossible { get; set; }

		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }

		/// <summary>
		/// 거래처직원번호
		/// </summary>
		[Description("거래처직원번호")]
		public int CustomerEmployeeNumber { get; set; }

		/// <summary>
		/// 웹사이트번호
		/// </summary>
		[Description("웹사이트번호")]
		public int WebSiteNumber { get; set; }

		/// <summary>
		/// 판매종류코드
		/// </summary>
		[Description("판매종류코드")]
		public string SalesTypeCode { get; set; }


		/// <summary>
		/// 고객요청사항
		/// </summary>
		[Description("고객요청사항")]
		public string CustomerRequest { get; set; }

		/// <summary>
		/// 여행자한글명
		/// </summary>
		[Description("여행자한글명")]
		public string TravelerKoreanName { get; set; }
		/// <summary>
		/// 여행자영문성
		/// </summary>
		[Description("여행자영문성")]
		public string TravelerEnglishLastName { get; set; }

		/// <summary>
		/// 여행자영문명
		/// </summary>
		[Description("여행자영문명")]
		public string TravelerEnglishName { get; set; }
		/// <summary>
		/// 여행자주민번호
		/// </summary>
		[Description("여행자주민번호")]
		public string TravelerCitizenIDNumber { get; set; }

		/// <summary>
		/// 여행자성별코드
		/// </summary>
		[Description("여행자성별코드")]
		public string TravelerGenderCode { get; set; }
		/// <summary>
		/// 여행자HP
		/// </summary>
		[Description("여행자HP")]
		public string Traveler_HP { get; set; }

		/// <summary>
		/// 여행자이메일
		/// </summary>
		[Description("여행자이메일")]
		public string TravelerEmail { get; set; }

		/// <summary>
		/// 판매가
		/// </summary>
		[Description("판매가")]
		public int SellingPrice { get; set; }

		/// <summary>
		/// 판매액
		/// </summary>
		[Description("판매액")]
		public int SalesAmount { get; set; }
		/// <summary>
		/// 추가판매
		/// </summary>
		[Description("추가판매")]
		public int AddSales { get; set; }

		/// <summary>
		/// 할인가적용여부
		/// </summary>
		[Description("할인가적용여부")]
		public string DiscountPriceApplyOrNot { get; set; }

		/// <summary>
		/// 특별약관동의
		/// </summary>
		[Description("특별약관동의")]
		public string SpecialTermsAgree { get; set; }

		/// <summary>
		/// 투어마일리지번호
		/// </summary>
		[Description("투어마일리지번호")]
		public string TourMileageNumber { get; set; }

		/// <summary>
		/// 회원구분
		/// </summary>
		[Description("회원구분")]
		public string MemberClassification { get; set; }


		/// <summary>
		/// 마일리지적립요청
		/// </summary>
		[Description("마일리지적립요청")]
		public string MileageAccumulationRequest { get; set; }

		/// <summary>
		/// 클럽커미션율
		/// </summary>
		[Description("클럽커미션율")]
		public decimal ClubCommisionRate { get; set; }

		/// <summary>
		/// 캠페인ID
		/// </summary>
		[Description("캠페인ID")]
		public string Campaign_ID { get; set; }


		/// <summary>
		/// 판매가구분
		/// </summary>
		[Description("판매가구분")]
		public string SellingPriceClassification { get; set; }

		/// <summary>
		/// 쿠키발급일
		/// </summary>
		[Description("쿠키발급일")]
		public DateTime CookieIssuanceDate { get; set; }

		/// <summary>
		/// 파트너여행사배분여부
		/// </summary>
		[Description("파트너여행사배분여부")]
		public string PartnerTravelCompanyDistributionOrNot { get; set; }

		/// <summary>
		/// 센딩구분
		/// </summary>
		[Description("센딩구분")]
		public int SendingClassification { get; set; }
	}
}