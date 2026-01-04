namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_SO_거래처_인센티브
/// </summary>
public class WSP_SO_Customer_Incentive
{
	public const string SP_NAME = "WSP_SO_거래처_인센티브";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 시작일
		/// </summary>
		[Description("시작일")]
		public string StartDate { get; set; }
		/// <summary>
		/// 종료일
		/// </summary>
		[Description("종료일")]
		public string EndDate { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 견적상태
		/// </summary>
		[Description("견적상태")]
		public string EstimateState { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 부서번호
		/// </summary>
		[Description("부서번호")]
		public int DepartmentNumber { get; set; }
		/// <summary>
		/// 마스터일련번호
		/// </summary>
		[Description("마스터일련번호")]
		public int MasterSerialNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 마스터일련번호
		/// </summary>
		[Column("마스터일련번호")]
		public int MasterSerialNumber { get; set; }
		/// <summary>
		/// 요청일자
		/// </summary>
		[Column("요청일자")]
		public string RequestDate { get; set; }
		/// <summary>
		/// 요청자
		/// </summary>
		[Column("요청자")]
		public string Requester { get; set; }
		/// <summary>
		/// 요청구분
		/// </summary>
		[Column("요청구분")]
		public string RequestClassification { get; set; }
		/// <summary>
		/// 거래처
		/// </summary>
		[Column("거래처")]
		public string Customer { get; set; }
		/// <summary>
		/// 거래처직원
		/// </summary>
		[Column("거래처직원")]
		public string CustomerEmployee { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Column("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 거래처직원번호
		/// </summary>
		[Column("거래처직원번호")]
		public int CustomerEmployeeNumber { get; set; }
		/// <summary>
		/// 거래처직원HP
		/// </summary>
		[Column("거래처직원HP")]
		public string CustomerEmployeeHP { get; set; }
		/// <summary>
		/// 견적종류
		/// </summary>
		[Column("견적종류")]
		public string EstimateType { get; set; }
		/// <summary>
		/// 견적상태
		/// </summary>
		[Column("견적상태")]
		public string EstimateState { get; set; }
		/// <summary>
		/// 단체성격
		/// </summary>
		[Column("단체성격")]
		public string GroupCharacter { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 인센단체명
		/// </summary>
		[Column("인센단체명")]
		public string IncentiveGroupName { get; set; }
		/// <summary>
		/// 기준단체번호
		/// </summary>
		[Column("기준단체번호")]
		public int StandardGroupNumber { get; set; }
		/// <summary>
		/// 기준단체출발일
		/// </summary>
		[Column("기준단체출발일")]
		public string StandardGroupDepartureDate { get; set; }
		/// <summary>
		/// 기준단체도착일
		/// </summary>
		[Column("기준단체도착일")]
		public string StandardGroupArrivalDate { get; set; }
		/// <summary>
		/// 기준박수
		/// </summary>
		[Column("기준박수")]
		public int StandardNumberOfNights { get; set; }
		/// <summary>
		/// 기준일수
		/// </summary>
		[Column("기준일수")]
		public int StandardDaysNumber { get; set; }
		/// <summary>
		/// 기준단체상품코드
		/// </summary>
		[Column("기준단체상품코드")]
		public string StandardGroupProductCode { get; set; }
		/// <summary>
		/// 기준단체상품명
		/// </summary>
		[Column("기준단체상품명")]
		public string StandardGroupProductName { get; set; }
		/// <summary>
		/// 성인
		/// </summary>
		[Column("성인")]
		public int Adult { get; set; }
		/// <summary>
		/// 소아
		/// </summary>
		[Column("소아")]
		public int Kid { get; set; }
		/// <summary>
		/// 유아
		/// </summary>
		[Column("유아")]
		public int Toddler { get; set; }
		/// <summary>
		/// TC
		/// </summary>
		[Column("TC")]
		public int TC { get; set; }
		/// <summary>
		/// FOC
		/// </summary>
		[Column("FOC")]
		public int FOC { get; set; }
		/// <summary>
		/// 룸_더블
		/// </summary>
		[Column("룸_더블")]
		public int Room_Double { get; set; }
		/// <summary>
		/// 룸_트윈
		/// </summary>
		[Column("룸_트윈")]
		public int Room_Twin { get; set; }
		/// <summary>
		/// 룸_싱글
		/// </summary>
		[Column("룸_싱글")]
		public int Room_Single { get; set; }
		/// <summary>
		/// 룸_트리플
		/// </summary>
		[Column("룸_트리플")]
		public int Room_Triple { get; set; }
		/// <summary>
		/// 호텔
		/// </summary>
		[Column("호텔")]
		public string Hotel { get; set; }
		/// <summary>
		/// 차량
		/// </summary>
		[Column("차량")]
		public string Car { get; set; }
		/// <summary>
		/// 쇼핑
		/// </summary>
		[Column("쇼핑")]
		public string Shopping { get; set; }
		/// <summary>
		/// 인솔자
		/// </summary>
		[Column("인솔자")]
		public string Leader { get; set; }
		/// <summary>
		/// 팁포함여부
		/// </summary>
		[Column("팁포함여부")]
		public string TipIncludedOrNot { get; set; }
		/// <summary>
		/// 영업수익률자동여부
		/// </summary>
		[Column("영업수익률자동여부")]
		public string BusinessProfitPercentAutomaticOrNot { get; set; }
		/// <summary>
		/// 영업수익률자동비율
		/// </summary>
		[Column("영업수익률자동비율")]
		public decimal BusinessProfitPercentAutomaticPercentage { get; set; }
		/// <summary>
		/// 희망일인요금
		/// </summary>
		[Column("희망일인요금")]
		public int DesiredSingleFare { get; set; }
		/// <summary>
		/// 일정비고
		/// </summary>
		[Column("일정비고")]
		public string ScheduleNote { get; set; }
		/// <summary>
		/// 특수견적비고
		/// </summary>
		[Column("특수견적비고")]
		public string SpecialEstimateNote { get; set; }
		/// <summary>
		/// 기타요청사항
		/// </summary>
		[Column("기타요청사항")]
		public string OtherRequest { get; set; }
		/// <summary>
		/// 영업접수일
		/// </summary>
		[Column("영업접수일")]
		public string BusinessReceiptDate { get; set; }
		/// <summary>
		/// 영업완료일
		/// </summary>
		[Column("영업완료일")]
		public string BusinessFinishDate { get; set; }
		/// <summary>
		/// 영업부서
		/// </summary>
		[Column("영업부서")]
		public string BusinessDepartment { get; set; }
		/// <summary>
		/// 영업소팀
		/// </summary>
		[Column("영업소팀")]
		public string BusinessSubTeam { get; set; }
		/// <summary>
		/// 영업OP
		/// </summary>
		[Column("영업OP")]
		public string Business_OP { get; set; }
		/// <summary>
		/// 영업OPHP
		/// </summary>
		[Column("영업OPHP")]
		public string Business_OPHP { get; set; }
		/// <summary>
		/// 상품접수일
		/// </summary>
		[Column("상품접수일")]
		public string ProductReceiptDate { get; set; }
		/// <summary>
		/// 상품완료일
		/// </summary>
		[Column("상품완료일")]
		public string ProductFinishDate { get; set; }
		/// <summary>
		/// 상품부서
		/// </summary>
		[Column("상품부서")]
		public string ProductDepartment { get; set; }
		/// <summary>
		/// 상품부서번호
		/// </summary>
		[Column("상품부서번호")]
		public int ProductDepartmentNumber { get; set; }
		/// <summary>
		/// 상품담당자
		/// </summary>
		[Column("상품담당자")]
		public string ProductManager { get; set; }
		/// <summary>
		/// 상품담당자번호
		/// </summary>
		[Column("상품담당자번호")]
		public int ProductManagerNumber { get; set; }
		/// <summary>
		/// 상품담당자HP
		/// </summary>
		[Column("상품담당자HP")]
		public string ProductManagerHP { get; set; }
		/// <summary>
		/// 확정단체번호
		/// </summary>
		[Column("확정단체번호")]
		public int ConfirmGroupNumber { get; set; }
		/// <summary>
		/// 확정단체출발일
		/// </summary>
		[Column("확정단체출발일")]
		public string ConfirmGroupDepartureDate { get; set; }
		/// <summary>
		/// 확정단체도착일
		/// </summary>
		[Column("확정단체도착일")]
		public string ConfirmGroupArrivalDate { get; set; }
		/// <summary>
		/// 확정박수
		/// </summary>
		[Column("확정박수")]
		public byte ConfirmNightsNumber { get; set; }
		/// <summary>
		/// 확정일수
		/// </summary>
		[Column("확정일수")]
		public byte ConfirmDaysNumber { get; set; }
		/// <summary>
		/// 확정단체상품코드
		/// </summary>
		[Column("확정단체상품코드")]
		public string ConfirmGroupProductCode { get; set; }
		/// <summary>
		/// 확정단체상품명
		/// </summary>
		[Column("확정단체상품명")]
		public string ConfirmGroupProductName { get; set; }
		/// <summary>
		/// 항공료
		/// </summary>
		[Column("항공료")]
		public int FlightFee { get; set; }
		/// <summary>
		/// TAX
		/// </summary>
		[Column("TAX")]
		public int TAX { get; set; }
		/// <summary>
		/// 유류할증료
		/// </summary>
		[Column("유류할증료")]
		public long FuelSurchargeFee { get; set; }
		/// <summary>
		/// 인당항공료
		/// </summary>
		[Column("인당항공료")]
		public long EachPersonFlightFee { get; set; }
		/// <summary>
		/// 지상비
		/// </summary>
		[Column("지상비")]
		public int LocalFee { get; set; }
		/// <summary>
		/// 보험료
		/// </summary>
		[Column("보험료")]
		public long InsuranceFee { get; set; }
		/// <summary>
		/// 추가요금
		/// </summary>
		[Column("추가요금")]
		public int AddFare { get; set; }
		/// <summary>
		/// 기준환율
		/// </summary>
		[Column("기준환율")]
		public decimal StandardExchangeRate { get; set; }
		/// <summary>
		/// 인당지상비
		/// </summary>
		[Column("인당지상비")]
		public int EachPersonLocalFee { get; set; }
		/// <summary>
		/// 원가합계
		/// </summary>
		[Column("원가합계")]
		public int OriginalPriceSum { get; set; }
		/// <summary>
		/// 판매가
		/// </summary>
		[Column("판매가")]
		public int SellingPrice { get; set; }
		/// <summary>
		/// 영업입금가
		/// </summary>
		[Column("영업입금가")]
		public int BusinessDepositPrice { get; set; }
		/// <summary>
		/// 영업수익
		/// </summary>
		[Column("영업수익")]
		public int BusinessProfit { get; set; }
		/// <summary>
		/// 상품입금가
		/// </summary>
		[Column("상품입금가")]
		public int ProductDepositPrice { get; set; }
		/// <summary>
		/// 상품수익
		/// </summary>
		[Column("상품수익")]
		public int ProductProfit { get; set; }
		/// <summary>
		/// 총공헌이익
		/// </summary>
		[Column("총공헌이익")]
		public int TotalContributionProfit { get; set; }
		/// <summary>
		/// 견적유효기간
		/// </summary>
		[Column("견적유효기간")]
		public string EstimateValidPeriod { get; set; }
		/// <summary>
		/// 펑션룸사용여부
		/// </summary>
		[Column("펑션룸사용여부")]
		public string FunctionRoomUseOrNot { get; set; }
		/// <summary>
		/// 공공단체방문여부
		/// </summary>
		[Column("공공단체방문여부")]
		public string PublicGroupVisitOrNot { get; set; }
		/// <summary>
		/// 통역필요여부
		/// </summary>
		[Column("통역필요여부")]
		public string InterpreterRequiredOrNot { get; set; }
		/// <summary>
		/// 기타추가여부
		/// </summary>
		[Column("기타추가여부")]
		public string OtherAddOrNot { get; set; }
		/// <summary>
		/// 상품비고
		/// </summary>
		[Column("상품비고")]
		public string ProductNote { get; set; }
		/// <summary>
		/// 영업비고
		/// </summary>
		[Column("영업비고")]
		public string BusinessNote { get; set; }
		/// <summary>
		/// 영업부개인메모
		/// </summary>
		[Column("영업부개인메모")]
		public string BusinessUnpersonalMemo { get; set; }
		/// <summary>
		/// 첨부파일_영업
		/// </summary>
		[Column("첨부파일_영업")]
		public string AttachFile_Business { get; set; }
		/// <summary>
		/// 첨부파일_상품
		/// </summary>
		[Column("첨부파일_상품")]
		public string AttachFile_Product { get; set; }
		/// <summary>
		/// 견적상태코드
		/// </summary>
		[Column("견적상태코드")]
		public string EstimateStateCode { get; set; }
		/// <summary>
		/// 포함사항
		/// </summary>
		[Column("포함사항")]
		public string IncludedItem { get; set; }
		/// <summary>
		/// 불포함사항
		/// </summary>
		[Column("불포함사항")]
		public string UnincludedItem { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Column("지역")]
		public string Region { get; set; }
		/// <summary>
		/// 지역코드
		/// </summary>
		[Column("지역코드")]
		public string RegionCode { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 요청일자
		/// </summary>
		[Column("요청일자")]
		public string RequestDate { get; set; }
		/// <summary>
		/// 마스터일련번호
		/// </summary>
		[Column("마스터일련번호")]
		public int MasterSerialNumber { get; set; }
		/// <summary>
		/// 요청구분
		/// </summary>
		[Column("요청구분")]
		public string RequestClassification { get; set; }
		/// <summary>
		/// 영업부서
		/// </summary>
		[Column("영업부서")]
		public string BusinessDepartment { get; set; }
		/// <summary>
		/// 영업소팀
		/// </summary>
		[Column("영업소팀")]
		public string BusinessSubTeam { get; set; }
		/// <summary>
		/// 영업담당자
		/// </summary>
		[Column("영업담당자")]
		public string BusinessManager { get; set; }
		/// <summary>
		/// 거래처
		/// </summary>
		[Column("거래처")]
		public string Customer { get; set; }
		/// <summary>
		/// 거래처직원
		/// </summary>
		[Column("거래처직원")]
		public string CustomerEmployee { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Column("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 거래처직원번호
		/// </summary>
		[Column("거래처직원번호")]
		public int CustomerEmployeeNumber { get; set; }
		/// <summary>
		/// 견적종류
		/// </summary>
		[Column("견적종류")]
		public string EstimateType { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 항공코드
		/// </summary>
		[Column("항공코드")]
		public string FlightCode { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Column("지역")]
		public string Region { get; set; }
		/// <summary>
		/// 대표국가
		/// </summary>
		[Column("대표국가")]
		public string RepresentativeCountry { get; set; }
		/// <summary>
		/// 대표도시
		/// </summary>
		[Column("대표도시")]
		public string RepresentativeCity { get; set; }
		/// <summary>
		/// 지역번호
		/// </summary>
		[Column("지역번호")]
		public string RegionNumber { get; set; }
		/// <summary>
		/// 대표국가번호
		/// </summary>
		[Column("대표국가번호")]
		public int RepresentativeCountryNumber { get; set; }
		/// <summary>
		/// 대표도시번호
		/// </summary>
		[Column("대표도시번호")]
		public int RepresentativeCityNumber { get; set; }
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
		/// 박
		/// </summary>
		[Column("박")]
		public int Night { get; set; }
		/// <summary>
		/// 일
		/// </summary>
		[Column("일")]
		public int Date { get; set; }
		/// <summary>
		/// 쇼핑
		/// </summary>
		[Column("쇼핑")]
		public string Shopping { get; set; }
		/// <summary>
		/// 팁포함여부
		/// </summary>
		[Column("팁포함여부")]
		public string TipIncludedOrNot { get; set; }
		/// <summary>
		/// 인솔자
		/// </summary>
		[Column("인솔자")]
		public string Leader { get; set; }
		/// <summary>
		/// 인원
		/// </summary>
		[Column("인원")]
		public int NumberOfPeople { get; set; }
		/// <summary>
		/// 인원비고
		/// </summary>
		[Column("인원비고")]
		public string NumberOfPeopleNote { get; set; }
		/// <summary>
		/// 특수견적여부
		/// </summary>
		[Column("특수견적여부")]
		public string SpecialEstimateOrNot { get; set; }
		/// <summary>
		/// 특수견적비고
		/// </summary>
		[Column("특수견적비고")]
		public string SpecialEstimateNote { get; set; }
		/// <summary>
		/// 기타요청사항
		/// </summary>
		[Column("기타요청사항")]
		public string OtherRequest { get; set; }
		/// <summary>
		/// 견적상태
		/// </summary>
		[Column("견적상태")]
		public string EstimateState { get; set; }
		/// <summary>
		/// 상품부서
		/// </summary>
		[Column("상품부서")]
		public string ProductDepartment { get; set; }
		/// <summary>
		/// 상품담당자
		/// </summary>
		[Column("상품담당자")]
		public string ProductManager { get; set; }
		/// <summary>
		/// 지상비
		/// </summary>
		[Column("지상비")]
		public int LocalFee { get; set; }
		/// <summary>
		/// 항공료
		/// </summary>
		[Column("항공료")]
		public int FlightFee { get; set; }
		/// <summary>
		/// TAX
		/// </summary>
		[Column("TAX")]
		public int TAX { get; set; }
		/// <summary>
		/// 추가요금
		/// </summary>
		[Column("추가요금")]
		public int AddFare { get; set; }
		/// <summary>
		/// 합계금액
		/// </summary>
		[Column("합계금액")]
		public int SumAmount { get; set; }
		/// <summary>
		/// 상품수익
		/// </summary>
		[Column("상품수익")]
		public int ProductProfit { get; set; }
		/// <summary>
		/// 영업수익
		/// </summary>
		[Column("영업수익")]
		public int BusinessProfit { get; set; }
		/// <summary>
		/// 상품접수일
		/// </summary>
		[Column("상품접수일")]
		public string ProductReceiptDate { get; set; }
		/// <summary>
		/// 상품완료일
		/// </summary>
		[Column("상품완료일")]
		public string ProductFinishDate { get; set; }
		/// <summary>
		/// 영업접수일
		/// </summary>
		[Column("영업접수일")]
		public string BusinessReceiptDate { get; set; }
		/// <summary>
		/// 영업완료일
		/// </summary>
		[Column("영업완료일")]
		public string BusinessFinishDate { get; set; }
		/// <summary>
		/// 최종수정일
		/// </summary>
		[Column("최종수정일")]
		public string FinalEditionDate { get; set; }
		/// <summary>
		/// 견적상태코드
		/// </summary>
		[Column("견적상태코드")]
		public string EstimateStateCode { get; set; }
		/// <summary>
		/// 경로
		/// </summary>
		[Column("경로")]
		public string Route { get; set; }
		/// <summary>
		/// 영업OP부서
		/// </summary>
		[Column("영업OP부서")]
		public string Business_OP_Department { get; set; }
		/// <summary>
		/// 영업OP
		/// </summary>
		[Column("영업OP")]
		public string Business_OP { get; set; }
		/// <summary>
		/// 메모수
		/// </summary>
		[Column("메모수")]
		public string MemoCount { get; set; }
		/// <summary>
		/// 요청자
		/// </summary>
		[Column("요청자")]
		public string Requester { get; set; }
		/// <summary>
		/// 확정단체번호
		/// </summary>
		[Column("확정단체번호")]
		public int ConfirmGroupNumber { get; set; }
		/// <summary>
		/// 확정출발일
		/// </summary>
		[Column("확정출발일")]
		public string ConfirmDepartureDate { get; set; }
		/// <summary>
		/// 확정상품코드
		/// </summary>
		[Column("확정상품코드")]
		public string ConfirmProductCode { get; set; }
		/// <summary>
		/// 내선_영업담당
		/// </summary>
		[Column("내선_영업담당")]
		public string Interphone_BusinessResponsibility { get; set; }
		/// <summary>
		/// 내선_영업OP
		/// </summary>
		[Column("내선_영업OP")]
		public string Interphone_Business_OP { get; set; }
		/// <summary>
		/// 내선_상품담당
		/// </summary>
		[Column("내선_상품담당")]
		public string Interphone_ProductResponsibility { get; set; }
		/// <summary>
		/// 원가합계액
		/// </summary>
		[Column("원가합계액")]
		public int OriginalPriceSumAmount { get; set; }
		/// <summary>
		/// 상품팀입금가
		/// </summary>
		[Column("상품팀입금가")]
		public int ProductTeamDepositPrice { get; set; }
		/// <summary>
		/// 입금가
		/// </summary>
		[Column("입금가")]
		public int DepositPrice { get; set; }
		/// <summary>
		/// 수익금액
		/// </summary>
		[Column("수익금액")]
		public int ProfitAmount { get; set; }
		/// <summary>
		/// 수익률
		/// </summary>
		[Column("수익률")]
		public decimal ProfitPercent { get; set; }
		/// <summary>
		/// 기준단체번호
		/// </summary>
		[Column("기준단체번호")]
		public int StandardGroupNumber { get; set; }
		/// <summary>
		/// 인센단체명
		/// </summary>
		[Column("인센단체명")]
		public string IncentiveGroupName { get; set; }
		/// <summary>
		/// 첨부파일여부_영업
		/// </summary>
		[Column("첨부파일여부_영업")]
		public string AttachFileOrNot_Business { get; set; }
		/// <summary>
		/// 첨부파일여부_상품
		/// </summary>
		[Column("첨부파일여부_상품")]
		public string AttachFileOrNot_Product { get; set; }
		/// <summary>
		/// 첨부파일_영업
		/// </summary>
		[Column("첨부파일_영업")]
		public string AttachFile_Business { get; set; }
		/// <summary>
		/// 첨부파일_상품
		/// </summary>
		[Column("첨부파일_상품")]
		public string AttachFile_Product { get; set; }
		/// <summary>
		/// 진행결렬사유
		/// </summary>
		[Column("진행결렬사유")]
		public string ProgressBreakdownReason { get; set; }
		/// <summary>
		/// 영업부개인메모
		/// </summary>
		[Column("영업부개인메모")]
		public string BusinessUnpersonalMemo { get; set; }
	}
}