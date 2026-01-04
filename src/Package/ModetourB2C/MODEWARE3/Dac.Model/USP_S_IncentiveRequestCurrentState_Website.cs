namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_인센티브요청현황_웹사이트
/// </summary>
public class USP_S_IncentiveRequestCurrentState_Website
{
	public const string SP_NAME = "USP_S_인센티브요청현황_웹사이트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 시작일
		/// </summary>
		[Description("시작일")]
		public DateTime StartDate { get; set; }
		/// <summary>
		/// 종료일
		/// </summary>
		[Description("종료일")]
		public DateTime EndDate { get; set; }
		/// <summary>
		/// 웹사이트번호
		/// </summary>
		[Description("웹사이트번호")]
		public int WebSiteNumber { get; set; }
	}

	public class Result : IDbResult
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
		/// 단체성격
		/// </summary>
		[Column("단체성격")]
		public string GroupCharacter { get; set; }
		/// <summary>
		/// 웹사이트
		/// </summary>
		[Column("웹사이트")]
		public string WebSite { get; set; }
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
		/// 첨부파일
		/// </summary>
		[Column("첨부파일")]
		public string AttachFile { get; set; }
		/// <summary>
		/// 희망일인요금
		/// </summary>
		[Column("희망일인요금")]
		public int DesiredSingleFare { get; set; }
		/// <summary>
		/// 호텔
		/// </summary>
		[Column("호텔")]
		public string Hotel { get; set; }
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
	}
}