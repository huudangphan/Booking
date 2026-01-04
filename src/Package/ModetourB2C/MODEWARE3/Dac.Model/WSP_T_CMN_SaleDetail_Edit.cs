namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_판매명세_수정
/// </summary>
public class WSP_T_CMN_SaleDetail_Edit
{
	public const string SP_NAME = "WSP_T_CMN_판매명세_수정";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 판매비고
		/// </summary>
		[Description("판매비고")]
		public string SalesNote { get; set; }
		/// <summary>
		/// 타입
		/// </summary>
		[Description("타입")]
		public string Type { get; set; }
	}

}