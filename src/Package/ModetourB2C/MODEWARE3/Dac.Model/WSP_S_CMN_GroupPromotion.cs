namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_단체프로모션
/// </summary>
public class WSP_S_CMN_GroupPromotion
{
	public const string SP_NAME = "WSP_S_CMN_단체프로모션";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PNum
		/// </summary>
		[Description("PNum")]
		public int PNum { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 마스터번호
		/// </summary>
		[Column("마스터번호")]
		public int MasterNumber { get; set; }
		/// <summary>
		/// 프로모션명
		/// </summary>
		[Column("프로모션명")]
		public string PromotionName { get; set; }
		/// <summary>
		/// 시작일
		/// </summary>
		[Column("시작일")]
		public DateTime StartDate { get; set; }
		/// <summary>
		/// 종료일
		/// </summary>
		[Column("종료일")]
		public DateTime EndDate { get; set; }
	}
}