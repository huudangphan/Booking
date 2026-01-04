namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// GSP_S_단체명조회
/// </summary>
public class GSP_S_GroupNameFind
{
	public const string SP_NAME = "GSP_S_단체명조회";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 상품코드
		/// </summary>
		[Description("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Description("출발일")]
		public DateTime DepartureDate { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 단체명
		/// </summary>
		[Column("단체명")]
		public string GroupName { get; set; }
	}
}