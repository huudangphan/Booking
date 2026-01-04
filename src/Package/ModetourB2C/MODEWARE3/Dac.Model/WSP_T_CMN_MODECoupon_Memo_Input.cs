namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_모두쿠폰_메모_입력
/// </summary>
public class WSP_T_CMN_MODECoupon_Memo_Input
{
	public const string SP_NAME = "WSP_T_CMN_모두쿠폰_메모_입력";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 모두쿠폰구분번호
		/// </summary>
		[Description("모두쿠폰구분번호")]
		public int MODECouponClassificationNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 쿠폰신청자아이디
		/// </summary>
		[Description("쿠폰신청자아이디")]
		public string CouponRequesterID { get; set; }
		/// <summary>
		/// 쿠폰신청자이름
		/// </summary>
		[Description("쿠폰신청자이름")]
		public string CouponRequesterName { get; set; }
		/// <summary>
		/// 쿠폰발행한예약번호
		/// </summary>
		[Description("쿠폰발행한예약번호")]
		public int CouponPublishedBookingNumber { get; set; }
		/// <summary>
		/// 등록IP
		/// </summary>
		[Description("등록IP")]
		public string RegisterIP { get; set; }
		/// <summary>
		/// 사용가능여부
		/// </summary>
		[Description("사용가능여부")]
		public string UsePossibleOrNot { get; set; }
		/// <summary>
		/// 사용가능금액
		/// </summary>
		[Description("사용가능금액")]
		public long UsePossibleAmount { get; set; }
		/// <summary>
		/// 사용개시일
		/// </summary>
		[Description("사용개시일")]
		public DateTime UseReleaseDate { get; set; }
		/// <summary>
		/// 사용마감일
		/// </summary>
		[Description("사용마감일")]
		public DateTime UseEndDate { get; set; }
		/// <summary>
		/// 사용제한일
		/// </summary>
		[Description("사용제한일")]
		public string UseLimitDate { get; set; }
		/// <summary>
		/// 주의사항이미지경로
		/// </summary>
		[Description("주의사항이미지경로")]
		public string NoticesImageRoute { get; set; }
		/// <summary>
		/// 비고
		/// </summary>
		[Description("비고")]
		public string Note { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 2)]
		[Description("결과")]
		public string Result { get; set; }
		/// <summary>
		/// 쿠폰번호
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 12)]
		[Description("쿠폰번호")]
		public string CouponNumber { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 수협쿠폰번호
		/// </summary>
		[Description("수협쿠폰번호")]
		public string ShBankCouponNumber { get; set; }
	}

}