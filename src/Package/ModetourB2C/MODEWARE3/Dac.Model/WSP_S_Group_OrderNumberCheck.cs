namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_단체_주문번호체크
/// </summary>
public class WSP_S_Group_OrderNumberCheck
{
	public const string SP_NAME = "WSP_S_단체_주문번호체크";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 체크값
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("체크값")]
		public int CheckValue { get; set; }
	}

}