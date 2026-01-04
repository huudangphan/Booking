namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_거래처별_정산리스트
/// </summary>
public class WSP_S_CMN_EachCustomer_SettlementList
{
	public const string SP_NAME = "WSP_S_CMN_거래처별_정산리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Description("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 시작일
		/// </summary>
		[Description("시작일")]
		public string StartDate { get; set; }
		/// <summary>
		/// 종료일
		/// </summary>
		[Description("종료일")]
		public string EndDate { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// ORD_NO
		/// </summary>
		[Column("ORD_NO")]
		public int ORD_NO { get; set; }
		/// <summary>
		/// SBC_KNM
		/// </summary>
		[Column("SBC_KNM")]
		public string SBC_KNM { get; set; }
		/// <summary>
		/// UPRC_A
		/// </summary>
		[Column("UPRC_A")]
		public long UPRC_A { get; set; }
		/// <summary>
		/// 입금액
		/// </summary>
		[Column("입금액")]
		public long DepositAmount { get; set; }
		/// <summary>
		/// SEL_A
		/// </summary>
		[Column("SEL_A")]
		public long SEL_A { get; set; }
		/// <summary>
		/// RCMD_FEER
		/// </summary>
		[Column("RCMD_FEER")]
		public int RCMD_FEER { get; set; }
		/// <summary>
		/// RCMD_FEE
		/// </summary>
		[Column("RCMD_FEE")]
		public long RCMD_FEE { get; set; }
		/// <summary>
		/// ADD_AMOUNT
		/// </summary>
		[Column("ADD_AMOUNT")]
		public long ADD_AMOUNT { get; set; }
	}
}