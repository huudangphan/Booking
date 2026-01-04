namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_CMN_INSURANCE_LIST2
/// </summary>
public class WSP_T_CMN_INSURANCE_LIST2
{
	public const string SP_NAME = "WSP_T_CMN_INSURANCE_LIST2";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// Inum
		/// </summary>
		[Description("Inum")]
		public int Inum { get; set; }
		/// <summary>
		/// 보험사
		/// </summary>
		[Description("보험사")]
		public string InsuranceCompany { get; set; }
		/// <summary>
		/// Period
		/// </summary>
		[Description("Period")]
		public int Period { get; set; }
		/// <summary>
		/// CheckIn
		/// </summary>
		[Description("CheckIn")]
		public string CheckIn { get; set; }
		/// <summary>
		/// CheckOut
		/// </summary>
		[Description("CheckOut")]
		public string CheckOut { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// Sort
		/// </summary>
		[Column("Sort")]
		public int Sort { get; set; }
		/// <summary>
		/// KorName
		/// </summary>
		[Column("KorName")]
		public string KorName { get; set; }
		/// <summary>
		/// EngName
		/// </summary>
		[Column("EngName")]
		public string EngName { get; set; }
		/// <summary>
		/// Birth
		/// </summary>
		[Column("Birth")]
		public string Birth { get; set; }
		/// <summary>
		/// Gender
		/// </summary>
		[Column("Gender")]
		public string Gender { get; set; }
		/// <summary>
		/// 플랜
		/// </summary>
		[Column("플랜")]
		public string Plan { get; set; }
		/// <summary>
		/// 금액
		/// </summary>
		[Column("금액")]
		public int Amount { get; set; }
		/// <summary>
		/// 나이
		/// </summary>
		[Column("나이")]
		public int Age { get; set; }
		/// <summary>
		/// CheckIn
		/// </summary>
		[Column("CheckIn")]
		public string CheckIn { get; set; }
		/// <summary>
		/// CheckOut
		/// </summary>
		[Column("CheckOut")]
		public string CheckOut { get; set; }
		/// <summary>
		/// Flag
		/// </summary>
		[Column("Flag")]
		public string Flag { get; set; }
	}
}