namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_예약건수_출발일_팀원예약
/// </summary>
public class WSP_S_CMN_ReservationNumber_DepartureDate_TeamMemberReservation
{
	public const string SP_NAME = "WSP_S_CMN_예약건수_출발일_팀원예약";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 시작일
		/// </summary>
		[Description("시작일")]
		public DateTime StartDate { get; set; }
		/// <summary>
		/// 종료일
		/// </summary>
		[Description("종료일")]
		public DateTime EndDate { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 취소
		/// </summary>
		[Description("취소")]
		public string Cancel { get; set; }
		/// <summary>
		/// 정상
		/// </summary>
		[Description("정상")]
		public string Normal { get; set; }
		/// <summary>
		/// 소팀장번호
		/// </summary>
		[Description("소팀장번호")]
		public int SubTeamLeaderNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 직원명
		/// </summary>
		[Column("직원명")]
		public string EmployeeName { get; set; }
		/// <summary>
		/// 예약건수
		/// </summary>
		[Column("예약건수")]
		public int BookingNumber { get; set; }
	}
}