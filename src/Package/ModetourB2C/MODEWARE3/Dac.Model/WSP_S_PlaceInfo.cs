namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_장소정보
/// </summary>
public class WSP_S_PlaceInfo
{
	public const string SP_NAME = "WSP_S_장소정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 장소번호
		/// </summary>
		[Description("장소번호")]
		public int PlaceNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 장소번호
		/// </summary>
		[Column("장소번호")]
		public int PlaceNumber { get; set; }
		/// <summary>
		/// 상위장소번호
		/// </summary>
		[Column("상위장소번호")]
		public int HighRankPlaceNumber { get; set; }
		/// <summary>
		/// 장소분류코드
		/// </summary>
		[Column("장소분류코드")]
		public string PlaceClassificationCode { get; set; }
		/// <summary>
		/// 장소그룹_일정표노출명
		/// </summary>
		[Column("장소그룹_일정표노출명")]
		public string PlaceGroup_ScheduleTableDisplayName { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 영문이름
		/// </summary>
		[Column("영문이름")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 현지명칭
		/// </summary>
		[Column("현지명칭")]
		public string LocalName { get; set; }
		/// <summary>
		/// 대륙코드
		/// </summary>
		[Column("대륙코드")]
		public string ContinentCode { get; set; }
		/// <summary>
		/// 국가코드
		/// </summary>
		[Column("국가코드")]
		public string CountryCode { get; set; }
		/// <summary>
		/// 국가번호
		/// </summary>
		[Column("국가번호")]
		public int CountryNumber { get; set; }
		/// <summary>
		/// 지방코드
		/// </summary>
		[Column("지방코드")]
		public string LocalCode { get; set; }
		/// <summary>
		/// 도시코드
		/// </summary>
		[Column("도시코드")]
		public string CityCode { get; set; }
		/// <summary>
		/// 공항코드
		/// </summary>
		[Column("공항코드")]
		public string AirportCode { get; set; }
		/// <summary>
		/// 위도
		/// </summary>
		[Column("위도")]
		public decimal Latitude { get; set; }
		/// <summary>
		/// 경도
		/// </summary>
		[Column("경도")]
		public decimal Longtitude { get; set; }
		/// <summary>
		/// 일정등록수
		/// </summary>
		[Column("일정등록수")]
		public int ScheduleRegisterNumber { get; set; }
		/// <summary>
		/// PATH
		/// </summary>
		[Column("PATH")]
		public string PATH { get; set; }
		/// <summary>
		/// 사용여부
		/// </summary>
		[Column("사용여부")]
		public bool UseOrNot { get; set; }
		/// <summary>
		/// 장소_한줄설명
		/// </summary>
		[Column("장소_한줄설명")]
		public string Place_OneLineExplaination { get; set; }
		/// <summary>
		/// 카피라이팅
		/// </summary>
		[Column("카피라이팅")]
		public string Copyrighting { get; set; }
		/// <summary>
		/// 등급
		/// </summary>
		[Column("등급")]
		public string Class { get; set; }
		/// <summary>
		/// 주소
		/// </summary>
		[Column("주소")]
		public string Address { get; set; }
		/// <summary>
		/// 연락처
		/// </summary>
		[Column("연락처")]
		public string Contact { get; set; }
		/// <summary>
		/// 홈페이지
		/// </summary>
		[Column("홈페이지")]
		public string HomePage { get; set; }
		/// <summary>
		/// 찾아가는길
		/// </summary>
		[Column("찾아가는길")]
		public string DirectionWay { get; set; }
		/// <summary>
		/// 영업시간
		/// </summary>
		[Column("영업시간")]
		public string BusinessTime { get; set; }
		/// <summary>
		/// 이용요금
		/// </summary>
		[Column("이용요금")]
		public string UseFare { get; set; }
		/// <summary>
		/// 소요시간
		/// </summary>
		[Column("소요시간")]
		public string RequiredTime { get; set; }
		/// <summary>
		/// 대체일정
		/// </summary>
		[Column("대체일정")]
		public string TransferSchedule { get; set; }
		/// <summary>
		/// 시설규모
		/// </summary>
		[Column("시설규모")]
		public string FacilitiesScale { get; set; }
		/// <summary>
		/// 부대시설
		/// </summary>
		[Column("부대시설")]
		public string AdditionalFacilities { get; set; }
		/// <summary>
		/// 세부정보
		/// </summary>
		[Column("세부정보")]
		public string DetailInfo { get; set; }
		/// <summary>
		/// 강조사항
		/// </summary>
		[Column("강조사항")]
		public string ForcedItem { get; set; }
		/// <summary>
		/// 서머타임
		/// </summary>
		[Column("서머타임")]
		public string SummerTime { get; set; }
		/// <summary>
		/// 숙소타입
		/// </summary>
		[Column("숙소타입")]
		public string LodgingType { get; set; }
		/// <summary>
		/// 날씨영문명
		/// </summary>
		[Column("날씨영문명")]
		public string WeatherEnglishName { get; set; }
		/// <summary>
		/// 컨텐츠수
		/// </summary>
		[Column("컨텐츠수")]
		public long ContentNumber { get; set; }
		/// <summary>
		/// 컨텐츠수_하위포함
		/// </summary>
		[Column("컨텐츠수_하위포함")]
		public long ContentNumber_LowRankIncluded { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Column("등록자")]
		public int Registerer { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// PLACEINFO비고
		/// </summary>
		[Column("PLACEINFO비고")]
		public string PLACEINFO_Note { get; set; }
		/// <summary>
		/// 구글키
		/// </summary>
		[Column("구글키")]
		public string GoogleKey { get; set; }
		/// <summary>
		/// 아이템번호
		/// </summary>
		[Column("아이템번호")]
		public int ItemNumber { get; set; }
		/// <summary>
		/// 승인여부
		/// </summary>
		[Column("승인여부")]
		public bool ApprovalOrNot { get; set; }
		/// <summary>
		/// 수정자
		/// </summary>
		[Column("수정자")]
		public int Editor { get; set; }
		/// <summary>
		/// 수정일
		/// </summary>
		[Column("수정일")]
		public DateTime EditionDate { get; set; }
		/// <summary>
		/// 영업시간_구글
		/// </summary>
		[Column("영업시간_구글")]
		public string BusinessTime_Google { get; set; }
		/// <summary>
		/// 내부이미지우선노출
		/// </summary>
		[Column("내부이미지우선노출")]
		public string InternalImagePriorityDisplay { get; set; }
		/// <summary>
		/// 연동데이터_호텔
		/// </summary>
		[Column("연동데이터_호텔")]
		public string ConnectedData_Hotel { get; set; }
		/// <summary>
		/// 연동데이터_장소
		/// </summary>
		[Column("연동데이터_장소")]
		public string ConnectedData_Place { get; set; }
		/// <summary>
		/// 구글지도파일명
		/// </summary>
		[Column("구글지도파일명")]
		public string GoogleMapFileName { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 파일번호
		/// </summary>
		[Column("파일번호")]
		public int FileNumber { get; set; }
		/// <summary>
		/// 장소번호
		/// </summary>
		[Column("장소번호")]
		public int PlaceNumber { get; set; }
		/// <summary>
		/// 파일분류코드
		/// </summary>
		[Column("파일분류코드")]
		public string FileClassificationCode { get; set; }
		/// <summary>
		/// 파일명
		/// </summary>
		[Column("파일명")]
		public string FileName { get; set; }
		/// <summary>
		/// 파일크기
		/// </summary>
		[Column("파일크기")]
		public decimal FileSize { get; set; }
		/// <summary>
		/// 파일경로
		/// </summary>
		[Column("파일경로")]
		public string FileRoute { get; set; }
		/// <summary>
		/// 해상도_가로
		/// </summary>
		[Column("해상도_가로")]
		public short Resolution_Horizontal { get; set; }
		/// <summary>
		/// 해상도_세로
		/// </summary>
		[Column("해상도_세로")]
		public short Resolution_Vertical { get; set; }
		/// <summary>
		/// 간략설명
		/// </summary>
		[Column("간략설명")]
		public string BriefDescription { get; set; }
		/// <summary>
		/// 사용가능
		/// </summary>
		[Column("사용가능")]
		public bool UsePossible { get; set; }
		/// <summary>
		/// BEST여부
		/// </summary>
		[Column("BEST여부")]
		public bool BEST_OrNot { get; set; }
		/// <summary>
		/// 노출순서
		/// </summary>
		[Column("노출순서")]
		public short DisplayOrder { get; set; }
		/// <summary>
		/// 저작권여부
		/// </summary>
		[Column("저작권여부")]
		public bool CopyrightOrNot { get; set; }
		/// <summary>
		/// 저작권번호
		/// </summary>
		[Column("저작권번호")]
		public int CopyrightNumber { get; set; }
		/// <summary>
		/// 파일명_S
		/// </summary>
		[Column("파일명_S")]
		public string FileName_S { get; set; }
		/// <summary>
		/// 이미지노출정렬
		/// </summary>
		[Column("이미지노출정렬")]
		public long ImageDisplaySorting { get; set; }
	}
}