namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_무인센딩인솔자_이슈사항_구분리스트
/// </summary>
public class WSP_S_UnmannedSendingLeader_Issues_ClassificationList
{
	public const string SP_NAME = "WSP_S_무인센딩인솔자_이슈사항_구분리스트";

	public class Result : IDbResult
	{
		/// <summary>
		/// 구분명
		/// </summary>
		[Column("구분명")]
		public string ClassificationName { get; set; }
		/// <summary>
		/// 구분코드
		/// </summary>
		[Column("구분코드")]
		public string ClassificationCode { get; set; }
	}
}