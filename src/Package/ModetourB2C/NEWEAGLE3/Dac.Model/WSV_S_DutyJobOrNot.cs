namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSV_S_업무일여부
/// </summary>
public class WSV_S_DutyJobOrNot
{
	public const string SP_NAME = "WSV_S_업무일여부";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 기준일
		/// </summary>
		[Description("기준일")]
		public string StandardDate { get; set; }
		/// <summary>
		/// 업무일여부
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("업무일여부")]
		public string WorkTaskOrNot { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public string Column1 { get; set; }
	}
}