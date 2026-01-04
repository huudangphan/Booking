namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_모두쿠폰_참여가능이벤트구역_단체리스트
/// </summary>
public class WSP_S_CMN_MODECoupon_JoinableEventArea_GroupList
{
	public const string SP_NAME = "WSP_S_CMN_모두쿠폰_참여가능이벤트구역_단체리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 모두쿠폰구분번호
		/// </summary>
		[Description("모두쿠폰구분번호")]
		public int MODECouponClassificationNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public DateTime DepartureDate { get; set; }
	}
}