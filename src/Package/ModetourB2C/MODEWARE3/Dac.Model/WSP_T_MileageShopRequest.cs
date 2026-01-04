namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_마일리지샵신청
/// </summary>
public class WSP_T_MileageShopRequest
{
	public const string SP_NAME = "WSP_T_마일리지샵신청";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 기준마일리지
		/// </summary>
		[Description("기준마일리지")]
		public int StandardMileage { get; set; }
		/// <summary>
		/// 주문자_MT_NO
		/// </summary>
		[Description("주문자_MT_NO")]
		public string OrderPerson_MT_NO { get; set; }
		/// <summary>
		/// 주문자_PTID
		/// </summary>
		[Description("주문자_PTID")]
		public int OrderPerson_PTID { get; set; }
		/// <summary>
		/// 주문자_고객아이디
		/// </summary>
		[Description("주문자_고객아이디")]
		public string OrderPerson_CustomerID { get; set; }
		/// <summary>
		/// 주문자_연락처
		/// </summary>
		[Description("주문자_연락처")]
		public string OrderPerson_Contact { get; set; }
		/// <summary>
		/// 수량
		/// </summary>
		[Description("수량")]
		public long Quantity { get; set; }
		/// <summary>
		/// 비고
		/// </summary>
		[Description("비고")]
		public string Note { get; set; }
		/// <summary>
		/// 마일리지상품no
		/// </summary>
		[Description("마일리지상품no")]
		public int MileageProduct_NO { get; set; }
		/// <summary>
		/// T_옵션집합
		/// </summary>
		[DapperParameter(DbType.Object)]
		[Description("T_옵션집합")]
		public List<TYPE_MileageShopOption> T_OptionGathering { get; set; }
		/// <summary>
		/// 수령자
		/// </summary>
		[Description("수령자")]
		public string Receiver { get; set; }
		/// <summary>
		/// 수령자_연락처
		/// </summary>
		[Description("수령자_연락처")]
		public string Receiver_Contact { get; set; }
		/// <summary>
		/// 수령자_우편번호
		/// </summary>
		[Description("수령자_우편번호")]
		public string Receiver_ZipCode { get; set; }
		/// <summary>
		/// 수령자_주소1
		/// </summary>
		[Description("수령자_주소1")]
		public string Receiver_Address1 { get; set; }
		/// <summary>
		/// 수령자_주소2
		/// </summary>
		[Description("수령자_주소2")]
		public string Receiver_Address2 { get; set; }
		/// <summary>
		/// 수령자_요청사항
		/// </summary>
		[Description("수령자_요청사항")]
		public string Receiver_Request { get; set; }
		/// <summary>
		/// 특별이벤트
		/// </summary>
		[Description("특별이벤트")]
		public string SpecialEvent { get; set; }
	}

}