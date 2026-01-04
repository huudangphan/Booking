namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_SO_거래처_예약상세
/// </summary>
public class WSP_SO_Customer_ReservationDetail
{
	public const string SP_NAME = "WSP_SO_거래처_예약상세";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 년월일
		/// </summary>
		[Description("년월일")]
		public DateTime YearMonthDate { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Description("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 구분2
		/// </summary>
		[Description("구분2")]
		public string Classification2 { get; set; }
		/// <summary>
		/// MODE
		/// </summary>
		[Description("MODE")]
		public string MODE { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Column("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 예약번호
		/// </summary>
		[Column("예약번호")]
		public int BookingNumber { get; set; }
		/// <summary>
		/// 예약종류
		/// </summary>
		[Column("예약종류")]
		public string BookingType { get; set; }
		/// <summary>
		/// 예약상태
		/// </summary>
		[Column("예약상태")]
		public string BookingState { get; set; }
		/// <summary>
		/// 판매종류
		/// </summary>
		[Column("판매종류")]
		public string SalesType { get; set; }
		/// <summary>
		/// 판매일
		/// </summary>
		[Column("판매일")]
		public string SalesDate { get; set; }
		/// <summary>
		/// 수배담당자
		/// </summary>
		[Column("수배담당자")]
		public string WantedManager { get; set; }
		/// <summary>
		/// 수배담당자HP
		/// </summary>
		[Column("수배담당자HP")]
		public string WantedManagerHP { get; set; }
		/// <summary>
		/// 수배담당자내선
		/// </summary>
		[Column("수배담당자내선")]
		public string WantedManagerInterphone { get; set; }
		/// <summary>
		/// 항공담당자
		/// </summary>
		[Column("항공담당자")]
		public string FlightManager { get; set; }
		/// <summary>
		/// 항공담당자HP
		/// </summary>
		[Column("항공담당자HP")]
		public string FlightManager_HP { get; set; }
		/// <summary>
		/// 항공담당자내선
		/// </summary>
		[Column("항공담당자내선")]
		public string FlightManagerInterphone { get; set; }
		/// <summary>
		/// 예약대행자
		/// </summary>
		[Column("예약대행자")]
		public string BookingProcurator { get; set; }
		/// <summary>
		/// 예약대행자HP
		/// </summary>
		[Column("예약대행자HP")]
		public string BookingProcurator_HP { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 영문성
		/// </summary>
		[Column("영문성")]
		public string EnglishLastName { get; set; }
		/// <summary>
		/// 영문이름
		/// </summary>
		[Column("영문이름")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 주민번호
		/// </summary>
		[Column("주민번호")]
		public string CitizenIDNumber { get; set; }
		/// <summary>
		/// 고객HP
		/// </summary>
		[Column("고객HP")]
		public string Customer_HP { get; set; }
		/// <summary>
		/// 판매가구분
		/// </summary>
		[Column("판매가구분")]
		public string SellingPriceClassification { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Column("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 인솔자구분
		/// </summary>
		[Column("인솔자구분")]
		public string LeaderClassification { get; set; }
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
		/// 여권발급일
		/// </summary>
		[Column("여권발급일")]
		public string PassportIssuanceDate { get; set; }
		/// <summary>
		/// 판매액
		/// </summary>
		[Column("판매액")]
		public long SalesAmount { get; set; }
		/// <summary>
		/// 커미션
		/// </summary>
		[Column("커미션")]
		public long Commission { get; set; }
		/// <summary>
		/// 커미션율
		/// </summary>
		[Column("커미션율")]
		public int CommisionRate { get; set; }
		/// <summary>
		/// VAT
		/// </summary>
		[Column("VAT")]
		public long VAT { get; set; }
		/// <summary>
		/// 계산서
		/// </summary>
		[Column("계산서")]
		public string Invoice { get; set; }
		/// <summary>
		/// DISPLAY차액
		/// </summary>
		[Column("DISPLAY차액")]
		public long DISPLAY_Difference { get; set; }
		/// <summary>
		/// 추가판매
		/// </summary>
		[Column("추가판매")]
		public long AddSales { get; set; }
		/// <summary>
		/// 추가판매유류
		/// </summary>
		[Column("추가판매유류")]
		public long AddSalesFeeCharged { get; set; }
		/// <summary>
		/// 추가판매제세금
		/// </summary>
		[Column("추가판매제세금")]
		public int AddSalesTax { get; set; }
		/// <summary>
		/// 추가판매비자
		/// </summary>
		[Column("추가판매비자")]
		public long AddSalesVisa { get; set; }
		/// <summary>
		/// 추가판매서비스
		/// </summary>
		[Column("추가판매서비스")]
		public long AddSalesService { get; set; }
		/// <summary>
		/// 취급수수료
		/// </summary>
		[Column("취급수수료")]
		public long HandleFee { get; set; }
		/// <summary>
		/// 추가원가항공
		/// </summary>
		[Column("추가원가항공")]
		public long AddOriginalPriceFlight { get; set; }
		/// <summary>
		/// 추가원가비자
		/// </summary>
		[Column("추가원가비자")]
		public int AddOriginalPriceVisa { get; set; }
		/// <summary>
		/// 추가원가서비스
		/// </summary>
		[Column("추가원가서비스")]
		public long AddOriginalPriceService { get; set; }
		/// <summary>
		/// 배분수익
		/// </summary>
		[Column("배분수익")]
		public long DistributionProfit { get; set; }
		/// <summary>
		/// 수익이전
		/// </summary>
		[Column("수익이전")]
		public int ProfitTransfer { get; set; }
		/// <summary>
		/// 발권수익
		/// </summary>
		[Column("발권수익")]
		public long TicketIssuanceProfit { get; set; }
		/// <summary>
		/// 해피콜SMS
		/// </summary>
		[Column("해피콜SMS")]
		public string HappyCall_SMS { get; set; }
		/// <summary>
		/// 항공FOC
		/// </summary>
		[Column("항공FOC")]
		public string Flight_FOC { get; set; }
		/// <summary>
		/// 보험불포함
		/// </summary>
		[Column("보험불포함")]
		public string InsuranceUnincluded { get; set; }
		/// <summary>
		/// 보험취소
		/// </summary>
		[Column("보험취소")]
		public string InsuranceCancel { get; set; }
		/// <summary>
		/// 대기예약
		/// </summary>
		[Column("대기예약")]
		public string WaitingBooking { get; set; }
		/// <summary>
		/// 발권
		/// </summary>
		[Column("발권")]
		public string TicketIssuance { get; set; }
		/// <summary>
		/// 추가판매비고
		/// </summary>
		[Column("추가판매비고")]
		public string AddSalesNote { get; set; }
		/// <summary>
		/// 고객요청사항
		/// </summary>
		[Column("고객요청사항")]
		public string CustomerRequest { get; set; }
		/// <summary>
		/// 상품팀에게요청
		/// </summary>
		[Column("상품팀에게요청")]
		public string RequestToProductTeam { get; set; }
		/// <summary>
		/// CRS에서요청
		/// </summary>
		[Column("CRS에서요청")]
		public string RequestFrom_CRS { get; set; }
		/// <summary>
		/// LAND에게요청
		/// </summary>
		[Column("LAND에게요청")]
		public string RequestTo_LAND { get; set; }
		/// <summary>
		/// 판매비고
		/// </summary>
		[Column("판매비고")]
		public string SalesNote { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 도착일
		/// </summary>
		[Column("도착일")]
		public string ArrivalDate { get; set; }
		/// <summary>
		/// 상품가
		/// </summary>
		[Column("상품가")]
		public long ProductPrice { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 상품구분
		/// </summary>
		[Column("상품구분")]
		public string ProductClassification { get; set; }
		/// <summary>
		/// 항공편
		/// </summary>
		[Column("항공편")]
		public string Flight { get; set; }
		/// <summary>
		/// 도착항공편
		/// </summary>
		[Column("도착항공편")]
		public string ArrivalFlight { get; set; }
		/// <summary>
		/// 항공비고
		/// </summary>
		[Column("항공비고")]
		public string FlightNote { get; set; }
		/// <summary>
		/// 수배비고
		/// </summary>
		[Column("수배비고")]
		public string WantedNote { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 출발확정
		/// </summary>
		[Column("출발확정")]
		public string DepartureConfirm { get; set; }
		/// <summary>
		/// 입금상태
		/// </summary>
		[Column("입금상태")]
		public string DepositState { get; set; }
		/// <summary>
		/// 판매가_어른
		/// </summary>
		[Column("판매가_어른")]
		public long SellingPrice_Adult { get; set; }
		/// <summary>
		/// 카드승인
		/// </summary>
		[Column("카드승인")]
		public string CardApproval { get; set; }
		/// <summary>
		/// 대외모객
		/// </summary>
		[Column("대외모객")]
		public int InternationalAudience { get; set; }
		/// <summary>
		/// 보유좌석수
		/// </summary>
		[Column("보유좌석수")]
		public int HoldingSeatNumber { get; set; }
		/// <summary>
		/// 최소출발인원
		/// </summary>
		[Column("최소출발인원")]
		public int MinimumDepartureNumberOfPeople { get; set; }
		/// <summary>
		/// 예약좌석
		/// </summary>
		[Column("예약좌석")]
		public int BookingSeat { get; set; }
		/// <summary>
		/// 거래처
		/// </summary>
		[Column("거래처")]
		public string Customer { get; set; }
		/// <summary>
		/// 거래처HP
		/// </summary>
		[Column("거래처HP")]
		public string CustomerHP { get; set; }
		/// <summary>
		/// 거래처직원
		/// </summary>
		[Column("거래처직원")]
		public string CustomerEmployee { get; set; }
		/// <summary>
		/// 거래처직원HP
		/// </summary>
		[Column("거래처직원HP")]
		public string CustomerEmployeeHP { get; set; }
		/// <summary>
		/// 담당부서
		/// </summary>
		[Column("담당부서")]
		public string ResponsibilityDepartment { get; set; }
		/// <summary>
		/// 담당자
		/// </summary>
		[Column("담당자")]
		public string Manager { get; set; }
		/// <summary>
		/// 담당OP
		/// </summary>
		[Column("담당OP")]
		public string Responsibility_OP { get; set; }
	}
}