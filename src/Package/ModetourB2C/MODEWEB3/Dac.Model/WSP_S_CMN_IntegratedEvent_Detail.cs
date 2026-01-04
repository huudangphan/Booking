namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_통합이벤트_상세
/// </summary>
public class WSP_S_CMN_IntegratedEvent_Detail
{
	public const string SP_NAME = "WSP_S_CMN_통합이벤트_상세";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 이벤트번호
		/// </summary>
		[Description("이벤트번호")]
		public int EventNumber { get; set; }
	}

	public class Result : IDbResult
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
		/// 대표이미지1
		/// </summary>
		[Column("대표이미지1")]
		public string RepresentativeImage1 { get; set; }
		/// <summary>
		/// 대표이미지2
		/// </summary>
		[Column("대표이미지2")]
		public string RepresentativeImage2 { get; set; }
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
		/// 사용여부
		/// </summary>
		[Column("사용여부")]
		public string UseOrNot { get; set; }
		/// <summary>
		/// 이벤트등록일
		/// </summary>
		[Column("이벤트등록일")]
		public DateTime EventRegisterDate { get; set; }
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
		/// 템플릿코드
		/// </summary>
		[Column("템플릿코드")]
		public string TemplateCode { get; set; }
		/// <summary>
		/// 안내문구
		/// </summary>
		[Column("안내문구")]
		public string InfoWords { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 세부사항등록일
		/// </summary>
		[Column("세부사항등록일")]
		public DateTime DetailItemRegisterDate { get; set; }
		/// <summary>
		/// 에러문구
		/// </summary>
		[Column("에러문구")]
		public string ErrorWords { get; set; }
		/// <summary>
		/// 체크코드
		/// </summary>
		[Column("체크코드")]
		public string CheckCode { get; set; }
	}
}