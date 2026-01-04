namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_닷컴_만족도조사_확인
/// </summary>
public class WSP_S_DotCom_SatisfactionRateSurvey_Confirm
{
	public const string SP_NAME = "WSP_S_닷컴_만족도조사_확인";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 예약번호
		/// </summary>
		[Description("예약번호")]
		public int BookingNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Column("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 예약자명
		/// </summary>
		[Column("예약자명")]
		public string BookerName { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 예약번호
		/// </summary>
		[Column("예약번호")]
		public int BookingNumber { get; set; }
		/// <summary>
		/// 디바이스
		/// </summary>
		[Column("디바이스")]
		public string Device { get; set; }
		/// <summary>
		/// 년
		/// </summary>
		[Column("년")]
		public string Year { get; set; }
		/// <summary>
		/// 월
		/// </summary>
		[Column("월")]
		public string Month { get; set; }
		/// <summary>
		/// 별점
		/// </summary>
		[Column("별점")]
		public decimal Rating { get; set; }
		/// <summary>
		/// 메모
		/// </summary>
		[Column("메모")]
		public string Memo { get; set; }
		/// <summary>
		/// IP
		/// </summary>
		[Column("IP")]
		public string IP { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
	}
}