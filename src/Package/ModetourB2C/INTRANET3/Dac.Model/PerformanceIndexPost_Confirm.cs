namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// 성과지표게시물_확정
/// </summary>
public class PerformanceIndexPost_Confirm
{
	public const string SP_NAME = "성과지표게시물_확정";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
	}

}