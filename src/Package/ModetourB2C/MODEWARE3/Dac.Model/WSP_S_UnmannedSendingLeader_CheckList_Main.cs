namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_무인센딩인솔자_체크리스트_메인
/// </summary>
public class WSP_S_UnmannedSendingLeader_CheckList_Main
{
	public const string SP_NAME = "WSP_S_무인센딩인솔자_체크리스트_메인";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 체크자
		/// </summary>
		[Description("체크자")]
		public int Checker { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 몇일전
		/// </summary>
		[Column("몇일전")]
		public int SomeDaysBefore { get; set; }
		/// <summary>
		/// 미체크건수
		/// </summary>
		[Column("미체크건수")]
		public int UncheckNumber { get; set; }
	}
}