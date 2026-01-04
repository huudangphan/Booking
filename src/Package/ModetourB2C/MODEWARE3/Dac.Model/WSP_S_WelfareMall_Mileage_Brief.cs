namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_복지몰_마일리지_간략
/// </summary>
public class WSP_S_WelfareMall_Mileage_Brief
{
	public const string SP_NAME = "WSP_S_복지몰_마일리지_간략";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// MT_NO
		/// </summary>
		[Column("MT_NO")]
		public string MT_NO { get; set; }
		/// <summary>
		/// 모두투어마일리지_잔여액
		/// </summary>
		[Column("모두투어마일리지_잔여액")]
		public long MODETOURMileage_Balance { get; set; }
		/// <summary>
		/// 복지몰마일리지_잔여액
		/// </summary>
		[Column("복지몰마일리지_잔여액")]
		public long WelfareMallMileage_Balance { get; set; }
	}
}