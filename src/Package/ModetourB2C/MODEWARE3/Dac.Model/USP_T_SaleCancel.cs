namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_판매취소
/// </summary>
public class USP_T_SaleCancel
{
	public const string SP_NAME = "USP_T_판매취소";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 주민번호
		/// </summary>
		[Description("주민번호")]
		public string CitizenIDNumber { get; set; }
		/// <summary>
		/// 취소자
		/// </summary>
		[Description("취소자")]
		public int CancelPerson { get; set; }
		/// <summary>
		/// 부서
		/// </summary>
		[Description("부서")]
		public int Department { get; set; }
		/// <summary>
		/// 취소사유코드
		/// </summary>
		[Description("취소사유코드")]
		public string CancelReasonCode { get; set; }
		/// <summary>
		/// 취소첨부서류
		/// </summary>
		[Description("취소첨부서류")]
		public string CancelAttachDocument { get; set; }
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