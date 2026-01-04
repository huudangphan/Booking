namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSV_T_아이템_항공_증빙서류
/// </summary>
public class WSV_T_Item_Flight_EvidenceDocument
{
	public const string SP_NAME = "WSV_T_아이템_항공_증빙서류";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 제출방법
		/// </summary>
		[Description("제출방법")]
		public string SubmitWay { get; set; }
		/// <summary>
		/// 파일명
		/// </summary>
		[Description("파일명")]
		public string FileName { get; set; }
		/// <summary>
		/// 파일경로
		/// </summary>
		[Description("파일경로")]
		public string FileRoute { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Description("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 이메일전송예정일
		/// </summary>
		[Description("이메일전송예정일")]
		public string EmailSendingExpectationDate { get; set; }
		/// <summary>
		/// 이메일전송예정시간
		/// </summary>
		[Description("이메일전송예정시간")]
		public string EmailSendingExpectationTime { get; set; }
		/// <summary>
		/// 팩스
		/// </summary>
		[Description("팩스")]
		public string Fax { get; set; }
		/// <summary>
		/// 팩스전송예정일
		/// </summary>
		[Description("팩스전송예정일")]
		public string FaxSendingExpectationDate { get; set; }
		/// <summary>
		/// 팩스전송예정시간
		/// </summary>
		[Description("팩스전송예정시간")]
		public string FaxSendingExpectationTime { get; set; }
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
		/// <summary>
		/// 증빙서류번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("증빙서류번호")]
		public int EvidenceDocumentNumber { get; set; }
	}

}