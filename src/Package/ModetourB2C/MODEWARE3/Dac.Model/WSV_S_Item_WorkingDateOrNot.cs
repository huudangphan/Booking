namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSV_S_아이템_근무일여부
/// </summary>
public class WSV_S_Item_WorkingDateOrNot
{
	public const string SP_NAME = "WSV_S_아이템_근무일여부";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 기준일
		/// </summary>
		[Description("기준일")]
		public string StandardDate { get; set; }
		/// <summary>
		/// 근무일여부
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("근무일여부")]
		public string WorkDateOrNot { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 근무일여부
		/// </summary>
		[Column("근무일여부")]
		public string WorkDateOrNot { get; set; }
	}
}