namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_업체별_포인트율
/// </summary>
public class WSP_S_EachCompany_PointPercent
{
	public const string SP_NAME = "WSP_S_업체별_포인트율";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// SITENO
		/// </summary>
		[Description("SITENO")]
		public int SITENO { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Description("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 포인트율
		/// </summary>
		[Column("포인트율")]
		public decimal PointRate { get; set; }
	}
}