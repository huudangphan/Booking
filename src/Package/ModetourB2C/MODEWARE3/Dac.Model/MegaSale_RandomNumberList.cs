namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// 메가세일_난수리스트
/// </summary>
public class MegaSale_RandomNumberList
{
	public const string SP_NAME = "메가세일_난수리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 난수
		/// </summary>
		[Description("난수")]
		public string RandomNumber { get; set; }
		/// <summary>
		/// 구분2
		/// </summary>
		[Description("구분2")]
		public string Classification2 { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 난수
		/// </summary>
		[Column("난수")]
		public string RandomNumber { get; set; }
		/// <summary>
		/// 사용유무
		/// </summary>
		[Column("사용유무")]
		public string UseOrNot { get; set; }
	}
}