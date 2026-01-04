namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_예약조회_회원_현재내역_마일리지
/// </summary>
public class WSP_S_CMN_ReservationFind_Member_CurrentHistory_Mileage
{
	public const string SP_NAME = "WSP_S_CMN_예약조회_회원_현재내역_마일리지";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 적립예정마일리지
		/// </summary>
		[Column("적립예정마일리지")]
		public int AccumulationExpectationMileage { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Column("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 마일리지적립요청
		/// </summary>
		[Column("마일리지적립요청")]
		public string MileageAccumulationRequest { get; set; }
		/// <summary>
		/// 회원구분
		/// </summary>
		[Column("회원구분")]
		public string MemberClassification { get; set; }
		/// <summary>
		/// 마일리지적립YN
		/// </summary>
		[Column("마일리지적립YN")]
		public string MileageAccumulation_YN { get; set; }
	}
}