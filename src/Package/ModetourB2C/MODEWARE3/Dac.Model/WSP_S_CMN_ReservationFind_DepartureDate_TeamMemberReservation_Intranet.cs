namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_예약조회_출발일_팀원예약_인트라넷
/// </summary>
public class WSP_S_CMN_ReservationFind_DepartureDate_TeamMemberReservation_Intranet
{
	public const string SP_NAME = "WSP_S_CMN_예약조회_출발일_팀원예약_인트라넷";

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
		/// 소팀장번호
		/// </summary>
		[Description("소팀장번호")]
		public int SubTeamLeaderNumber { get; set; }
		/// <summary>
		/// 상품분류
		/// </summary>
		[Description("상품분류")]
		public string ProductClassification { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Description("지역")]
		public string Region { get; set; }
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
	}

	public class Result1 : IDbResult
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
		/// 예약일
		/// </summary>
		[Column("예약일")]
		public string BookingDate { get; set; }
		/// <summary>
		/// 상품코드H
		/// </summary>
		[Column("상품코드H")]
		public string ProductCodeH { get; set; }
		/// <summary>
		/// 항공코드H
		/// </summary>
		[Column("항공코드H")]
		public string FlightCode_H { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// GROSS
		/// </summary>
		[Column("GROSS")]
		public long GROSS { get; set; }
		/// <summary>
		/// COMM
		/// </summary>
		[Column("COMM")]
		public long COMM { get; set; }
		/// <summary>
		/// VAT
		/// </summary>
		[Column("VAT")]
		public long VAT { get; set; }
		/// <summary>
		/// CHARGE
		/// </summary>
		[Column("CHARGE")]
		public long CHARGE { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Column("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 거래처명
		/// </summary>
		[Column("거래처명")]
		public string CustomerName { get; set; }
		/// <summary>
		/// 거래처직원번호
		/// </summary>
		[Column("거래처직원번호")]
		public int CustomerEmployeeNumber { get; set; }
		/// <summary>
		/// 거래처직원명
		/// </summary>
		[Column("거래처직원명")]
		public string CustomerEmployeeName { get; set; }
		/// <summary>
		/// 판매직원
		/// </summary>
		[Column("판매직원")]
		public string SalesEmployee { get; set; }
		/// <summary>
		/// 판매op
		/// </summary>
		[Column("판매op")]
		public string Sales_OP { get; set; }
		/// <summary>
		/// 판매OP파트번호
		/// </summary>
		[Column("판매OP파트번호")]
		public int Sales_OP_PartNumber { get; set; }
		/// <summary>
		/// 여행대표자명
		/// </summary>
		[Column("여행대표자명")]
		public string TravelRepresentativeName { get; set; }
		/// <summary>
		/// 여행인원수
		/// </summary>
		[Column("여행인원수")]
		public int TravelNumberOfPeopleNumber { get; set; }
		/// <summary>
		/// 상품분류
		/// </summary>
		[Column("상품분류")]
		public string ProductClassification { get; set; }
		/// <summary>
		/// 수배담당자
		/// </summary>
		[Column("수배담당자")]
		public string WantedManager { get; set; }
		/// <summary>
		/// 수배담당자정보
		/// </summary>
		[Column("수배담당자정보")]
		public string WantedManagerInfo { get; set; }
		/// <summary>
		/// 항공담당자
		/// </summary>
		[Column("항공담당자")]
		public string FlightManager { get; set; }
		/// <summary>
		/// 항공담당자정보
		/// </summary>
		[Column("항공담당자정보")]
		public string FlightManagerInfo { get; set; }
	}

	public class Result2 : IDbResult
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
		/// 예약일
		/// </summary>
		[Column("예약일")]
		public string BookingDate { get; set; }
		/// <summary>
		/// 상품코드H
		/// </summary>
		[Column("상품코드H")]
		public string ProductCodeH { get; set; }
		/// <summary>
		/// 항공코드H
		/// </summary>
		[Column("항공코드H")]
		public string FlightCode_H { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// GROSS
		/// </summary>
		[Column("GROSS")]
		public long GROSS { get; set; }
		/// <summary>
		/// COMM
		/// </summary>
		[Column("COMM")]
		public long COMM { get; set; }
		/// <summary>
		/// VAT
		/// </summary>
		[Column("VAT")]
		public long VAT { get; set; }
		/// <summary>
		/// CHARGE
		/// </summary>
		[Column("CHARGE")]
		public long CHARGE { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Column("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 거래처명
		/// </summary>
		[Column("거래처명")]
		public string CustomerName { get; set; }
		/// <summary>
		/// 거래처직원번호
		/// </summary>
		[Column("거래처직원번호")]
		public int CustomerEmployeeNumber { get; set; }
		/// <summary>
		/// 거래처직원명
		/// </summary>
		[Column("거래처직원명")]
		public string CustomerEmployeeName { get; set; }
		/// <summary>
		/// 판매직원
		/// </summary>
		[Column("판매직원")]
		public string SalesEmployee { get; set; }
		/// <summary>
		/// 판매op
		/// </summary>
		[Column("판매op")]
		public string Sales_OP { get; set; }
		/// <summary>
		/// 여행대표자명
		/// </summary>
		[Column("여행대표자명")]
		public string TravelRepresentativeName { get; set; }
		/// <summary>
		/// 여행인원수
		/// </summary>
		[Column("여행인원수")]
		public int TravelNumberOfPeopleNumber { get; set; }
		/// <summary>
		/// 상품분류
		/// </summary>
		[Column("상품분류")]
		public string ProductClassification { get; set; }
		/// <summary>
		/// 수배담당자
		/// </summary>
		[Column("수배담당자")]
		public string WantedManager { get; set; }
		/// <summary>
		/// 수배담당자정보
		/// </summary>
		[Column("수배담당자정보")]
		public string WantedManagerInfo { get; set; }
		/// <summary>
		/// 항공담당자
		/// </summary>
		[Column("항공담당자")]
		public string FlightManager { get; set; }
		/// <summary>
		/// 항공담당자정보
		/// </summary>
		[Column("항공담당자정보")]
		public string FlightManagerInfo { get; set; }
	}
}