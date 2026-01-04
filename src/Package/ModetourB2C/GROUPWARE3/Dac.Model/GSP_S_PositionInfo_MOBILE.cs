namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// GSP_S_위치정보_MOBILE
/// </summary>
public class GSP_S_PositionInfo_MOBILE
{
	public const string SP_NAME = "GSP_S_위치정보_MOBILE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 직원번호
		/// </summary>
		[Column("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 주소
		/// </summary>
		[Column("주소")]
		public string Address { get; set; }
		/// <summary>
		/// 위도
		/// </summary>
		[Column("위도")]
		public double Latitude { get; set; }
		/// <summary>
		/// 경도
		/// </summary>
		[Column("경도")]
		public double Longtitude { get; set; }
		/// <summary>
		/// 등록일자
		/// </summary>
		[Column("등록일자")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
	}
}