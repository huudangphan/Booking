namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_대륙나라도시_리스트2
/// </summary>
public class WSP_S_ContinentCountryCity_List2
{
	public const string SP_NAME = "WSP_S_대륙나라도시_리스트2";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 일련번호2
		/// </summary>
		[Description("일련번호2")]
		public int SerialNumber2 { get; set; }
		/// <summary>
		/// STROPTION
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 8000)]
		[Description("STROPTION")]
		public string STROPTION { get; set; }
		/// <summary>
		/// RESULT
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("RESULT")]
		public int RESULT { get; set; }
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