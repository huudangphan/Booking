namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_투어마일리지_사용_가족합산
/// </summary>
public class USP_T_TourMileage_Use_TotalFamilyCalculation
{
	public const string SP_NAME = "USP_T_투어마일리지_사용_가족합산";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 결제경로
		/// </summary>
		[Description("결제경로")]
		public string PaymentRoute { get; set; }
		/// <summary>
		/// 회원번호
		/// </summary>
		[Description("회원번호")]
		public string MemberNumber { get; set; }
		/// <summary>
		/// 주민번호앞자리
		/// </summary>
		[Description("주민번호앞자리")]
		public string CitizenIDNumberFrontDigitCode { get; set; }
		/// <summary>
		/// 사용마일리지
		/// </summary>
		[Description("사용마일리지")]
		public string UseMileage { get; set; }
		/// <summary>
		/// USERIP
		/// </summary>
		[Description("USERIP")]
		public string USERIP { get; set; }
		/// <summary>
		/// USERID
		/// </summary>
		[Description("USERID")]
		public int USERID { get; set; }
		/// <summary>
		/// APPNAME
		/// </summary>
		[Description("APPNAME")]
		public string APPNAME { get; set; }
		/// <summary>
		/// 첨부파일
		/// </summary>
		[Description("첨부파일")]
		public string AttachFile { get; set; }
		/// <summary>
		/// 할인쿠폰사용여부
		/// </summary>
		[Description("할인쿠폰사용여부")]
		public string DiscountCouponUseOrNot { get; set; }
		/// <summary>
		/// TBL할인쿠폰
		/// </summary>
		[DapperParameter(DbType.Object)]
		[Description("TBL할인쿠폰")]
		public List<TYPE_DiscountCoupon> TBL_DiscountCoupon { get; set; }
		/// <summary>
		/// 메시지발송여부
		/// </summary>
		[Description("메시지발송여부")]
		public bool MessageSendingOrNot { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Description("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
	}

}