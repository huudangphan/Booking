namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_무인센딩_센딩경로
/// </summary>
public class WSP_T_UnmannedSending_SendingFlow
{
	public const string SP_NAME = "WSP_T_무인센딩_센딩경로";

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
		/// 센딩경로
		/// </summary>
		[Column("센딩경로")]
		public string SendingRoute { get; set; }
	}
}