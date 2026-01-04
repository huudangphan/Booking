namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_판매순서
/// </summary>
public class USP_T_SaleOrder
{
	public const string SP_NAME = "USP_T_판매순서";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 수정자
		/// </summary>
		[Description("수정자")]
		public int Editor { get; set; }
	}

}