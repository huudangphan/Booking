namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSV_S_아이템_로그인
/// </summary>
public class WSV_S_Item_Login
{
	public const string SP_NAME = "WSV_S_아이템_로그인";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// KEY
		/// </summary>
		[Description("KEY")]
		public string KEY { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 고유번호
		/// </summary>
		[Column("고유번호")]
		public string UniqueNumber { get; set; }
		/// <summary>
		/// 품목코드
		/// </summary>
		[Column("품목코드")]
		public string ProductListCode { get; set; }
		/// <summary>
		/// URL
		/// </summary>
		[Column("URL")]
		public string URL { get; set; }
		/// <summary>
		/// DATA
		/// </summary>
		[Column("DATA")]
		public string DATA { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
	}
}