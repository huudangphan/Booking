namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_무인센딩_센딩팩보내기_선택일괄
/// </summary>
public class WSP_T_UnmannedSending_SendingBackSending_SelectBatch
{
	public const string SP_NAME = "WSP_T_무인센딩_센딩팩보내기_선택일괄";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 무인센딩전송집합
		/// </summary>
		[DapperParameter(DbType.Object)]
		[Description("무인센딩전송집합")]
		public List<TYPE_UnmannedSendingSendingGathering> ManlessSendingSendingGathering { get; set; }
	}

}