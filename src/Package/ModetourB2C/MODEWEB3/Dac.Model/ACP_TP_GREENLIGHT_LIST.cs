namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_TP_GREENLIGHT_LIST
/// </summary>
public class ACP_TP_GREENLIGHT_LIST
{
	public const string SP_NAME = "ACP_TP_GREENLIGHT_LIST";

	public class Result1 : IDbResult
	{
		/// <summary>
		/// BI_IDX
		/// </summary>
		[Column("BI_IDX")]
		public int BI_IDX { get; set; }
		/// <summary>
		/// TITLE
		/// </summary>
		[Column("TITLE")]
		public string TITLE { get; set; }
		/// <summary>
		/// TYPE
		/// </summary>
		[Column("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// IMAGEURL
		/// </summary>
		[Column("IMAGEURL")]
		public string IMAGEURL { get; set; }
		/// <summary>
		/// MAIN_TITLE
		/// </summary>
		[Column("MAIN_TITLE")]
		public string MAIN_TITLE { get; set; }
		/// <summary>
		/// SUB_TITLE1
		/// </summary>
		[Column("SUB_TITLE1")]
		public string SUB_TITLE1 { get; set; }
		/// <summary>
		/// SUB_TITLE2
		/// </summary>
		[Column("SUB_TITLE2")]
		public string SUB_TITLE2 { get; set; }
		/// <summary>
		/// BG_COLOR
		/// </summary>
		[Column("BG_COLOR")]
		public string BG_COLOR { get; set; }
		/// <summary>
		/// FONT_COLOR
		/// </summary>
		[Column("FONT_COLOR")]
		public string FONT_COLOR { get; set; }
		/// <summary>
		/// START_DT
		/// </summary>
		[Column("START_DT")]
		public DateTime START_DT { get; set; }
		/// <summary>
		/// END_DT
		/// </summary>
		[Column("END_DT")]
		public DateTime END_DT { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 특선상품번호
		/// </summary>
		[Column("특선상품번호")]
		public int SpecialSelectionProductNumber { get; set; }
		/// <summary>
		/// 이미지경로
		/// </summary>
		[Column("이미지경로")]
		public string ImageRoute { get; set; }
		/// <summary>
		/// 특가명
		/// </summary>
		[Column("특가명")]
		public string SpecialPriceName { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 성인금액
		/// </summary>
		[Column("성인금액")]
		public long AdultAmount { get; set; }
		/// <summary>
		/// GL_VI
		/// </summary>
		[Column("GL_VI")]
		public double GL_VI { get; set; }
		/// <summary>
		/// GL_목표모객
		/// </summary>
		[Column("GL_목표모객")]
		public long GL_GoalAudience { get; set; }
		/// <summary>
		/// 최종모객
		/// </summary>
		[Column("최종모객")]
		public int FinalAudience { get; set; }
		/// <summary>
		/// SORT
		/// </summary>
		[Column("SORT")]
		public int SORT { get; set; }
		/// <summary>
		/// 출발지역
		/// </summary>
		[Column("출발지역")]
		public string DepartureRegion { get; set; }
		/// <summary>
		/// 항공코드
		/// </summary>
		[Column("항공코드")]
		public string FlightCode { get; set; }
		/// <summary>
		/// GL_여행설명1
		/// </summary>
		[Column("GL_여행설명1")]
		public string GL_TravelExplaination1 { get; set; }
		/// <summary>
		/// GL_여행설명2
		/// </summary>
		[Column("GL_여행설명2")]
		public string GL_TravelExplaination2 { get; set; }
		/// <summary>
		/// GL_여행설명3
		/// </summary>
		[Column("GL_여행설명3")]
		public string GL_TravelExplaination3 { get; set; }
		/// <summary>
		/// 출발도시
		/// </summary>
		[Column("출발도시")]
		public string DepartureCity { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// RE_IDX
		/// </summary>
		[Column("RE_IDX")]
		public int RE_IDX { get; set; }
		/// <summary>
		/// BI_IDX
		/// </summary>
		[Column("BI_IDX")]
		public int BI_IDX { get; set; }
		/// <summary>
		/// START_DT
		/// </summary>
		[Column("START_DT")]
		public DateTime START_DT { get; set; }
		/// <summary>
		/// END_DT
		/// </summary>
		[Column("END_DT")]
		public DateTime END_DT { get; set; }
		/// <summary>
		/// TITLE
		/// </summary>
		[Column("TITLE")]
		public string TITLE { get; set; }
		/// <summary>
		/// CONTENTS
		/// </summary>
		[Column("CONTENTS")]
		public string CONTENTS { get; set; }
		/// <summary>
		/// REGDATE
		/// </summary>
		[Column("REGDATE")]
		public DateTime REGDATE { get; set; }
	}
}