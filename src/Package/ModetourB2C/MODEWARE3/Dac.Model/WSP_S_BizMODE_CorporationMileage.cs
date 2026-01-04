namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_비즈모두_법인마일리지
/// </summary>
public class WSP_S_BizMODE_CorporationMileage
{
	public const string SP_NAME = "WSP_S_비즈모두_법인마일리지";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// MTNO
		/// </summary>
		[Description("MTNO")]
		public string MTNO { get; set; }
		/// <summary>
		/// BZNO
		/// </summary>
		[Description("BZNO")]
		public string BZNO { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// COUNT
		/// </summary>
		[Column("COUNT")]
		public int COUNT { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 법인명
		/// </summary>
		[Column("법인명")]
		public string CorporationName { get; set; }
		/// <summary>
		/// MT번호
		/// </summary>
		[Column("MT번호")]
		public string MT_Number { get; set; }
		/// <summary>
		/// 사업자등록번호
		/// </summary>
		[Column("사업자등록번호")]
		public string BusinessLicenseNumber { get; set; }
		/// <summary>
		/// 승인일
		/// </summary>
		[Column("승인일")]
		public DateTime ApprovalDate { get; set; }
		/// <summary>
		/// 적립마일리지
		/// </summary>
		[Column("적립마일리지")]
		public long AccumulationMileage { get; set; }
		/// <summary>
		/// 사용마일리지
		/// </summary>
		[Column("사용마일리지")]
		public long UseMileage { get; set; }
		/// <summary>
		/// 잔여마일리지
		/// </summary>
		[Column("잔여마일리지")]
		public long BalanceMileage { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 일자
		/// </summary>
		[Column("일자")]
		public string Date { get; set; }
		/// <summary>
		/// 거래구분
		/// </summary>
		[Column("거래구분")]
		public string TransactionClassification { get; set; }
		/// <summary>
		/// 마일리지
		/// </summary>
		[Column("마일리지")]
		public long Mileage { get; set; }
	}
}