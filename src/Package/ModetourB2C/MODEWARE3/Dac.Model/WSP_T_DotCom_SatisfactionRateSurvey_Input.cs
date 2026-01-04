namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_닷컴_만족도조사_입력
/// </summary>
public class WSP_T_DotCom_SatisfactionRateSurvey_Input
{
	public const string SP_NAME = "WSP_T_닷컴_만족도조사_입력";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 아이디
		/// </summary>
		[Description("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 예약번호
		/// </summary>
		[Description("예약번호")]
		public int BookingNumber { get; set; }
		/// <summary>
		/// 별점
		/// </summary>
		[Description("별점")]
		public decimal Rating { get; set; }
		/// <summary>
		/// 접속기기
		/// </summary>
		[Description("접속기기")]
		public string AccessEquipment { get; set; }
		/// <summary>
		/// 메모
		/// </summary>
		[Description("메모")]
		public string Memo { get; set; }
		/// <summary>
		/// 접속IP
		/// </summary>
		[Description("접속IP")]
		public string Access_IP { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
	}

}