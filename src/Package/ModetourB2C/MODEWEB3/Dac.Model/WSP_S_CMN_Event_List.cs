namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_이벤트_리스트
/// </summary>
public class WSP_S_CMN_Event_List
{
	public const string SP_NAME = "WSP_S_CMN_이벤트_리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 구역번호
		/// </summary>
		[Description("구역번호")]
		public int AreaNumber { get; set; }
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
		/// 구역번호
		/// </summary>
		[Column("구역번호")]
		public int AreaNumber { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 설명
		/// </summary>
		[Column("설명")]
		public string Explaination { get; set; }
		/// <summary>
		/// 대표이미지
		/// </summary>
		[Column("대표이미지")]
		public string RepresentativeImage { get; set; }
		/// <summary>
		/// 이벤트경로
		/// </summary>
		[Column("이벤트경로")]
		public string EventRoute { get; set; }
		/// <summary>
		/// 상태1
		/// </summary>
		[Column("상태1")]
		public string State1 { get; set; }
		/// <summary>
		/// 상태2
		/// </summary>
		[Column("상태2")]
		public string State2 { get; set; }
		/// <summary>
		/// 상태3
		/// </summary>
		[Column("상태3")]
		public string State3 { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 추천수
		/// </summary>
		[Column("추천수")]
		public int RecommendNumber { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public int Sorting { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 시작일
		/// </summary>
		[Column("시작일")]
		public DateTime StartDate { get; set; }
		/// <summary>
		/// 종료일
		/// </summary>
		[Column("종료일")]
		public DateTime EndDate { get; set; }
		/// <summary>
		/// 당첨등록시작일
		/// </summary>
		[Column("당첨등록시작일")]
		public DateTime WinnerRegisterStartDate { get; set; }
		/// <summary>
		/// 당첨등록종료일
		/// </summary>
		[Column("당첨등록종료일")]
		public DateTime WinnerRegisterEndDate { get; set; }
		/// <summary>
		/// 이미지쿠폰사용여부
		/// </summary>
		[Column("이미지쿠폰사용여부")]
		public string ImageCouponUseOrNot { get; set; }
		/// <summary>
		/// 모바일노출여부
		/// </summary>
		[Column("모바일노출여부")]
		public string MobileDisplayOrNot { get; set; }
		/// <summary>
		/// 모바일쿠폰이미지경로
		/// </summary>
		[Column("모바일쿠폰이미지경로")]
		public string MobileCouponImageRoute { get; set; }
		/// <summary>
		/// 세부구분번호
		/// </summary>
		[Column("세부구분번호")]
		public int DetailClassificationNumber { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 구역번호
		/// </summary>
		[Column("구역번호")]
		public int AreaNumber { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 설명
		/// </summary>
		[Column("설명")]
		public string Explaination { get; set; }
		/// <summary>
		/// 대표이미지
		/// </summary>
		[Column("대표이미지")]
		public string RepresentativeImage { get; set; }
		/// <summary>
		/// 이벤트경로
		/// </summary>
		[Column("이벤트경로")]
		public string EventRoute { get; set; }
		/// <summary>
		/// 상태1
		/// </summary>
		[Column("상태1")]
		public string State1 { get; set; }
		/// <summary>
		/// 상태2
		/// </summary>
		[Column("상태2")]
		public string State2 { get; set; }
		/// <summary>
		/// 상태3
		/// </summary>
		[Column("상태3")]
		public string State3 { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 추천수
		/// </summary>
		[Column("추천수")]
		public int RecommendNumber { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public int Sorting { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 시작일
		/// </summary>
		[Column("시작일")]
		public DateTime StartDate { get; set; }
		/// <summary>
		/// 종료일
		/// </summary>
		[Column("종료일")]
		public DateTime EndDate { get; set; }
		/// <summary>
		/// 당첨등록시작일
		/// </summary>
		[Column("당첨등록시작일")]
		public DateTime WinnerRegisterStartDate { get; set; }
		/// <summary>
		/// 당첨등록종료일
		/// </summary>
		[Column("당첨등록종료일")]
		public DateTime WinnerRegisterEndDate { get; set; }
		/// <summary>
		/// 년도
		/// </summary>
		[Column("년도")]
		public string Year { get; set; }
		/// <summary>
		/// 이미지쿠폰사용여부
		/// </summary>
		[Column("이미지쿠폰사용여부")]
		public string ImageCouponUseOrNot { get; set; }
		/// <summary>
		/// 모바일노출여부
		/// </summary>
		[Column("모바일노출여부")]
		public string MobileDisplayOrNot { get; set; }
		/// <summary>
		/// 모바일쿠폰이미지경로
		/// </summary>
		[Column("모바일쿠폰이미지경로")]
		public string MobileCouponImageRoute { get; set; }
		/// <summary>
		/// 세부구분번호
		/// </summary>
		[Column("세부구분번호")]
		public int DetailClassificationNumber { get; set; }
	}
}