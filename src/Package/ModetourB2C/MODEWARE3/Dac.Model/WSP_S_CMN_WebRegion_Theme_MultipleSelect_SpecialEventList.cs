namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_웹지역_테마_다중선택_기획전리스트
/// </summary>
public class WSP_S_CMN_WebRegion_Theme_MultipleSelect_SpecialEventList
{
	public const string SP_NAME = "WSP_S_CMN_웹지역_테마_다중선택_기획전리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 웹지역번호
		/// </summary>
		[Description("웹지역번호")]
		public string WebRegionNumber { get; set; }
		/// <summary>
		/// 웹테마번호
		/// </summary>
		[Description("웹테마번호")]
		public string WebThemeNumber { get; set; }
		/// <summary>
		/// 이벤트타입
		/// </summary>
		[Description("이벤트타입")]
		public string EventType { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 개시수
		/// </summary>
		[Description("개시수")]
		public int ReleaseCount { get; set; }
		/// <summary>
		/// 상위웹지역번호
		/// </summary>
		[Description("상위웹지역번호")]
		public int HighRankWebRegionNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 기획전명
		/// </summary>
		[Column("기획전명")]
		public string SpecialEventName { get; set; }
		/// <summary>
		/// 기획전번호
		/// </summary>
		[Column("기획전번호")]
		public int SpecialEventNumber { get; set; }
		/// <summary>
		/// 이미지1
		/// </summary>
		[Column("이미지1")]
		public string Image1 { get; set; }
		/// <summary>
		/// 이미지2
		/// </summary>
		[Column("이미지2")]
		public string Image2 { get; set; }
		/// <summary>
		/// 이미지3
		/// </summary>
		[Column("이미지3")]
		public string Image3 { get; set; }
		/// <summary>
		/// 이미지4
		/// </summary>
		[Column("이미지4")]
		public string Image4 { get; set; }
		/// <summary>
		/// 이미지5
		/// </summary>
		[Column("이미지5")]
		public string Image5 { get; set; }
		/// <summary>
		/// 이미지6
		/// </summary>
		[Column("이미지6")]
		public string Image6 { get; set; }
		/// <summary>
		/// 이미지7
		/// </summary>
		[Column("이미지7")]
		public string Image7 { get; set; }
		/// <summary>
		/// 이미지8
		/// </summary>
		[Column("이미지8")]
		public string Image8 { get; set; }
		/// <summary>
		/// 이미지9
		/// </summary>
		[Column("이미지9")]
		public string Image9 { get; set; }
		/// <summary>
		/// 이미지10
		/// </summary>
		[Column("이미지10")]
		public string Image10 { get; set; }
		/// <summary>
		/// 이미지F
		/// </summary>
		[Column("이미지F")]
		public string Image_F { get; set; }
		/// <summary>
		/// 경로
		/// </summary>
		[Column("경로")]
		public string Route { get; set; }
		/// <summary>
		/// 게시만료일
		/// </summary>
		[Column("게시만료일")]
		public string PostExpirationDate { get; set; }
		/// <summary>
		/// 타입명
		/// </summary>
		[Column("타입명")]
		public string TypeName { get; set; }
	}
}