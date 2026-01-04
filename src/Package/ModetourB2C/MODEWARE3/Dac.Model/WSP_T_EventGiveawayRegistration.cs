namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_이벤트경품등록
/// </summary>
public class WSP_T_EventGiveawayRegistration
{
	public const string SP_NAME = "WSP_T_이벤트경품등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 이벤트번호
		/// </summary>
		[Description("이벤트번호")]
		public int EventNumber { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Description("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 경품품목번호
		/// </summary>
		[Description("경품품목번호")]
		public int GiveawayItemNumber { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Description("휴대폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 주소1
		/// </summary>
		[Description("주소1")]
		public string Address1 { get; set; }
		/// <summary>
		/// 주소2
		/// </summary>
		[Description("주소2")]
		public string Address2 { get; set; }
		/// <summary>
		/// 우편번호
		/// </summary>
		[Description("우편번호")]
		public string ZipCode { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Description("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 수량
		/// </summary>
		[Description("수량")]
		public int Quantity { get; set; }
	}

}