namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_무인센딩인솔자_체크리스트
/// </summary>
public class WSP_S_UnmannedSendingLeader_CheckList
{
	public const string SP_NAME = "WSP_S_무인센딩인솔자_체크리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// DDAY
		/// </summary>
		[Description("DDAY")]
		public int DDAY { get; set; }
		/// <summary>
		/// 체크자
		/// </summary>
		[Description("체크자")]
		public int Checker { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// DDAY
		/// </summary>
		[Column("DDAY")]
		public int DDAY { get; set; }
		/// <summary>
		/// 체크여부
		/// </summary>
		[Column("체크여부")]
		public string CheckOrNot { get; set; }
		/// <summary>
		/// 사전체크항목
		/// </summary>
		[Column("사전체크항목")]
		public string PreCheckItem { get; set; }
		/// <summary>
		/// 순서
		/// </summary>
		[Column("순서")]
		public int Order { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 체크건수
		/// </summary>
		[Column("체크건수")]
		public int CheckNumber { get; set; }
		/// <summary>
		/// 미체크건수
		/// </summary>
		[Column("미체크건수")]
		public int UncheckNumber { get; set; }
		/// <summary>
		/// 몇일전날짜
		/// </summary>
		[Column("몇일전날짜")]
		public string SomeDaysBeforeDate { get; set; }
	}
}