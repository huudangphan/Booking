namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_찜여부
/// </summary>
public class WSP_S_FavoriteOrNot
{
	public const string SP_NAME = "WSP_S_찜여부";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 찜여부
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("찜여부")]
		public int FavoriteOrNot { get; set; }
	}

}