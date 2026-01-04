namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_관광청마케팅메일수신동의
/// </summary>
public class WSP_T_TourismBureauMarketingMailReceiptAgree
{
	public const string SP_NAME = "WSP_T_관광청마케팅메일수신동의";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// IDX
		/// </summary>
		[Description("IDX")]
		public int IDX { get; set; }
		/// <summary>
		/// RETURN
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 2)]
		[Description("RETURN")]
		public string RETURN { get; set; }
	}

}