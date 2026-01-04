namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_임시박람회VIP고객_조회
/// </summary>
public class WSP_S_TemporaryExhibition_VIP_Customer_Find
{
	public const string SP_NAME = "WSP_S_임시박람회VIP고객_조회";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public string SerialNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public int Column1 { get; set; }
	}
}