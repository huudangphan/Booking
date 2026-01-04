namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WEB_S_리조트_사진
/// </summary>
public class WEB_S_Resort_Image
{
	public const string SP_NAME = "WEB_S_리조트_사진";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PLID
		/// </summary>
		[Description("PLID")]
		public int PLID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 파일주소
		/// </summary>
		[Column("파일주소")]
		public string FileAddress { get; set; }
		/// <summary>
		/// 사진명
		/// </summary>
		[Column("사진명")]
		public string PictureName { get; set; }
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public Guid Column1 { get; set; }
		/// <summary>
		/// PLCODE
		/// </summary>
		[Column("PLCODE")]
		public string PLCODE { get; set; }
	}
}