namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_인센티브_상품담당
/// </summary>
public class USP_S_Incentive_ProductResponsibility
{
	public const string SP_NAME = "USP_S_인센티브_상품담당";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 상품OP
		/// </summary>
		[Column("상품OP")]
		public string Product_OP { get; set; }
		/// <summary>
		/// 상품OP번호
		/// </summary>
		[Column("상품OP번호")]
		public int Product_OP_Number { get; set; }
		/// <summary>
		/// 상품부서
		/// </summary>
		[Column("상품부서")]
		public int ProductDepartment { get; set; }
	}
}