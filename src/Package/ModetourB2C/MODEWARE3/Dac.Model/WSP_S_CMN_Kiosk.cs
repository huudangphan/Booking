namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_키오스크
/// </summary>
public class WSP_S_CMN_Kiosk
{
	public const string SP_NAME = "WSP_S_CMN_키오스크";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// TYPE
		/// </summary>
		[Description("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// 기기번호
		/// </summary>
		[Description("기기번호")]
		public int EquipmentNumber { get; set; }
		/// <summary>
		/// 기획전번호
		/// </summary>
		[Description("기획전번호")]
		public int SpecialEventNumber { get; set; }
		/// <summary>
		/// 특선상품번호
		/// </summary>
		[Description("특선상품번호")]
		public int SpecialSelectionProductNumber { get; set; }
		/// <summary>
		/// 웹지역번호
		/// </summary>
		[Description("웹지역번호")]
		public string WebRegionNumber { get; set; }
		/// <summary>
		/// 웹테마번호
		/// </summary>
		[Description("웹테마번호")]
		public string WebThemeNumber { get; set; }
		/// <summary>
		/// RCODE
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 4)]
		[Description("RCODE")]
		public string RCODE { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 스트리밍여부
		/// </summary>
		[Column("스트리밍여부")]
		public string StreamingOrNot { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 기기번호
		/// </summary>
		[Column("기기번호")]
		public int EquipmentNumber { get; set; }
		/// <summary>
		/// 대기모드_진입시간
		/// </summary>
		[Column("대기모드_진입시간")]
		public int WaitingMode_EnteringTime { get; set; }
		/// <summary>
		/// 타입
		/// </summary>
		[Column("타입")]
		public string Type { get; set; }
		/// <summary>
		/// 노출시간
		/// </summary>
		[Column("노출시간")]
		public int DisplayTime { get; set; }
		/// <summary>
		/// 이벤트명
		/// </summary>
		[Column("이벤트명")]
		public string EventName { get; set; }
		/// <summary>
		/// URL
		/// </summary>
		[Column("URL")]
		public string URL { get; set; }
		/// <summary>
		/// 반영일
		/// </summary>
		[Column("반영일")]
		public string ReflectDate { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Column("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 거래처명
		/// </summary>
		[Column("거래처명")]
		public string CustomerName { get; set; }
		/// <summary>
		/// 연락처
		/// </summary>
		[Column("연락처")]
		public string Contact { get; set; }
		/// <summary>
		/// 상단배너경로
		/// </summary>
		[Column("상단배너경로")]
		public string TopBannerRoute { get; set; }
		/// <summary>
		/// 하단배너경로
		/// </summary>
		[Column("하단배너경로")]
		public string BottomBannerRoute { get; set; }
		/// <summary>
		/// 대기모드
		/// </summary>
		[Column("대기모드")]
		public int WaitingMode { get; set; }
		/// <summary>
		/// 기기번호
		/// </summary>
		[Column("기기번호")]
		public int EquipmentNumber { get; set; }
		/// <summary>
		/// 폰트타입코드
		/// </summary>
		[Column("폰트타입코드")]
		public string FontTypeCode { get; set; }
		/// <summary>
		/// 카테고리명
		/// </summary>
		[Column("카테고리명")]
		public string CategoryName { get; set; }
		/// <summary>
		/// 서브타이틀
		/// </summary>
		[Column("서브타이틀")]
		public string SubTitle { get; set; }
		/// <summary>
		/// 기획전번호
		/// </summary>
		[Column("기획전번호")]
		public int SpecialEventNumber { get; set; }
		/// <summary>
		/// 기획전_키오스크이미지경로
		/// </summary>
		[Column("기획전_키오스크이미지경로")]
		public string SpecialEvent_KioskImageRoute { get; set; }
		/// <summary>
		/// 기획전_메인_섬네일
		/// </summary>
		[Column("기획전_메인_섬네일")]
		public string SpecialEvent_Main_Thumbnail { get; set; }
		/// <summary>
		/// 노출순서
		/// </summary>
		[Column("노출순서")]
		public int DisplayOrder { get; set; }
		/// <summary>
		/// 하단배너일련번호
		/// </summary>
		[Column("하단배너일련번호")]
		public int BottomBannerSerialNumber { get; set; }
		/// <summary>
		/// BID
		/// </summary>
		[Column("BID")]
		public int BID { get; set; }
		/// <summary>
		/// 템플릿타입코드
		/// </summary>
		[Column("템플릿타입코드")]
		public string TemplateTypeCode { get; set; }
		/// <summary>
		/// 배경이미지타입코드
		/// </summary>
		[Column("배경이미지타입코드")]
		public string BackgroundImageTypeCode { get; set; }
		/// <summary>
		/// 배경이미지경로
		/// </summary>
		[Column("배경이미지경로")]
		public string BackgroundImageRoute { get; set; }
		/// <summary>
		/// 폰트색상
		/// </summary>
		[Column("폰트색상")]
		public string FontColor { get; set; }
		/// <summary>
		/// 상단문구
		/// </summary>
		[Column("상단문구")]
		public string TopWords { get; set; }
		/// <summary>
		/// 중간문구
		/// </summary>
		[Column("중간문구")]
		public string MiddleWords { get; set; }
		/// <summary>
		/// 하단문구
		/// </summary>
		[Column("하단문구")]
		public string BottomWords { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Column("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 거래처상담원
		/// </summary>
		[Column("거래처상담원")]
		public int CustomerConsultant { get; set; }
		/// <summary>
		/// 거래처명
		/// </summary>
		[Column("거래처명")]
		public string CustomerName { get; set; }
		/// <summary>
		/// 연락처
		/// </summary>
		[Column("연락처")]
		public string Contact { get; set; }
		/// <summary>
		/// 상단배너경로
		/// </summary>
		[Column("상단배너경로")]
		public string TopBannerRoute { get; set; }
		/// <summary>
		/// 하단배너경로
		/// </summary>
		[Column("하단배너경로")]
		public string BottomBannerRoute { get; set; }
		/// <summary>
		/// 대기모드
		/// </summary>
		[Column("대기모드")]
		public int WaitingMode { get; set; }
		/// <summary>
		/// PREVIDX
		/// </summary>
		[Column("PREVIDX")]
		public int PREVIDX { get; set; }
		/// <summary>
		/// NEXTIDX
		/// </summary>
		[Column("NEXTIDX")]
		public int NEXTIDX { get; set; }
		/// <summary>
		/// 기기명
		/// </summary>
		[Column("기기명")]
		public string EquipmentName { get; set; }
		/// <summary>
		/// 기기번호
		/// </summary>
		[Column("기기번호")]
		public int EquipmentNumber { get; set; }
		/// <summary>
		/// 카테고리명
		/// </summary>
		[Column("카테고리명")]
		public string CategoryName { get; set; }
		/// <summary>
		/// 기획전_웹태그
		/// </summary>
		[Column("기획전_웹태그")]
		public string SpecialEvent_WebTag { get; set; }
		/// <summary>
		/// 기획전_웹_탭구분
		/// </summary>
		[Column("기획전_웹_탭구분")]
		public string SpecialEvent_Web_TabClassification { get; set; }
		/// <summary>
		/// 기획전_웹_상품템플릿
		/// </summary>
		[Column("기획전_웹_상품템플릿")]
		public string SpecialEvent_Web_ProductTemplate { get; set; }
		/// <summary>
		/// 하단배너일련번호
		/// </summary>
		[Column("하단배너일련번호")]
		public int BottomBannerSerialNumber { get; set; }
		/// <summary>
		/// BID
		/// </summary>
		[Column("BID")]
		public int BID { get; set; }
		/// <summary>
		/// 템플릿타입코드
		/// </summary>
		[Column("템플릿타입코드")]
		public string TemplateTypeCode { get; set; }
		/// <summary>
		/// 배경이미지타입코드
		/// </summary>
		[Column("배경이미지타입코드")]
		public string BackgroundImageTypeCode { get; set; }
		/// <summary>
		/// 배경이미지경로
		/// </summary>
		[Column("배경이미지경로")]
		public string BackgroundImageRoute { get; set; }
		/// <summary>
		/// 폰트색상
		/// </summary>
		[Column("폰트색상")]
		public string FontColor { get; set; }
		/// <summary>
		/// 상단문구
		/// </summary>
		[Column("상단문구")]
		public string TopWords { get; set; }
		/// <summary>
		/// 중간문구
		/// </summary>
		[Column("중간문구")]
		public string MiddleWords { get; set; }
		/// <summary>
		/// 하단문구
		/// </summary>
		[Column("하단문구")]
		public string BottomWords { get; set; }
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// 이벤트구역번호
		/// </summary>
		[Column("이벤트구역번호")]
		public int EventAreaNumber { get; set; }
		/// <summary>
		/// 위치
		/// </summary>
		[Column("위치")]
		public string Position { get; set; }
		/// <summary>
		/// 순서
		/// </summary>
		[Column("순서")]
		public int Order { get; set; }
	}

	public class Result6 : IDbResult
	{
		/// <summary>
		/// 구역번호
		/// </summary>
		[Column("구역번호")]
		public int AreaNumber { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 특선상품번호
		/// </summary>
		[Column("특선상품번호")]
		public int SpecialSelectionProductNumber { get; set; }
		/// <summary>
		/// 특가명
		/// </summary>
		[Column("특가명")]
		public string SpecialPriceName { get; set; }
		/// <summary>
		/// 이미지경로
		/// </summary>
		[Column("이미지경로")]
		public string ImageRoute { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 종류
		/// </summary>
		[Column("종류")]
		public string Type { get; set; }
		/// <summary>
		/// 순서
		/// </summary>
		[Column("순서")]
		public int Order { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 최소가격
		/// </summary>
		[Column("최소가격")]
		public long MinimumPrice { get; set; }
		/// <summary>
		/// 최대가격
		/// </summary>
		[Column("최대가격")]
		public long MaximumPrice { get; set; }
		/// <summary>
		/// 최소일수
		/// </summary>
		[Column("최소일수")]
		public int MinimumDaysNumber { get; set; }
		/// <summary>
		/// 최대일수
		/// </summary>
		[Column("최대일수")]
		public int MaximumDaysNumber { get; set; }
		/// <summary>
		/// 항공사
		/// </summary>
		[Column("항공사")]
		public string Airline { get; set; }
		/// <summary>
		/// 대표이미지
		/// </summary>
		[Column("대표이미지")]
		public string RepresentativeImage { get; set; }
	}

	public class Result7 : IDbResult
	{
		/// <summary>
		/// HASH_URL
		/// </summary>
		[Column("HASH_URL")]
		public string HASH_URL { get; set; }
	}

	public class Result8 : IDbResult
	{
		/// <summary>
		/// 출발요일
		/// </summary>
		[Column("출발요일")]
		public string DepartureDay { get; set; }
	}

	public class Result9 : IDbResult
	{
		/// <summary>
		/// 출발월
		/// </summary>
		[Column("출발월")]
		public int DepartureMonth { get; set; }
		/// <summary>
		/// 최저가격
		/// </summary>
		[Column("최저가격")]
		public long LowestPrice { get; set; }
	}

	public class Result10 : IDbResult
	{
		/// <summary>
		/// 특가명
		/// </summary>
		[Column("특가명")]
		public string SpecialPriceName { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 여행도시
		/// </summary>
		[Column("여행도시")]
		public string TravelCity { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 특전
		/// </summary>
		[Column("특전")]
		public string SpecialEvent { get; set; }
	}

	public class Result11 : IDbResult
	{
		/// <summary>
		/// 관광정보
		/// </summary>
		[Column("관광정보")]
		public string SightseeingInfo { get; set; }
		/// <summary>
		/// 지역정보
		/// </summary>
		[Column("지역정보")]
		public string RegionInfo { get; set; }
		/// <summary>
		/// 이미지
		/// </summary>
		[Column("이미지")]
		public string Image { get; set; }
	}

	public class Result12 : IDbResult
	{
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Column("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 거래처명
		/// </summary>
		[Column("거래처명")]
		public string CustomerName { get; set; }
		/// <summary>
		/// 연락처
		/// </summary>
		[Column("연락처")]
		public string Contact { get; set; }
		/// <summary>
		/// 기획전번호
		/// </summary>
		[Column("기획전번호")]
		public int SpecialEventNumber { get; set; }
		/// <summary>
		/// 기획전명
		/// </summary>
		[Column("기획전명")]
		public string SpecialEventName { get; set; }
		/// <summary>
		/// 배너
		/// </summary>
		[Column("배너")]
		public string Banner { get; set; }
		/// <summary>
		/// 게시시작일
		/// </summary>
		[Column("게시시작일")]
		public string PostStartDate { get; set; }
		/// <summary>
		/// 스페셜
		/// </summary>
		[Column("스페셜")]
		public string Special { get; set; }
		/// <summary>
		/// 지역리스트
		/// </summary>
		[Column("지역리스트")]
		public string RegionList { get; set; }
		/// <summary>
		/// 테마리스트
		/// </summary>
		[Column("테마리스트")]
		public string ThemeList { get; set; }
	}

	public class Result13 : IDbResult
	{
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Column("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 거래처상담원
		/// </summary>
		[Column("거래처상담원")]
		public int CustomerConsultant { get; set; }
		/// <summary>
		/// 거래처명
		/// </summary>
		[Column("거래처명")]
		public string CustomerName { get; set; }
		/// <summary>
		/// 연락처
		/// </summary>
		[Column("연락처")]
		public string Contact { get; set; }
		/// <summary>
		/// 상단배너경로
		/// </summary>
		[Column("상단배너경로")]
		public string TopBannerRoute { get; set; }
		/// <summary>
		/// 하단배너경로
		/// </summary>
		[Column("하단배너경로")]
		public string BottomBannerRoute { get; set; }
		/// <summary>
		/// 대기모드
		/// </summary>
		[Column("대기모드")]
		public int WaitingMode { get; set; }
		/// <summary>
		/// PREVIDX
		/// </summary>
		[Column("PREVIDX")]
		public int PREVIDX { get; set; }
		/// <summary>
		/// NEXTIDX
		/// </summary>
		[Column("NEXTIDX")]
		public int NEXTIDX { get; set; }
		/// <summary>
		/// 기기명
		/// </summary>
		[Column("기기명")]
		public string EquipmentName { get; set; }
		/// <summary>
		/// 기기번호
		/// </summary>
		[Column("기기번호")]
		public int EquipmentNumber { get; set; }
		/// <summary>
		/// 카테고리명
		/// </summary>
		[Column("카테고리명")]
		public string CategoryName { get; set; }
		/// <summary>
		/// 기획전_웹태그
		/// </summary>
		[Column("기획전_웹태그")]
		public string SpecialEvent_WebTag { get; set; }
		/// <summary>
		/// 기획전_웹_탭구분
		/// </summary>
		[Column("기획전_웹_탭구분")]
		public string SpecialEvent_Web_TabClassification { get; set; }
		/// <summary>
		/// 기획전_웹_상품템플릿
		/// </summary>
		[Column("기획전_웹_상품템플릿")]
		public string SpecialEvent_Web_ProductTemplate { get; set; }
		/// <summary>
		/// 게시시작일
		/// </summary>
		[Column("게시시작일")]
		public string PostStartDate { get; set; }
		/// <summary>
		/// 하단배너일련번호
		/// </summary>
		[Column("하단배너일련번호")]
		public int BottomBannerSerialNumber { get; set; }
		/// <summary>
		/// BID
		/// </summary>
		[Column("BID")]
		public int BID { get; set; }
		/// <summary>
		/// 템플릿타입코드
		/// </summary>
		[Column("템플릿타입코드")]
		public string TemplateTypeCode { get; set; }
		/// <summary>
		/// 배경이미지타입코드
		/// </summary>
		[Column("배경이미지타입코드")]
		public string BackgroundImageTypeCode { get; set; }
		/// <summary>
		/// 배경이미지경로
		/// </summary>
		[Column("배경이미지경로")]
		public string BackgroundImageRoute { get; set; }
		/// <summary>
		/// 폰트색상
		/// </summary>
		[Column("폰트색상")]
		public string FontColor { get; set; }
		/// <summary>
		/// 상단문구
		/// </summary>
		[Column("상단문구")]
		public string TopWords { get; set; }
		/// <summary>
		/// 중간문구
		/// </summary>
		[Column("중간문구")]
		public string MiddleWords { get; set; }
		/// <summary>
		/// 하단문구
		/// </summary>
		[Column("하단문구")]
		public string BottomWords { get; set; }
	}

	public class Result14 : IDbResult
	{
		/// <summary>
		/// 기획전번호
		/// </summary>
		[Column("기획전번호")]
		public int SpecialEventNumber { get; set; }
		/// <summary>
		/// 게시시작일
		/// </summary>
		[Column("게시시작일")]
		public string PostStartDate { get; set; }
	}
}