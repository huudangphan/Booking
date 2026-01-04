namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_여행계약서_동의내용
/// </summary>
public class WSP_S_CMN_TravelContract_AgreeContent
{
	public const string SP_NAME = "WSP_S_CMN_여행계약서_동의내용";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Column("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 동의상태
		/// </summary>
		[Column("동의상태")]
		public string AgreeState { get; set; }
		/// <summary>
		/// 동의일
		/// </summary>
		[Column("동의일")]
		public DateTime AgreeDate { get; set; }
		/// <summary>
		/// 대리인관계
		/// </summary>
		[Column("대리인관계")]
		public string AgencyRelationship { get; set; }
	}
}