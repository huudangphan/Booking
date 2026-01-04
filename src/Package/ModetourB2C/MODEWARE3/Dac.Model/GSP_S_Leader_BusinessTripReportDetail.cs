namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// GSP_S_인솔자_출장보고세부
/// </summary>
public class GSP_S_Leader_BusinessTripReportDetail
{
	public const string SP_NAME = "GSP_S_인솔자_출장보고세부";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 조회구분
		/// </summary>
		[Description("조회구분")]
		public string SearchClassification { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public DateTime DepartureDate { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 단체명
		/// </summary>
		[Column("단체명")]
		public string GroupName { get; set; }
		/// <summary>
		/// 코멘트
		/// </summary>
		[Column("코멘트")]
		public string Comment { get; set; }
		/// <summary>
		/// 사건사고
		/// </summary>
		[Column("사건사고")]
		public string Accident { get; set; }
		/// <summary>
		/// 작성일
		/// </summary>
		[Column("작성일")]
		public DateTime WrittingDate { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 일차
		/// </summary>
		[Column("일차")]
		public int First { get; set; }
		/// <summary>
		/// 항목분류
		/// </summary>
		[Column("항목분류")]
		public string ItemClassification { get; set; }
		/// <summary>
		/// 항목분류명
		/// </summary>
		[Column("항목분류명")]
		public string ItemClassificationName { get; set; }
		/// <summary>
		/// 도시번호
		/// </summary>
		[Column("도시번호")]
		public int CityNumber { get; set; }
		/// <summary>
		/// 도시명
		/// </summary>
		[Column("도시명")]
		public string CityName { get; set; }
		/// <summary>
		/// 아이템번호
		/// </summary>
		[Column("아이템번호")]
		public int ItemNumber { get; set; }
		/// <summary>
		/// 아이템명
		/// </summary>
		[Column("아이템명")]
		public string ItemName { get; set; }
		/// <summary>
		/// 항목세부1
		/// </summary>
		[Column("항목세부1")]
		public string ItemDetail1 { get; set; }
		/// <summary>
		/// 항목세부2
		/// </summary>
		[Column("항목세부2")]
		public string ItemDetail2 { get; set; }
		/// <summary>
		/// 항목세부3
		/// </summary>
		[Column("항목세부3")]
		public string ItemDetail3 { get; set; }
		/// <summary>
		/// 조중석
		/// </summary>
		[Column("조중석")]
		public int Cockpit { get; set; }
		/// <summary>
		/// 만족도
		/// </summary>
		[Column("만족도")]
		public int SatisfactionRate { get; set; }
		/// <summary>
		/// 코멘트
		/// </summary>
		[Column("코멘트")]
		public string Comment { get; set; }
		/// <summary>
		/// 정렬순서
		/// </summary>
		[Column("정렬순서")]
		public int SortingOrder { get; set; }
	}
}