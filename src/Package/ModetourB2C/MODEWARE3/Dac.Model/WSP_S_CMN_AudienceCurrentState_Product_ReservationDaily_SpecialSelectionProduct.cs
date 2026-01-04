namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_모객현황_상품_예약일별_특선상품
/// </summary>
public class WSP_S_CMN_AudienceCurrentState_Product_ReservationDaily_SpecialSelectionProduct
{
	public const string SP_NAME = "WSP_S_CMN_모객현황_상품_예약일별_특선상품";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// IDX
		/// </summary>
		[Description("IDX")]
		public int IDX { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 시작일
		/// </summary>
		[Description("시작일")]
		public string StartDate { get; set; }
		/// <summary>
		/// 종료일
		/// </summary>
		[Description("종료일")]
		public string EndDate { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public DateTime DepartureDate { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 판매일상세
		/// </summary>
		[Column("판매일상세")]
		public DateTime SalesDateDetail { get; set; }
		/// <summary>
		/// 판매일
		/// </summary>
		[Column("판매일")]
		public string SalesDate { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
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
	}
}