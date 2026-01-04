namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_모두쿠폰_리스트
/// </summary>
public class WSP_S_CMN_MODECoupon_List
{
	public const string SP_NAME = "WSP_S_CMN_모두쿠폰_리스트";

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
		/// 모두쿠폰구분번호
		/// </summary>
		[Column("모두쿠폰구분번호")]
		public int MODECouponClassificationNumber { get; set; }
		/// <summary>
		/// 이벤트명
		/// </summary>
		[Column("이벤트명")]
		public string EventName { get; set; }
		/// <summary>
		/// 사용여부
		/// </summary>
		[Column("사용여부")]
		public string UseOrNot { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
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