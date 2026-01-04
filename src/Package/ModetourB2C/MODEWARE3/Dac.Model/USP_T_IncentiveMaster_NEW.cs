namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_인센티브마스터_NEW
/// </summary>
public class USP_T_IncentiveMaster_NEW
{
	public const string SP_NAME = "USP_T_인센티브마스터_NEW";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 마스터일련번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("마스터일련번호")]
		public int MasterSerialNumber { get; set; }
		/// <summary>
		/// 요청구분
		/// </summary>
		[Description("요청구분")]
		public string RequestClassification { get; set; }
		/// <summary>
		/// 영업부서
		/// </summary>
		[Description("영업부서")]
		public int BusinessDepartment { get; set; }
		/// <summary>
		/// 영업담당자
		/// </summary>
		[Description("영업담당자")]
		public int BusinessManager { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Description("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 거래처직원번호
		/// </summary>
		[Description("거래처직원번호")]
		public int CustomerEmployeeNumber { get; set; }
		/// <summary>
		/// 견적종류
		/// </summary>
		[Description("견적종류")]
		public string EstimateType { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Description("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Description("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 항공코드
		/// </summary>
		[Description("항공코드")]
		public string FlightCode { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Description("지역")]
		public string Region { get; set; }
		/// <summary>
		/// 대표국가
		/// </summary>
		[Description("대표국가")]
		public int RepresentativeCountry { get; set; }
		/// <summary>
		/// 대표도시
		/// </summary>
		[Description("대표도시")]
		public int RepresentativeCity { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Description("출발일")]
		public DateTime DepartureDate { get; set; }
		/// <summary>
		/// 도착일
		/// </summary>
		[Description("도착일")]
		public DateTime ArrivalDate { get; set; }
		/// <summary>
		/// 박
		/// </summary>
		[Description("박")]
		public int Night { get; set; }
		/// <summary>
		/// 일
		/// </summary>
		[Description("일")]
		public int Date { get; set; }
		/// <summary>
		/// 쇼핑
		/// </summary>
		[Description("쇼핑")]
		public string Shopping { get; set; }
		/// <summary>
		/// 팁포함여부
		/// </summary>
		[Description("팁포함여부")]
		public string TipIncludedOrNot { get; set; }
		/// <summary>
		/// 인솔자
		/// </summary>
		[Description("인솔자")]
		public string Leader { get; set; }
		/// <summary>
		/// 인원
		/// </summary>
		[Description("인원")]
		public int NumberOfPeople { get; set; }
		/// <summary>
		/// 인원비고
		/// </summary>
		[Description("인원비고")]
		public string NumberOfPeopleNote { get; set; }
		/// <summary>
		/// 특수견적여부
		/// </summary>
		[Description("특수견적여부")]
		public string SpecialEstimateOrNot { get; set; }
		/// <summary>
		/// 특수견적비고
		/// </summary>
		[Description("특수견적비고")]
		public string SpecialEstimateNote { get; set; }
		/// <summary>
		/// 기타요청사항
		/// </summary>
		[Description("기타요청사항")]
		public string OtherRequest { get; set; }
		/// <summary>
		/// 견적상태
		/// </summary>
		[Description("견적상태")]
		public string EstimateState { get; set; }
		/// <summary>
		/// 상품부서
		/// </summary>
		[Description("상품부서")]
		public int ProductDepartment { get; set; }
		/// <summary>
		/// 상품담당자
		/// </summary>
		[Description("상품담당자")]
		public int ProductManager { get; set; }
		/// <summary>
		/// 지상비
		/// </summary>
		[Description("지상비")]
		public int LocalFee { get; set; }
		/// <summary>
		/// 인당지상비
		/// </summary>
		[Description("인당지상비")]
		public int EachPersonLocalFee { get; set; }
		/// <summary>
		/// 항공료
		/// </summary>
		[Description("항공료")]
		public int FlightFee { get; set; }
		/// <summary>
		/// TAX
		/// </summary>
		[Description("TAX")]
		public int TAX { get; set; }
		/// <summary>
		/// 추가요금
		/// </summary>
		[Description("추가요금")]
		public int AddFare { get; set; }
		/// <summary>
		/// 합계금액
		/// </summary>
		[Description("합계금액")]
		public int SumAmount { get; set; }
		/// <summary>
		/// 상품수익
		/// </summary>
		[Description("상품수익")]
		public int ProductProfit { get; set; }
		/// <summary>
		/// 영업수익
		/// </summary>
		[Description("영업수익")]
		public int BusinessProfit { get; set; }
		/// <summary>
		/// 랜드사번호
		/// </summary>
		[Description("랜드사번호")]
		public int LandCompanyNumber { get; set; }
		/// <summary>
		/// 단체성격
		/// </summary>
		[Description("단체성격")]
		public string GroupCharacter { get; set; }
		/// <summary>
		/// 희망일인요금
		/// </summary>
		[Description("희망일인요금")]
		public int DesiredSingleFare { get; set; }
		/// <summary>
		/// 성인
		/// </summary>
		[Description("성인")]
		public int Adult { get; set; }
		/// <summary>
		/// 소아
		/// </summary>
		[Description("소아")]
		public int Kid { get; set; }
		/// <summary>
		/// 유아
		/// </summary>
		[Description("유아")]
		public int Toddler { get; set; }
		/// <summary>
		/// FOC
		/// </summary>
		[Description("FOC")]
		public int FOC { get; set; }
		/// <summary>
		/// 트윈
		/// </summary>
		[Description("트윈")]
		public int Twin { get; set; }
		/// <summary>
		/// 싱글
		/// </summary>
		[Description("싱글")]
		public int Single { get; set; }
		/// <summary>
		/// 더블
		/// </summary>
		[Description("더블")]
		public int Double { get; set; }
		/// <summary>
		/// 트리플
		/// </summary>
		[Description("트리플")]
		public int Triple { get; set; }
		/// <summary>
		/// 호텔
		/// </summary>
		[Description("호텔")]
		public string Hotel { get; set; }
		/// <summary>
		/// 차량
		/// </summary>
		[Description("차량")]
		public string Car { get; set; }
		/// <summary>
		/// 펑션룸사용여부
		/// </summary>
		[Description("펑션룸사용여부")]
		public string FunctionRoomUseOrNot { get; set; }
		/// <summary>
		/// 공공단체방문여부
		/// </summary>
		[Description("공공단체방문여부")]
		public string PublicGroupVisitOrNot { get; set; }
		/// <summary>
		/// 통역필요여부
		/// </summary>
		[Description("통역필요여부")]
		public string InterpreterRequiredOrNot { get; set; }
		/// <summary>
		/// 기타추가여부
		/// </summary>
		[Description("기타추가여부")]
		public string OtherAddOrNot { get; set; }
		/// <summary>
		/// 견적유효기간
		/// </summary>
		[Description("견적유효기간")]
		public DateTime EstimateValidPeriod { get; set; }
		/// <summary>
		/// 일정비고
		/// </summary>
		[Description("일정비고")]
		public string ScheduleNote { get; set; }
		/// <summary>
		/// 상품비고
		/// </summary>
		[Description("상품비고")]
		public string ProductNote { get; set; }
		/// <summary>
		/// 영업비고
		/// </summary>
		[Description("영업비고")]
		public string BusinessNote { get; set; }
		/// <summary>
		/// 기준단체번호
		/// </summary>
		[Description("기준단체번호")]
		public int StandardGroupNumber { get; set; }
		/// <summary>
		/// 첨부파일
		/// </summary>
		[Description("첨부파일")]
		public string AttachFile { get; set; }
		/// <summary>
		/// 수정자
		/// </summary>
		[Description("수정자")]
		public int Editor { get; set; }
		/// <summary>
		/// 영업입금가
		/// </summary>
		[Description("영업입금가")]
		public int BusinessDepositPrice { get; set; }
		/// <summary>
		/// 랜드일정전송
		/// </summary>
		[Description("랜드일정전송")]
		public string LandScheduleSending { get; set; }
		/// <summary>
		/// 최종선정랜드사
		/// </summary>
		[Description("최종선정랜드사")]
		public string FinalSelectionLandCompany { get; set; }
		/// <summary>
		/// 기준환율
		/// </summary>
		[Description("기준환율")]
		public decimal StandardExchangeRate { get; set; }
		/// <summary>
		/// 호텔사항_상품
		/// </summary>
		[Description("호텔사항_상품")]
		public string HotelItem_Product { get; set; }
		/// <summary>
		/// 포함사항_상품
		/// </summary>
		[Description("포함사항_상품")]
		public string IncludedItem_Product { get; set; }
		/// <summary>
		/// 불포함사항_상품
		/// </summary>
		[Description("불포함사항_상품")]
		public string UnincludedItem_Product { get; set; }
		/// <summary>
		/// 특전사항_상품
		/// </summary>
		[Description("특전사항_상품")]
		public string SpecialEventItem_Product { get; set; }
		/// <summary>
		/// 쇼핑사항_상품
		/// </summary>
		[Description("쇼핑사항_상품")]
		public string ShoppingItem_Product { get; set; }
		/// <summary>
		/// 랜드일정_상품
		/// </summary>
		[Description("랜드일정_상품")]
		public string LandSchedule_Product { get; set; }
		/// <summary>
		/// 영업OP부서
		/// </summary>
		[Description("영업OP부서")]
		public int Business_OP_Department { get; set; }
		/// <summary>
		/// 영업OP
		/// </summary>
		[Description("영업OP")]
		public int Business_OP { get; set; }
		/// <summary>
		/// 유류할증료
		/// </summary>
		[Description("유류할증료")]
		public int FuelSurchargeFee { get; set; }
		/// <summary>
		/// 보험료
		/// </summary>
		[Description("보험료")]
		public int InsuranceFee { get; set; }
		/// <summary>
		/// 첨부파일_상품부서
		/// </summary>
		[Description("첨부파일_상품부서")]
		public string AttachFile_ProductDepartment { get; set; }
		/// <summary>
		/// 요청자
		/// </summary>
		[Description("요청자")]
		public int Requester { get; set; }
		/// <summary>
		/// 영업부개인메모
		/// </summary>
		[Description("영업부개인메모")]
		public string BusinessUnpersonalMemo { get; set; }
		/// <summary>
		/// 영업수익률자동여부
		/// </summary>
		[Description("영업수익률자동여부")]
		public string BusinessProfitPercentAutomaticOrNot { get; set; }
		/// <summary>
		/// 영업수익률자동비율
		/// </summary>
		[Description("영업수익률자동비율")]
		public decimal BusinessProfitPercentAutomaticPercentage { get; set; }
		/// <summary>
		/// 확정단체번호
		/// </summary>
		[Description("확정단체번호")]
		public int ConfirmGroupNumber { get; set; }
		/// <summary>
		/// TC
		/// </summary>
		[Description("TC")]
		public int TC { get; set; }
		/// <summary>
		/// 판매가
		/// </summary>
		[Description("판매가")]
		public int SellingPrice { get; set; }
		/// <summary>
		/// 인센단체명
		/// </summary>
		[Description("인센단체명")]
		public string IncentiveGroupName { get; set; }
		/// <summary>
		/// 진행결렬사유
		/// </summary>
		[Description("진행결렬사유")]
		public string ProgressBreakdownReason { get; set; }
		/// <summary>
		/// 요청자명
		/// </summary>
		[Description("요청자명")]
		public string RequesterName { get; set; }
		/// <summary>
		/// 요청자_연락처
		/// </summary>
		[Description("요청자_연락처")]
		public string Requester_Contact { get; set; }
		/// <summary>
		/// 요청자_이메일
		/// </summary>
		[Description("요청자_이메일")]
		public string Requester_Email { get; set; }
		/// <summary>
		/// 상품부개인메모
		/// </summary>
		[Description("상품부개인메모")]
		public string ProductDepartmentPersonalMemo { get; set; }
		/// <summary>
		/// WEB
		/// </summary>
		[Description("WEB")]
		public string WEB { get; set; }
		/// <summary>
		/// WEBTEST
		/// </summary>
		[Description("WEBTEST")]
		public string WEBTEST { get; set; }
		/// <summary>
		/// 메인번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("메인번호")]
		public int MainNumber { get; set; }
		/// <summary>
		/// 영업지원부서
		/// </summary>
		[Description("영업지원부서")]
		public int BusinessSupportDepartment { get; set; }
		/// <summary>
		/// 영업지원
		/// </summary>
		[Description("영업지원")]
		public int BusinessSupport { get; set; }
		/// <summary>
		/// 핵심요청사항
		/// </summary>
		[Description("핵심요청사항")]
		public string CoreRequest { get; set; }
		/// <summary>
		/// 항공중간구간
		/// </summary>
		[Description("항공중간구간")]
		public string FlightMiddleCity { get; set; }
		/// <summary>
		/// 웹사이트번호
		/// </summary>
		[Description("웹사이트번호")]
		public int WebSiteNumber { get; set; }
		/// <summary>
		/// 기업포상
		/// </summary>
		[Description("기업포상")]
		public string BusinessReward { get; set; }
		/// <summary>
		/// 전시박람회
		/// </summary>
		[Description("전시박람회")]
		public string ShowingExhibition { get; set; }
		/// <summary>
		/// 문화체육관람
		/// </summary>
		[Description("문화체육관람")]
		public string CulturesAndSportsWatching { get; set; }
		/// <summary>
		/// 다국적멀티일정
		/// </summary>
		[Description("다국적멀티일정")]
		public string MultinationalMultiSchedule { get; set; }
		/// <summary>
		/// 음향시설
		/// </summary>
		[Description("음향시설")]
		public string SoundFacilities { get; set; }
		/// <summary>
		/// 프로젝트빔
		/// </summary>
		[Description("프로젝트빔")]
		public string ProjectBeam { get; set; }
		/// <summary>
		/// 세부견적서
		/// </summary>
		[Description("세부견적서")]
		public string DetailEstimateForm { get; set; }
		/// <summary>
		/// 세부일정표
		/// </summary>
		[Description("세부일정표")]
		public string DetailScheduleTable { get; set; }
		/// <summary>
		/// PW
		/// </summary>
		[Description("PW")]
		public string PW { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Description("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 첨부파일_대리점전달
		/// </summary>
		[Description("첨부파일_대리점전달")]
		public string AttachFile_AgencySending { get; set; }
		/// <summary>
		/// 프로모션사용여부
		/// </summary>
		[Description("프로모션사용여부")]
		public string PromotionUseOrNot { get; set; }
		/// <summary>
		/// 프로모션마스터번호
		/// </summary>
		[Description("프로모션마스터번호")]
		public int PromotionMasterNumber { get; set; }
		/// <summary>
		/// 추가마케팅비용
		/// </summary>
		[Description("추가마케팅비용")]
		public long AddMarketingExpense { get; set; }
		/// <summary>
		/// 관심견적_영업
		/// </summary>
		[Description("관심견적_영업")]
		public string InterestingEstimate_Business { get; set; }
		/// <summary>
		/// 관심견적_상품
		/// </summary>
		[Description("관심견적_상품")]
		public string InterestingEstimate_Product { get; set; }
		/// <summary>
		/// 최종랜드선정여부
		/// </summary>
		[Description("최종랜드선정여부")]
		public string FinalLandSelectionOrNot { get; set; }
		/// <summary>
		/// 영업코디메모
		/// </summary>
		[Description("영업코디메모")]
		public string BusinessCoordinationMemo { get; set; }
		/// <summary>
		/// 영업코디입금가
		/// </summary>
		[Description("영업코디입금가")]
		public long BusinessCoordinationDepositPrice { get; set; }
		/// <summary>
		/// 영업코디부서
		/// </summary>
		[Description("영업코디부서")]
		public int BusinessCoordinationDepartment { get; set; }
		/// <summary>
		/// 영업코디
		/// </summary>
		[Description("영업코디")]
		public int BusinessCoordination { get; set; }
		/// <summary>
		/// 저장경로
		/// </summary>
		[Description("저장경로")]
		public string SavingRoute { get; set; }
		/// <summary>
		/// SB사용제한권고
		/// </summary>
		[Description("SB사용제한권고")]
		public string SB_UseLimitRecommendation { get; set; }
		/// <summary>
		/// 마케팅동의여부
		/// </summary>
		[Description("마케팅동의여부")]
		public string MarketingAgreeOrNot { get; set; }
	}

}