namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_예약취소료업데이트
/// </summary>
public class USP_T_ReservationCancelFeeUpdate
{
	public const string SP_NAME = "USP_T_예약취소료업데이트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Description("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 취소료
		/// </summary>
		[Description("취소료")]
		public int CancelFee { get; set; }
		/// <summary>
		/// 취소자
		/// </summary>
		[Description("취소자")]
		public int CancelPerson { get; set; }
		/// <summary>
		/// 수정경로
		/// </summary>
		[Description("수정경로")]
		public string EditionRoute { get; set; }
		/// <summary>
		/// 발권대행수수료
		/// </summary>
		[Description("발권대행수수료")]
		public int TicketIssuanceProcurationFee { get; set; }
	}

}