namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_단체_조기예약할인
/// </summary>
public class WSP_S_CMN_Group_EarlyReservationDiscount
{
	public const string SP_NAME = "WSP_S_CMN_단체_조기예약할인";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 몇일전
		/// </summary>
		[Column("몇일전")]
		public int SomeDaysBefore { get; set; }
		/// <summary>
		/// 할인율
		/// </summary>
		[Column("할인율")]
		public decimal DiscountRate { get; set; }
		/// <summary>
		/// 할인액
		/// </summary>
		[Column("할인액")]
		public int DiscountAmount { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 어른
		/// </summary>
		[Column("어른")]
		public string Adult { get; set; }
		/// <summary>
		/// 소아N
		/// </summary>
		[Column("소아N")]
		public string Kid_N { get; set; }
		/// <summary>
		/// 소아E
		/// </summary>
		[Column("소아E")]
		public string Kid_E { get; set; }
		/// <summary>
		/// 유아
		/// </summary>
		[Column("유아")]
		public string Toddler { get; set; }
		/// <summary>
		/// 랜드
		/// </summary>
		[Column("랜드")]
		public string Land { get; set; }
	}
}