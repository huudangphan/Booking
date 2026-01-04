namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// WSP_S_출산유급휴가카운트_MOBILE
/// </summary>
public class WSP_S_ChildbirthPaidVacationCount_MOBILE
{
	public const string SP_NAME = "WSP_S_출산유급휴가카운트_MOBILE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 출산일
		/// </summary>
		[Description("출산일")]
		public string ChildbirthDate { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 휴가일1
		/// </summary>
		[Description("휴가일1")]
		public string VacationDate1 { get; set; }
		/// <summary>
		/// 휴가일2
		/// </summary>
		[Description("휴가일2")]
		public string VacationDate2 { get; set; }
		/// <summary>
		/// 현재일
		/// </summary>
		[Description("현재일")]
		public string CurrentDate { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 유급휴가신청가능여부
		/// </summary>
		[Column("유급휴가신청가능여부")]
		public string PaidVacationRequestPossibleOrNot { get; set; }
		/// <summary>
		/// 출산일
		/// </summary>
		[Column("출산일")]
		public string ChildbirthDate { get; set; }
		/// <summary>
		/// 현재출산휴가사용기간
		/// </summary>
		[Column("현재출산휴가사용기간")]
		public string CurrentChildbirthVacationUsePeriod { get; set; }
		/// <summary>
		/// 유급출산휴가개수
		/// </summary>
		[Column("유급출산휴가개수")]
		public int PaidChildbirthVacationNumber { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 유급휴가신청가능여부
		/// </summary>
		[Column("유급휴가신청가능여부")]
		public string PaidVacationRequestPossibleOrNot { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 유급출산휴가개수
		/// </summary>
		[Column("유급출산휴가개수")]
		public int PaidChildbirthVacationNumber { get; set; }
		/// <summary>
		/// 현재출산휴가사용기간
		/// </summary>
		[Column("현재출산휴가사용기간")]
		public decimal CurrentChildbirthVacationUsePeriod { get; set; }
	}
}