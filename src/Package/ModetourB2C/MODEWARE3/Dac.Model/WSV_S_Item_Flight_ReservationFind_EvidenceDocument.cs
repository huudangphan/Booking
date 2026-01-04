namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSV_S_아이템_항공_예약조회_증빙서류
/// </summary>
public class WSV_S_Item_Flight_ReservationFind_EvidenceDocument
{
	public const string SP_NAME = "WSV_S_아이템_항공_예약조회_증빙서류";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
		/// <summary>
		/// 에러메시지
		/// </summary>
		[DapperParameter(DbType.String, ParameterDirection.InputOutput, 1000)]
		[Description("에러메시지")]
		public string ErrorMessage { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 증빙서류번호
		/// </summary>
		[Column("증빙서류번호")]
		public int EvidenceDocumentNumber { get; set; }
		/// <summary>
		/// 주문아이템번호
		/// </summary>
		[Column("주문아이템번호")]
		public int OrderItemNumber { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Column("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 제출방법
		/// </summary>
		[Column("제출방법")]
		public string SubmitWay { get; set; }
		/// <summary>
		/// 파일명
		/// </summary>
		[Column("파일명")]
		public string FileName { get; set; }
		/// <summary>
		/// 파일경로
		/// </summary>
		[Column("파일경로")]
		public string FileRoute { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 이메일전송예정일
		/// </summary>
		[Column("이메일전송예정일")]
		public string EmailSendingExpectationDate { get; set; }
		/// <summary>
		/// 이메일전송예정시간
		/// </summary>
		[Column("이메일전송예정시간")]
		public string EmailSendingExpectationTime { get; set; }
		/// <summary>
		/// 팩스
		/// </summary>
		[Column("팩스")]
		public string Fax { get; set; }
		/// <summary>
		/// 팩스전송예정일
		/// </summary>
		[Column("팩스전송예정일")]
		public string FaxSendingExpectationDate { get; set; }
		/// <summary>
		/// 팩스전송예정시간
		/// </summary>
		[Column("팩스전송예정시간")]
		public string FaxSendingExpectationTime { get; set; }
		/// <summary>
		/// 담당자비고
		/// </summary>
		[Column("담당자비고")]
		public string ManagerNote { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
	}
}