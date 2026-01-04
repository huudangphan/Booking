namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_인센티브_견적상세
/// </summary>
public class WSP_S_CMN_Incentive_EstimateDetail
{
	public const string SP_NAME = "WSP_S_CMN_인센티브_견적상세";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// TYPE
		/// </summary>
		[Description("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// PWD
		/// </summary>
		[Description("PWD")]
		public string PWD { get; set; }
		/// <summary>
		/// IDX
		/// </summary>
		[Description("IDX")]
		public int IDX { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// ADMIN
		/// </summary>
		[Column("ADMIN")]
		public string ADMIN { get; set; }
		/// <summary>
		/// 마스터일련번호
		/// </summary>
		[Column("마스터일련번호")]
		public int MasterSerialNumber { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Column("지역")]
		public string Region { get; set; }
		/// <summary>
		/// 대표도시
		/// </summary>
		[Column("대표도시")]
		public int RepresentativeCity { get; set; }
		/// <summary>
		/// 대표국가
		/// </summary>
		[Column("대표국가")]
		public int RepresentativeCountry { get; set; }
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
		/// 인원비고
		/// </summary>
		[Column("인원비고")]
		public string NumberOfPeopleNote { get; set; }
		/// <summary>
		/// TC
		/// </summary>
		[Column("TC")]
		public int TC { get; set; }
		/// <summary>
		/// 기타요청사항
		/// </summary>
		[Column("기타요청사항")]
		public string OtherRequest { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// PW
		/// </summary>
		[Column("PW")]
		public string PW { get; set; }
		/// <summary>
		/// 첨부파일
		/// </summary>
		[Column("첨부파일")]
		public string AttachFile { get; set; }
		/// <summary>
		/// 견적상태
		/// </summary>
		[Column("견적상태")]
		public string EstimateState { get; set; }
		/// <summary>
		/// 영업부서
		/// </summary>
		[Column("영업부서")]
		public int BusinessDepartment { get; set; }
		/// <summary>
		/// 희망일인요금
		/// </summary>
		[Column("희망일인요금")]
		public int DesiredSingleFare { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
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
		/// 지역1
		/// </summary>
		[Column("지역1")]
		public string Region1 { get; set; }
		/// <summary>
		/// 대표국가1
		/// </summary>
		[Column("대표국가1")]
		public int RepresentativeCountry1 { get; set; }
		/// <summary>
		/// 대표도시1
		/// </summary>
		[Column("대표도시1")]
		public int RepresentativeCity1 { get; set; }
		/// <summary>
		/// 견적종류
		/// </summary>
		[Column("견적종류")]
		public string EstimateType { get; set; }
		/// <summary>
		/// 팁포함여부
		/// </summary>
		[Column("팁포함여부")]
		public string TipIncludedOrNot { get; set; }
		/// <summary>
		/// 요청구분
		/// </summary>
		[Column("요청구분")]
		public string RequestClassification { get; set; }
		/// <summary>
		/// 추가요금
		/// </summary>
		[Column("추가요금")]
		public int AddFare { get; set; }
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
		/// 견적상태1
		/// </summary>
		[Column("견적상태1")]
		public string EstimateState1 { get; set; }
		/// <summary>
		/// 대표국가명
		/// </summary>
		[Column("대표국가명")]
		public string RepresentativeCountryName { get; set; }
		/// <summary>
		/// 대표도시명
		/// </summary>
		[Column("대표도시명")]
		public string RepresentativeCityName { get; set; }
		/// <summary>
		/// 여행지역경로
		/// </summary>
		[Column("여행지역경로")]
		public string TravelRegionRoute { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// ADMIN
		/// </summary>
		[Column("ADMIN")]
		public string ADMIN { get; set; }
		/// <summary>
		/// Etcno
		/// </summary>
		[Column("Etcno")]
		public int Etcno { get; set; }
		/// <summary>
		/// 문의종류
		/// </summary>
		[Column("문의종류")]
		public string InquiryType { get; set; }
		/// <summary>
		/// 요청자
		/// </summary>
		[Column("요청자")]
		public string Requester { get; set; }
		/// <summary>
		/// 핸드폰
		/// </summary>
		[Column("핸드폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Column("비밀번호")]
		public string Password { get; set; }
		/// <summary>
		/// 요청일
		/// </summary>
		[Column("요청일")]
		public DateTime RequestDate { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Column("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Column("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 문의내용
		/// </summary>
		[Column("문의내용")]
		public string InquiryContent { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 견적상태
		/// </summary>
		[Column("견적상태")]
		public string EstimateState { get; set; }
		/// <summary>
		/// 마케팅동의여부
		/// </summary>
		[Column("마케팅동의여부")]
		public string MarketingAgreeOrNot { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// ADMIN
		/// </summary>
		[Column("ADMIN")]
		public string ADMIN { get; set; }
		/// <summary>
		/// 마스터일련번호
		/// </summary>
		[Column("마스터일련번호")]
		public int MasterSerialNumber { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Column("지역")]
		public string Region { get; set; }
		/// <summary>
		/// 대표도시
		/// </summary>
		[Column("대표도시")]
		public int RepresentativeCity { get; set; }
		/// <summary>
		/// 대표국가
		/// </summary>
		[Column("대표국가")]
		public int RepresentativeCountry { get; set; }
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
		/// 인원비고
		/// </summary>
		[Column("인원비고")]
		public string NumberOfPeopleNote { get; set; }
		/// <summary>
		/// TC
		/// </summary>
		[Column("TC")]
		public int TC { get; set; }
		/// <summary>
		/// 기타요청사항
		/// </summary>
		[Column("기타요청사항")]
		public string OtherRequest { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// PW
		/// </summary>
		[Column("PW")]
		public string PW { get; set; }
		/// <summary>
		/// 첨부파일
		/// </summary>
		[Column("첨부파일")]
		public string AttachFile { get; set; }
		/// <summary>
		/// 견적상태
		/// </summary>
		[Column("견적상태")]
		public string EstimateState { get; set; }
		/// <summary>
		/// 영업부서
		/// </summary>
		[Column("영업부서")]
		public int BusinessDepartment { get; set; }
		/// <summary>
		/// 희망일인요금
		/// </summary>
		[Column("희망일인요금")]
		public int DesiredSingleFare { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
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
		/// 지역1
		/// </summary>
		[Column("지역1")]
		public string Region1 { get; set; }
		/// <summary>
		/// 대표국가1
		/// </summary>
		[Column("대표국가1")]
		public int RepresentativeCountry1 { get; set; }
		/// <summary>
		/// 대표도시1
		/// </summary>
		[Column("대표도시1")]
		public int RepresentativeCity1 { get; set; }
		/// <summary>
		/// 견적종류
		/// </summary>
		[Column("견적종류")]
		public string EstimateType { get; set; }
		/// <summary>
		/// 팁포함여부
		/// </summary>
		[Column("팁포함여부")]
		public string TipIncludedOrNot { get; set; }
		/// <summary>
		/// 요청구분
		/// </summary>
		[Column("요청구분")]
		public string RequestClassification { get; set; }
		/// <summary>
		/// 추가요금
		/// </summary>
		[Column("추가요금")]
		public int AddFare { get; set; }
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
		/// 견적상태1
		/// </summary>
		[Column("견적상태1")]
		public string EstimateState1 { get; set; }
		/// <summary>
		/// 대표국가명
		/// </summary>
		[Column("대표국가명")]
		public string RepresentativeCountryName { get; set; }
		/// <summary>
		/// 대표도시명
		/// </summary>
		[Column("대표도시명")]
		public string RepresentativeCityName { get; set; }
	}
}