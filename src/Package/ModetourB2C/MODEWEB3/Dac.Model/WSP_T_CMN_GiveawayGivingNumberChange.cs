namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_CMN_경품지급개수변경
/// </summary>
public class WSP_T_CMN_GiveawayGivingNumberChange
{
	public const string SP_NAME = "WSP_T_CMN_경품지급개수변경";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 경품품목번호
		/// </summary>
		[Description("경품품목번호")]
		public int GiveawayItemNumber { get; set; }
		/// <summary>
		/// 수정개수
		/// </summary>
		[Description("수정개수")]
		public int EditionNumber { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
	}

}