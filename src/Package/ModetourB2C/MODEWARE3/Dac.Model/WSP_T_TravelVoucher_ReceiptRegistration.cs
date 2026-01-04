namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_여행상품권_수령등록
/// </summary>
public class WSP_T_TravelVoucher_ReceiptRegistration
{
	public const string SP_NAME = "WSP_T_여행상품권_수령등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 여행상품권번호
		/// </summary>
		[Description("여행상품권번호")]
		public string TravelVoucherNumber { get; set; }
		/// <summary>
		/// PIN번호
		/// </summary>
		[Description("PIN번호")]
		public string PIN_Number { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// PTKNAME
		/// </summary>
		[Description("PTKNAME")]
		public string PTKNAME { get; set; }
		/// <summary>
		/// RETURN
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("RETURN")]
		public int RETURN { get; set; }
	}

}