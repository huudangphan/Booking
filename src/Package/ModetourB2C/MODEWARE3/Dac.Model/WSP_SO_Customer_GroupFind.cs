namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_SO_거래처_단체조회
/// </summary>
public class WSP_SO_Customer_GroupFind
{
	public const string SP_NAME = "WSP_SO_거래처_단체조회";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 출발시작일
		/// </summary>
		[Description("출발시작일")]
		public string DepartureStartDate { get; set; }
		/// <summary>
		/// 출발종료일
		/// </summary>
		[Description("출발종료일")]
		public string DepartureEndDate { get; set; }
		/// <summary>
		/// 검색구분
		/// </summary>
		[Description("검색구분")]
		public string SearchingClassification { get; set; }
		/// <summary>
		/// 키워드
		/// </summary>
		[Description("키워드")]
		public string Keyword { get; set; }
		/// <summary>
		/// 모객
		/// </summary>
		[Description("모객")]
		public string Audience { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 항공코드
		/// </summary>
		[Column("항공코드")]
		public string FlightCode { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 선택
		/// </summary>
		[Column("선택")]
		public string Select { get; set; }
		/// <summary>
		/// 상품일정명
		/// </summary>
		[Column("상품일정명")]
		public string ProductScheduleName { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 일정번호
		/// </summary>
		[Column("일정번호")]
		public int ScheduleNumber { get; set; }
		/// <summary>
		/// 여행기간
		/// </summary>
		[Column("여행기간")]
		public string TravelPeriod { get; set; }
		/// <summary>
		/// 인원
		/// </summary>
		[Column("인원")]
		public int NumberOfPeople { get; set; }
		/// <summary>
		/// 지역코드
		/// </summary>
		[Column("지역코드")]
		public string RegionCode { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Column("지역")]
		public string Region { get; set; }
		/// <summary>
		/// 대표국가
		/// </summary>
		[Column("대표국가")]
		public string RepresentativeCountry { get; set; }
		/// <summary>
		/// 대표도시
		/// </summary>
		[Column("대표도시")]
		public string RepresentativeCity { get; set; }
		/// <summary>
		/// 박
		/// </summary>
		[Column("박")]
		public byte Night { get; set; }
		/// <summary>
		/// 일
		/// </summary>
		[Column("일")]
		public byte Date { get; set; }
		/// <summary>
		/// 지역번호
		/// </summary>
		[Column("지역번호")]
		public string RegionNumber { get; set; }
		/// <summary>
		/// 대표국가번호
		/// </summary>
		[Column("대표국가번호")]
		public int RepresentativeCountryNumber { get; set; }
		/// <summary>
		/// 대표도시번호
		/// </summary>
		[Column("대표도시번호")]
		public int RepresentativeCityNumber { get; set; }
		/// <summary>
		/// 상품부서번호
		/// </summary>
		[Column("상품부서번호")]
		public int ProductDepartmentNumber { get; set; }
		/// <summary>
		/// 상품부서
		/// </summary>
		[Column("상품부서")]
		public string ProductDepartment { get; set; }
		/// <summary>
		/// 상품담당자번호
		/// </summary>
		[Column("상품담당자번호")]
		public int ProductManagerNumber { get; set; }
		/// <summary>
		/// 상품담당자
		/// </summary>
		[Column("상품담당자")]
		public string ProductManager { get; set; }
		/// <summary>
		/// 도착일
		/// </summary>
		[Column("도착일")]
		public string ArrivalDate { get; set; }
		/// <summary>
		/// 상품코드2
		/// </summary>
		[Column("상품코드2")]
		public string ProductCode2 { get; set; }
		/// <summary>
		/// 포함비고
		/// </summary>
		[Column("포함비고")]
		public string IncludedNote { get; set; }
		/// <summary>
		/// 불포함비고
		/// </summary>
		[Column("불포함비고")]
		public string UnincludedNote { get; set; }
	}
}