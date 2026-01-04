namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_여행후기_리스트
/// </summary>
public class WSP_S_CMN_TravelReview_List
{
    public const string SP_NAME = "WSP_S_CMN_여행후기_리스트";

    public class Parameters : BaseDbParameters
    {
        /// <summary>
        /// PTID
        /// </summary>
        [Description("PTID")]
        public int PTID { get; set; }
        /// <summary>
        /// 지역
        /// </summary>
        [Description("지역")]
        public string Region { get; set; }
        /// <summary>
        /// 상품코드
        /// </summary>
        [Description("상품코드")]
        public string ProductCode { get; set; }
        /// <summary>
        /// 아이템구분
        /// </summary>
        [Description("아이템구분")]
        public string ItemClassification { get; set; }
        /// <summary>
        /// 거래처
        /// </summary>
        [Description("거래처")]
        public int Customer { get; set; }
        /// <summary>
        /// 현재페이지
        /// </summary>
        [Description("현재페이지")]
        public int CurrentPage { get; set; }
        /// <summary>
        /// 페이지당글개수
        /// </summary>
        [Description("페이지당글개수")]
        public int EachPageCharactersNumber { get; set; }
        /// <summary>
        /// 전체게시글수
        /// </summary>
        [DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
        [Description("전체게시글수")]
        public int EntirePostCharactersNumber { get; set; }
        /// <summary>
        /// 전체페이지수
        /// </summary>
        [DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
        [Description("전체페이지수")]
        public int EntirePageNumber { get; set; }
    }
	public class Result1 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Column("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 단체명
		/// </summary>
		[Column("단체명")]
		public string GroupName { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 글쓴이
		/// </summary>
		[Column("글쓴이")]
		public string Writer { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 추천
		/// </summary>
		[Column("추천")]
		public int Recommend { get; set; }
		/// <summary>
		/// 이미지
		/// </summary>
		[Column("이미지")]
		public string Image { get; set; }
		/// <summary>
		/// 만족도
		/// </summary>
		[Column("만족도")]
		public string SatisfactionRate { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Column("지역")]
		public string Region { get; set; }
		/// <summary>
		/// 오픈
		/// </summary>
		[Column("오픈")]
		public string Open { get; set; }
		/// <summary>
		/// 사진
		/// </summary>
		[Column("사진")]
		public string Picture { get; set; }
		/// <summary>
		/// 지역PLID
		/// </summary>
		[Column("지역PLID")]
		public int RegionPLID { get; set; }
		/// <summary>
		/// 여행지
		/// </summary>
		[Column("여행지")]
		public string TravelSpot { get; set; }
		/// <summary>
		/// 아이템구분
		/// </summary>
		[Column("아이템구분")]
		public string ItemClassification { get; set; }
		/// <summary>
		/// 위치
		/// </summary>
		[Column("위치")]
		public int Position { get; set; }
		/// <summary>
		/// 객실
		/// </summary>
		[Column("객실")]
		public int GuestRoom { get; set; }
		/// <summary>
		/// 서비스
		/// </summary>
		[Column("서비스")]
		public int Service { get; set; }
		/// <summary>
		/// 가격
		/// </summary>
		[Column("가격")]
		public int Price { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public string GroupNumber { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 여행기간
		/// </summary>
		[Column("여행기간")]
		public string TravelPeriod { get; set; }
		/// <summary>
		/// 대표호텔
		/// </summary>
		[Column("대표호텔")]
		public string RepresentativeHotel { get; set; }
		/// <summary>
		/// 호텔등급
		/// </summary>
		[Column("호텔등급")]
		public string HotelClass { get; set; }
		/// <summary>
		/// 항공사명
		/// </summary>
		[Column("항공사명")]
		public string AirlineName { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 만족도_건수
		/// </summary>
		[Column("만족도_건수")]
		public int SatisfactionRate_Number { get; set; }
		/// <summary>
		/// 만족도_합계
		/// </summary>
		[Column("만족도_합계")]
		public int SatisfactionRate_Sum { get; set; }
		/// <summary>
		/// 만족도_평균
		/// </summary>
		[Column("만족도_평균")]
		public int SatisfactionRate_Average { get; set; }
	}
}