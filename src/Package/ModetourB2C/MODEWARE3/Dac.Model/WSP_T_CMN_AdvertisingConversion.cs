namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_광고전환
/// </summary>
public class WSP_T_CMN_AdvertisingConversion
{
	public const string SP_NAME = "WSP_T_CMN_광고전환";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 광고전환코드
		/// </summary>
		[Description("광고전환코드")]
		public string AdvertisingConversionCode { get; set; }
		/// <summary>
		/// 상품분류
		/// </summary>
		[Description("상품분류")]
		public string ProductClassification { get; set; }
		/// <summary>
		/// 브라우저
		/// </summary>
		[Description("브라우저")]
		public string Browser { get; set; }
		/// <summary>
		/// 이전주소
		/// </summary>
		[Description("이전주소")]
		public string PreviousAddress { get; set; }
		/// <summary>
		/// 정보1
		/// </summary>
		[Description("정보1")]
		public string Info1 { get; set; }
		/// <summary>
		/// 정보2
		/// </summary>
		[Description("정보2")]
		public string Info2 { get; set; }
		/// <summary>
		/// 정보3
		/// </summary>
		[Description("정보3")]
		public string Info3 { get; set; }
		/// <summary>
		/// 정보4
		/// </summary>
		[Description("정보4")]
		public string Info4 { get; set; }
		/// <summary>
		/// 정보5
		/// </summary>
		[Description("정보5")]
		public string Info5 { get; set; }
		/// <summary>
		/// 키워드
		/// </summary>
		[Description("키워드")]
		public string Keyword { get; set; }
		/// <summary>
		/// 회원PTID
		/// </summary>
		[Description("회원PTID")]
		public int Member_PTID { get; set; }
		/// <summary>
		/// 회원아이디
		/// </summary>
		[Description("회원아이디")]
		public string MemberID { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 예약번호
		/// </summary>
		[Description("예약번호")]
		public int BookingNumber { get; set; }
		/// <summary>
		/// 통화
		/// </summary>
		[Description("통화")]
		public string Call { get; set; }
		/// <summary>
		/// 총합
		/// </summary>
		[Description("총합")]
		public double Total { get; set; }
		/// <summary>
		/// 인원수
		/// </summary>
		[Description("인원수")]
		public int NumberOfPeopleNumber { get; set; }
		/// <summary>
		/// 유입일
		/// </summary>
		[Description("유입일")]
		public DateTime InflowDate { get; set; }
	}

}