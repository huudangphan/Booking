namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_이벤트_리스트_사용여부체크
/// </summary>
public class WSP_S_CMN_Event_List_UseOrNotCheck
{
	public const string SP_NAME = "WSP_S_CMN_이벤트_리스트_사용여부체크";

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
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 사용여부
		/// </summary>
		[Column("사용여부")]
		public string UseOrNot { get; set; }
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
		/// 등록수
		/// </summary>
		[Column("등록수")]
		public int RegisterNumber { get; set; }
	}
}