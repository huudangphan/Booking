namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_BATCH_네이버_2021
/// </summary>
public class WSP_S_BATCH_Naver_2021
{
	public const string SP_NAME = "WSP_S_BATCH_네이버_2021";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 상품코드2
		/// </summary>
		[Description("상품코드2")]
		public string ProductCode2 { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 상품코드2
		/// </summary>
		[Column("상품코드2")]
		public string ProductCode2 { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 항공코드
		/// </summary>
		[Column("항공코드")]
		public string FlightCode { get; set; }
		/// <summary>
		/// 단체명
		/// </summary>
		[Column("단체명")]
		public string GroupName { get; set; }
		/// <summary>
		/// 성인금액
		/// </summary>
		[Column("성인금액")]
		public long AdultAmount { get; set; }
		/// <summary>
		/// 성인_유류할증료
		/// </summary>
		[Column("성인_유류할증료")]
		public long Adult_FuelSurchargeFee { get; set; }
		/// <summary>
		/// 성인_제세공과금
		/// </summary>
		[Column("성인_제세공과금")]
		public long Adult_PublicFacilitiesTax { get; set; }
		/// <summary>
		/// 소아금액
		/// </summary>
		[Column("소아금액")]
		public long KidAmount { get; set; }
		/// <summary>
		/// 소아_유류할증료
		/// </summary>
		[Column("소아_유류할증료")]
		public long Kid_FuelSurchargeFee { get; set; }
		/// <summary>
		/// 소아_제세공과금
		/// </summary>
		[Column("소아_제세공과금")]
		public long Kid_PublicFacilitiesTax { get; set; }
		/// <summary>
		/// 유아금액
		/// </summary>
		[Column("유아금액")]
		public long ToddlerAmount { get; set; }
		/// <summary>
		/// 긴급모객여부
		/// </summary>
		[Column("긴급모객여부")]
		public string EmergencyAudienceOrNot { get; set; }
		/// <summary>
		/// 최소출발인원
		/// </summary>
		[Column("최소출발인원")]
		public int MinimumDepartureNumberOfPeople { get; set; }
		/// <summary>
		/// 최대출발인원
		/// </summary>
		[Column("최대출발인원")]
		public int MaximumDepartureNumberOfPeople { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public DateTime DepartureDate { get; set; }
		/// <summary>
		/// 판매마감
		/// </summary>
		[Column("판매마감")]
		public string SalesEnd { get; set; }
		/// <summary>
		/// 출발확정
		/// </summary>
		[Column("출발확정")]
		public string DepartureConfirm { get; set; }
		/// <summary>
		/// 잔여좌석
		/// </summary>
		[Column("잔여좌석")]
		public string AvailableSeat { get; set; }
	}
}