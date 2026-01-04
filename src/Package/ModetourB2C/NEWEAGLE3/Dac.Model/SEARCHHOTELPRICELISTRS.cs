namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// SEARCHHOTELPRICELISTRS
/// </summary>
public class SEARCHHOTELPRICELISTRS
{
	public const string SP_NAME = "SEARCHHOTELPRICELISTRS";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// ULC
		/// </summary>
		[Description("ULC")]
		public string ULC { get; set; }
		/// <summary>
		/// CPN
		/// </summary>
		[Description("CPN")]
		public int CPN { get; set; }
		/// <summary>
		/// CTC
		/// </summary>
		[Description("CTC")]
		public string CTC { get; set; }
		/// <summary>
		/// CCD
		/// </summary>
		[Description("CCD")]
		public int CCD { get; set; }
		/// <summary>
		/// CKI
		/// </summary>
		[Description("CKI")]
		public DateTime CKI { get; set; }
		/// <summary>
		/// DRN
		/// </summary>
		[Description("DRN")]
		public int DRN { get; set; }
		/// <summary>
		/// RCD
		/// </summary>
		[Description("RCD")]
		public string RCD { get; set; }
		/// <summary>
		/// RNM
		/// </summary>
		[Description("RNM")]
		public string RNM { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// RoomKey
		/// </summary>
		[Column("RoomKey")]
		public string RoomKey { get; set; }
		/// <summary>
		/// 아이템번호
		/// </summary>
		[Column("아이템번호")]
		public int ItemNumber { get; set; }
		/// <summary>
		/// 객실번호
		/// </summary>
		[Column("객실번호")]
		public int GuestRoomNumber { get; set; }
		/// <summary>
		/// 객실타입코드
		/// </summary>
		[Column("객실타입코드")]
		public string GuestRoomTypeCode { get; set; }
		/// <summary>
		/// 객실명
		/// </summary>
		[Column("객실명")]
		public string GuestRoomName { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Column("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 조식
		/// </summary>
		[Column("조식")]
		public string Breakfast { get; set; }
		/// <summary>
		/// 도시코드
		/// </summary>
		[Column("도시코드")]
		public string CityCode { get; set; }
		/// <summary>
		/// 도시번호
		/// </summary>
		[Column("도시번호")]
		public int CityNumber { get; set; }
		/// <summary>
		/// RCD
		/// </summary>
		[Column("RCD")]
		public string RCD { get; set; }
		/// <summary>
		/// RNM
		/// </summary>
		[Column("RNM")]
		public int RNM { get; set; }
		/// <summary>
		/// 아이템명
		/// </summary>
		[Column("아이템명")]
		public string ItemName { get; set; }
		/// <summary>
		/// 아이템코드
		/// </summary>
		[Column("아이템코드")]
		public string ItemCode { get; set; }
		/// <summary>
		/// 조식포함여부
		/// </summary>
		[Column("조식포함여부")]
		public string BreakfastIncludeOrNot { get; set; }
		/// <summary>
		/// 체크인
		/// </summary>
		[Column("체크인")]
		public DateTime CheckIn { get; set; }
		/// <summary>
		/// 투숙일수
		/// </summary>
		[Column("투숙일수")]
		public int NumberOfStayDays { get; set; }
		/// <summary>
		/// 취소마감일
		/// </summary>
		[Column("취소마감일")]
		public DateTime CancellationEndDate { get; set; }
		/// <summary>
		/// DayCount
		/// </summary>
		[Column("DayCount")]
		public int DayCount { get; set; }
		/// <summary>
		/// 판매가
		/// </summary>
		[Column("판매가")]
		public int SellingPrice { get; set; }
	}
}