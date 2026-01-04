namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_관광쿠폰_테마
/// </summary>
public class WSP_S_CMN_SightseeingCoupon_Theme
{
	public const string SP_NAME = "WSP_S_CMN_관광쿠폰_테마";

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 그룹명
		/// </summary>
		[Column("그룹명")]
		public string GroupName { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 코드
		/// </summary>
		[Column("코드")]
		public string Code { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
		/// <summary>
		/// 상태1
		/// </summary>
		[Column("상태1")]
		public string State1 { get; set; }
	}
}