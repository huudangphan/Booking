namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// GSP_S_당직
/// </summary>
public class GSP_S_Duty
{
	public const string SP_NAME = "GSP_S_당직";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 배정시작일
		/// </summary>
		[Description("배정시작일")]
		public DateTime AssignmentStartDate { get; set; }
		/// <summary>
		/// 배정종료일
		/// </summary>
		[Description("배정종료일")]
		public DateTime AssignmentEndDate { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 당직자번호
		/// </summary>
		[Column("당직자번호")]
		public int NightShiftWorkerNumber { get; set; }
		/// <summary>
		/// 당직자
		/// </summary>
		[Column("당직자")]
		public string NightShiftWorker { get; set; }
		/// <summary>
		/// 당직종류
		/// </summary>
		[Column("당직종류")]
		public string NightShiftType { get; set; }
		/// <summary>
		/// 당직일
		/// </summary>
		[Column("당직일")]
		public string NightShiftDate { get; set; }
		/// <summary>
		/// 요일
		/// </summary>
		[Column("요일")]
		public string Day { get; set; }
		/// <summary>
		/// 전체핸드폰
		/// </summary>
		[Column("전체핸드폰")]
		public string EntirePhone { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Column("휴대폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Column("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 순서
		/// </summary>
		[Column("순서")]
		public int Order { get; set; }
	}
}