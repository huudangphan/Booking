namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_가상계좌
/// </summary>
public class USP_S_VirtualAccount
{
	public const string SP_NAME = "USP_S_가상계좌";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 가상계좌구분
		/// </summary>
		[Description("가상계좌구분")]
		public string VirtualAccountClassification { get; set; }
		/// <summary>
		/// 발급경로
		/// </summary>
		[Description("발급경로")]
		public string IssuanceRoute { get; set; }
		/// <summary>
		/// 발급자
		/// </summary>
		[Description("발급자")]
		public int Issuer { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 계좌번호
		/// </summary>
		[Column("계좌번호")]
		public string AccountNumber { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 가상계좌구분
		/// </summary>
		[Column("가상계좌구분")]
		public string VirtualAccountClassification { get; set; }
		/// <summary>
		/// 가상계좌예금주
		/// </summary>
		[Column("가상계좌예금주")]
		public string VirtualAccountHolder { get; set; }
	}
}