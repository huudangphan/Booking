namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_이벤트특선_허니문
/// </summary>
public class WSP_S_EventSpecialSelection_Honeymoon
{
	public const string SP_NAME = "WSP_S_이벤트특선_허니문";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 이벤트구역명
		/// </summary>
		[Description("이벤트구역명")]
		public string EventAreaName { get; set; }
		/// <summary>
		/// 위치
		/// </summary>
		[Description("위치")]
		public string Position { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 특선상품번호
		/// </summary>
		[Column("특선상품번호")]
		public int SpecialSelectionProductNumber { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
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
		/// 간략설명
		/// </summary>
		[Column("간략설명")]
		public string BriefDescription { get; set; }
		/// <summary>
		/// 이미지경로
		/// </summary>
		[Column("이미지경로")]
		public string ImageRoute { get; set; }
		/// <summary>
		/// MLOC
		/// </summary>
		[Column("MLOC")]
		public string MLOC { get; set; }
		/// <summary>
		/// 최소가격
		/// </summary>
		[Column("최소가격")]
		public long MinimumPrice { get; set; }
		/// <summary>
		/// 최대가격
		/// </summary>
		[Column("최대가격")]
		public long MaximumPrice { get; set; }
		/// <summary>
		/// 중간제목
		/// </summary>
		[Column("중간제목")]
		public string MiddleTitle { get; set; }
		/// <summary>
		/// 순서
		/// </summary>
		[Column("순서")]
		public int Order { get; set; }
		/// <summary>
		/// 이미지
		/// </summary>
		[Column("이미지")]
		public string Image { get; set; }
	}
}