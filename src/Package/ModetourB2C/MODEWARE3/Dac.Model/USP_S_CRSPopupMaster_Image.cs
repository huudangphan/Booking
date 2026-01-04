namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_CRS팝업마스터_이미지
/// </summary>
public class USP_S_CRSPopupMaster_Image
{
	public const string SP_NAME = "USP_S_CRS팝업마스터_이미지";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Description("거래처번호")]
		public int CustomerNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 순서
		/// </summary>
		[Column("순서")]
		public int Order { get; set; }
		/// <summary>
		/// 탭명
		/// </summary>
		[Column("탭명")]
		public string TabName { get; set; }
		/// <summary>
		/// 이미지경로
		/// </summary>
		[Column("이미지경로")]
		public string ImageRoute { get; set; }
		/// <summary>
		/// 접속URL
		/// </summary>
		[Column("접속URL")]
		public string AccessURL { get; set; }
		/// <summary>
		/// 마스터일련번호
		/// </summary>
		[Column("마스터일련번호")]
		public int MasterSerialNumber { get; set; }
	}
}