namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_S_CMN_상품문의_삭제
/// </summary>
public class WSP_S_CMN_ProductInquiry_Delete
{
	public const string SP_NAME = "WSP_S_CMN_상품문의_삭제";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 에러내용
		/// </summary>
		[DapperParameter(DbType.String, ParameterDirection.InputOutput, 100)]
		[Description("에러내용")]
		public string ErrorContent { get; set; }
	}

}