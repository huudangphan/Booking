namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_예약조회_직원
/// </summary>
public class WSP_S_CMN_ReservationFind_Employee
{
	public const string SP_NAME = "WSP_S_CMN_예약조회_직원";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
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
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 예약번호H
		/// </summary>
		[Column("예약번호H")]
		public int BookingNumberH { get; set; }
		/// <summary>
		/// 단체번호H
		/// </summary>
		[Column("단체번호H")]
		public int GroupNumber_H { get; set; }
		/// <summary>
		/// 출발일H
		/// </summary>
		[Column("출발일H")]
		public string DepartureDate_H { get; set; }
		/// <summary>
		/// 취소
		/// </summary>
		[Column("취소")]
		public string Cancel { get; set; }
	}
}