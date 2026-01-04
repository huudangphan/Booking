namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_단체_쇼핑
/// </summary>
public class USP_S_Group_Shopping
{
	public const string SP_NAME = "USP_S_단체_쇼핑";

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
		/// 쇼핑일련번호
		/// </summary>
		[Column("쇼핑일련번호")]
		public int ShoppingSerialNumber { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 쇼핑품목
		/// </summary>
		[Column("쇼핑품목")]
		public string ShoppingProductList { get; set; }
		/// <summary>
		/// 쇼핑장소
		/// </summary>
		[Column("쇼핑장소")]
		public string ShoppingPlace { get; set; }
		/// <summary>
		/// 소요시간
		/// </summary>
		[Column("소요시간")]
		public string RequiredTime { get; set; }
		/// <summary>
		/// 환불여부
		/// </summary>
		[Column("환불여부")]
		public string RefundOrNot { get; set; }
		/// <summary>
		/// 환불여부2
		/// </summary>
		[Column("환불여부2")]
		public string RefundOrNot2 { get; set; }
	}
}