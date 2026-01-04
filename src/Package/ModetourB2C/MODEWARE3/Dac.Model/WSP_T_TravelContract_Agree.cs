namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_여행계약서_동의
/// </summary>
public class WSP_T_TravelContract_Agree
{
	public const string SP_NAME = "WSP_T_여행계약서_동의";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 동의경로
		/// </summary>
		[Description("동의경로")]
		public string AgreeRoute { get; set; }
		/// <summary>
		/// 로그인_사용자정보
		/// </summary>
		[Description("로그인_사용자정보")]
		public string Login_UserInfo { get; set; }
		/// <summary>
		/// 비로그인_판매명세번호
		/// </summary>
		[Description("비로그인_판매명세번호")]
		public string NonLogin_SalesSpecificationNumber { get; set; }
	}

}