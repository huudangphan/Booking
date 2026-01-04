namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_인센티브마스터_WEMODE_견적상세
/// </summary>
public class WSP_S_CMN_IncentiveMaster_WEMODE_EstimateDetail
{
	public const string SP_NAME = "WSP_S_CMN_인센티브마스터_WEMODE_견적상세";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 메인번호
		/// </summary>
		[Description("메인번호")]
		public int MainNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 메인번호
		/// </summary>
		[Column("메인번호")]
		public int MainNumber { get; set; }
		/// <summary>
		/// 마스터일련번호
		/// </summary>
		[Column("마스터일련번호")]
		public int MasterSerialNumber { get; set; }
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
		/// 지역
		/// </summary>
		[Column("지역")]
		public string Region { get; set; }
		/// <summary>
		/// 대표국가
		/// </summary>
		[Column("대표국가")]
		public int RepresentativeCountry { get; set; }
		/// <summary>
		/// 대표도시
		/// </summary>
		[Column("대표도시")]
		public int RepresentativeCity { get; set; }
		/// <summary>
		/// 경로
		/// </summary>
		[Column("경로")]
		public string Route { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public DateTime DepartureDate { get; set; }
		/// <summary>
		/// 도착일
		/// </summary>
		[Column("도착일")]
		public DateTime ArrivalDate { get; set; }
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
		/// 단체성격
		/// </summary>
		[Column("단체성격")]
		public string GroupCharacter { get; set; }
		/// <summary>
		/// 호텔
		/// </summary>
		[Column("호텔")]
		public string Hotel { get; set; }
		/// <summary>
		/// 희망견적요금
		/// </summary>
		[Column("희망견적요금")]
		public int DesiredEstimateFare { get; set; }
		/// <summary>
		/// 일정비고
		/// </summary>
		[Column("일정비고")]
		public string ScheduleNote { get; set; }
		/// <summary>
		/// 기타요청사항
		/// </summary>
		[Column("기타요청사항")]
		public string OtherRequest { get; set; }
		/// <summary>
		/// PW
		/// </summary>
		[Column("PW")]
		public string PW { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 요청자
		/// </summary>
		[Column("요청자")]
		public int Requester { get; set; }
		/// <summary>
		/// 요청자명
		/// </summary>
		[Column("요청자명")]
		public string RequesterName { get; set; }
		/// <summary>
		/// 요청자_연락처
		/// </summary>
		[Column("요청자_연락처")]
		public string Requester_Contact { get; set; }
		/// <summary>
		/// 요청자_이메일
		/// </summary>
		[Column("요청자_이메일")]
		public string Requester_Email { get; set; }
		/// <summary>
		/// 견적상태
		/// </summary>
		[Column("견적상태")]
		public string EstimateState { get; set; }
	}

	public class Result2 : IDbResult
	{
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
		public int BusinessDepartment { get; set; }
		/// <summary>
		/// 영업담당자
		/// </summary>
		[Column("영업담당자")]
		public int BusinessManager { get; set; }
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
		public int RepresentativeCountry { get; set; }
		/// <summary>
		/// 대표도시
		/// </summary>
		[Column("대표도시")]
		public int RepresentativeCity { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public DateTime DepartureDate { get; set; }
		/// <summary>
		/// 도착일
		/// </summary>
		[Column("도착일")]
		public DateTime ArrivalDate { get; set; }
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
		/// 요청일자
		/// </summary>
		[Column("요청일자")]
		public DateTime RequestDate { get; set; }
		/// <summary>
		/// 상품부서
		/// </summary>
		[Column("상품부서")]
		public int ProductDepartment { get; set; }
		/// <summary>
		/// 상품담당자
		/// </summary>
		[Column("상품담당자")]
		public int ProductManager { get; set; }
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
		public DateTime ProductReceiptDate { get; set; }
		/// <summary>
		/// 상품완료일
		/// </summary>
		[Column("상품완료일")]
		public DateTime ProductFinishDate { get; set; }
		/// <summary>
		/// 영업접수일
		/// </summary>
		[Column("영업접수일")]
		public DateTime BusinessReceiptDate { get; set; }
		/// <summary>
		/// 영업완료일
		/// </summary>
		[Column("영업완료일")]
		public DateTime BusinessFinishDate { get; set; }
		/// <summary>
		/// 최종수정일
		/// </summary>
		[Column("최종수정일")]
		public DateTime FinalEditionDate { get; set; }
		/// <summary>
		/// 단체성격
		/// </summary>
		[Column("단체성격")]
		public string GroupCharacter { get; set; }
		/// <summary>
		/// 희망일인요금
		/// </summary>
		[Column("희망일인요금")]
		public int DesiredSingleFare { get; set; }
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
		/// FOC
		/// </summary>
		[Column("FOC")]
		public int FOC { get; set; }
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
		/// 룸_더블
		/// </summary>
		[Column("룸_더블")]
		public int Room_Double { get; set; }
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
		/// 견적유효기간
		/// </summary>
		[Column("견적유효기간")]
		public DateTime EstimateValidPeriod { get; set; }
		/// <summary>
		/// 기준단체번호
		/// </summary>
		[Column("기준단체번호")]
		public int StandardGroupNumber { get; set; }
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
		/// 인솔자
		/// </summary>
		[Column("인솔자")]
		public string Leader { get; set; }
		/// <summary>
		/// 일정비고
		/// </summary>
		[Column("일정비고")]
		public string ScheduleNote { get; set; }
		/// <summary>
		/// 첨부파일
		/// </summary>
		[Column("첨부파일")]
		public string AttachFile { get; set; }
		/// <summary>
		/// 웹페이지번호
		/// </summary>
		[Column("웹페이지번호")]
		public int WebPageNumber { get; set; }
		/// <summary>
		/// 영업입금가
		/// </summary>
		[Column("영업입금가")]
		public int BusinessDepositPrice { get; set; }
		/// <summary>
		/// 랜드일정전송
		/// </summary>
		[Column("랜드일정전송")]
		public string LandScheduleSending { get; set; }
		/// <summary>
		/// 인당지상비
		/// </summary>
		[Column("인당지상비")]
		public int EachPersonLocalFee { get; set; }
		/// <summary>
		/// 기준환율
		/// </summary>
		[Column("기준환율")]
		public decimal StandardExchangeRate { get; set; }
		/// <summary>
		/// 영업OP부서
		/// </summary>
		[Column("영업OP부서")]
		public int Business_OP_Department { get; set; }
		/// <summary>
		/// 영업OP
		/// </summary>
		[Column("영업OP")]
		public int Business_OP { get; set; }
		/// <summary>
		/// 유류할증료
		/// </summary>
		[Column("유류할증료")]
		public long FuelSurchargeFee { get; set; }
		/// <summary>
		/// 보험료
		/// </summary>
		[Column("보험료")]
		public long InsuranceFee { get; set; }
		/// <summary>
		/// 첨부파일_상품부서
		/// </summary>
		[Column("첨부파일_상품부서")]
		public string AttachFile_ProductDepartment { get; set; }
		/// <summary>
		/// 요청자
		/// </summary>
		[Column("요청자")]
		public int Requester { get; set; }
		/// <summary>
		/// 메모수
		/// </summary>
		[Column("메모수")]
		public int MemoCount { get; set; }
		/// <summary>
		/// 영업부개인메모
		/// </summary>
		[Column("영업부개인메모")]
		public string BusinessUnpersonalMemo { get; set; }
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
		/// 확정단체번호
		/// </summary>
		[Column("확정단체번호")]
		public int ConfirmGroupNumber { get; set; }
		/// <summary>
		/// TC
		/// </summary>
		[Column("TC")]
		public int TC { get; set; }
		/// <summary>
		/// 판매가
		/// </summary>
		[Column("판매가")]
		public int SellingPrice { get; set; }
		/// <summary>
		/// 영업소팀
		/// </summary>
		[Column("영업소팀")]
		public int BusinessSubTeam { get; set; }
		/// <summary>
		/// 상품단독견적처리
		/// </summary>
		[Column("상품단독견적처리")]
		public string ProductSoloEstimateHandle { get; set; }
		/// <summary>
		/// 인센단체명
		/// </summary>
		[Column("인센단체명")]
		public string IncentiveGroupName { get; set; }
		/// <summary>
		/// 진행결렬사유
		/// </summary>
		[Column("진행결렬사유")]
		public string ProgressBreakdownReason { get; set; }
		/// <summary>
		/// 요청자명
		/// </summary>
		[Column("요청자명")]
		public string RequesterName { get; set; }
		/// <summary>
		/// 요청자_연락처
		/// </summary>
		[Column("요청자_연락처")]
		public string Requester_Contact { get; set; }
		/// <summary>
		/// 요청자_이메일
		/// </summary>
		[Column("요청자_이메일")]
		public string Requester_Email { get; set; }
		/// <summary>
		/// 상품부개인메모
		/// </summary>
		[Column("상품부개인메모")]
		public string ProductDepartmentPersonalMemo { get; set; }
		/// <summary>
		/// WEB
		/// </summary>
		[Column("WEB")]
		public string WEB { get; set; }
		/// <summary>
		/// 메인번호
		/// </summary>
		[Column("메인번호")]
		public int MainNumber { get; set; }
		/// <summary>
		/// 핵심요청사항
		/// </summary>
		[Column("핵심요청사항")]
		public string CoreRequest { get; set; }
		/// <summary>
		/// 항공중간구간
		/// </summary>
		[Column("항공중간구간")]
		public string FlightMiddleCity { get; set; }
		/// <summary>
		/// 최종랜드선정여부
		/// </summary>
		[Column("최종랜드선정여부")]
		public string FinalLandSelectionOrNot { get; set; }
		/// <summary>
		/// 고객견적접수일
		/// </summary>
		[Column("고객견적접수일")]
		public DateTime CustomerEstimateReceiptDate { get; set; }
		/// <summary>
		/// 웹사이트번호
		/// </summary>
		[Column("웹사이트번호")]
		public int WebSiteNumber { get; set; }
		/// <summary>
		/// SOS
		/// </summary>
		[Column("SOS")]
		public string SOS { get; set; }
		/// <summary>
		/// 기업포상
		/// </summary>
		[Column("기업포상")]
		public string BusinessReward { get; set; }
		/// <summary>
		/// 전시박람회
		/// </summary>
		[Column("전시박람회")]
		public string ShowingExhibition { get; set; }
		/// <summary>
		/// 문화체육관람
		/// </summary>
		[Column("문화체육관람")]
		public string CulturesAndSportsWatching { get; set; }
		/// <summary>
		/// 다국적멀티일정
		/// </summary>
		[Column("다국적멀티일정")]
		public string MultinationalMultiSchedule { get; set; }
		/// <summary>
		/// 음향시설
		/// </summary>
		[Column("음향시설")]
		public string SoundFacilities { get; set; }
		/// <summary>
		/// 프로젝트빔
		/// </summary>
		[Column("프로젝트빔")]
		public string ProjectBeam { get; set; }
		/// <summary>
		/// 세부견적서
		/// </summary>
		[Column("세부견적서")]
		public string DetailEstimateForm { get; set; }
		/// <summary>
		/// 세부일정표
		/// </summary>
		[Column("세부일정표")]
		public string DetailScheduleTable { get; set; }
		/// <summary>
		/// PW
		/// </summary>
		[Column("PW")]
		public string PW { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 모두투어노출여부
		/// </summary>
		[Column("모두투어노출여부")]
		public string MODETOURDisplayOrNot { get; set; }
		/// <summary>
		/// 공항미팅여부
		/// </summary>
		[Column("공항미팅여부")]
		public string AirportMeetingOrNot { get; set; }
		/// <summary>
		/// 비즈모드견적여부
		/// </summary>
		[Column("비즈모드견적여부")]
		public string BusinessModeEstimateOrNot { get; set; }
		/// <summary>
		/// 첨부파일_대리점전달
		/// </summary>
		[Column("첨부파일_대리점전달")]
		public string AttachFile_AgencySending { get; set; }
		/// <summary>
		/// 프로모션사용여부
		/// </summary>
		[Column("프로모션사용여부")]
		public string PromotionUseOrNot { get; set; }
		/// <summary>
		/// 프로모션마스터번호
		/// </summary>
		[Column("프로모션마스터번호")]
		public int PromotionMasterNumber { get; set; }
		/// <summary>
		/// 추가마케팅비용
		/// </summary>
		[Column("추가마케팅비용")]
		public long AddMarketingExpense { get; set; }
		/// <summary>
		/// 관심견적_영업
		/// </summary>
		[Column("관심견적_영업")]
		public string InterestingEstimate_Business { get; set; }
		/// <summary>
		/// 관심견적_상품
		/// </summary>
		[Column("관심견적_상품")]
		public string InterestingEstimate_Product { get; set; }
		/// <summary>
		/// 영업코디메모
		/// </summary>
		[Column("영업코디메모")]
		public string BusinessCoordinationMemo { get; set; }
		/// <summary>
		/// 영업코디입금가
		/// </summary>
		[Column("영업코디입금가")]
		public long BusinessCoordinationDepositPrice { get; set; }
		/// <summary>
		/// 항공코디
		/// </summary>
		[Column("항공코디")]
		public int FlightCoordination { get; set; }
		/// <summary>
		/// SB사용제한권고
		/// </summary>
		[Column("SB사용제한권고")]
		public string SB_UseLimitRecommendation { get; set; }
		/// <summary>
		/// 마케팅동의여부
		/// </summary>
		[Column("마케팅동의여부")]
		public string MarketingAgreeOrNot { get; set; }
	}
}