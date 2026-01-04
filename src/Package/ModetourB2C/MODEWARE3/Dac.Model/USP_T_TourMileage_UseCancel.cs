namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_투어마일리지_사용취소
/// </summary>
public class USP_T_TourMileage_UseCancel
{
	public const string SP_NAME = "USP_T_투어마일리지_사용취소";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 분개번호
		/// </summary>
		[Description("분개번호")]
		public int DivertedNumber { get; set; }
		/// <summary>
		/// USERID
		/// </summary>
		[Description("USERID")]
		public int USERID { get; set; }
		/// <summary>
		/// 취소분개번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("취소분개번호")]
		public int CancelDivertedNumber { get; set; }
		/// <summary>
		/// 응답코드
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 100)]
		[Description("응답코드")]
		public string RespondCode { get; set; }
		/// <summary>
		/// 응답MSG
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 1000)]
		[Description("응답MSG")]
		public string Respond_MSG { get; set; }
		/// <summary>
		/// 결제경로
		/// </summary>
		[Description("결제경로")]
		public string PaymentRoute { get; set; }
		/// <summary>
		/// USERIP
		/// </summary>
		[Description("USERIP")]
		public string USERIP { get; set; }
		/// <summary>
		/// APPNAME
		/// </summary>
		[Description("APPNAME")]
		public string APPNAME { get; set; }
		/// <summary>
		/// 메시지발송여부
		/// </summary>
		[Description("메시지발송여부")]
		public bool MessageSendingOrNot { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 응답코드
		/// </summary>
		[Column("응답코드")]
		public string RespondCode { get; set; }
		/// <summary>
		/// 응답MSG
		/// </summary>
		[Column("응답MSG")]
		public string Respond_MSG { get; set; }
	}
}