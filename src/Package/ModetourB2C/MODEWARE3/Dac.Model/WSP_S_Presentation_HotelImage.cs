namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_설명회_호텔사진
/// </summary>
public class WSP_S_Presentation_HotelImage
{
	public const string SP_NAME = "WSP_S_설명회_호텔사진";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 호텔번호
		/// </summary>
		[Description("호텔번호")]
		public string HotelNumber { get; set; }
		/// <summary>
		/// LISTCOUNT
		/// </summary>
		[Description("LISTCOUNT")]
		public int LISTCOUNT { get; set; }
		/// <summary>
		/// ROWCOUNT
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("ROWCOUNT")]
		public int ROWCOUNT { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// PLACEIMAGE번호
		/// </summary>
		[Column("PLACEIMAGE번호")]
		public int PLACEIMAGE_Number { get; set; }
		/// <summary>
		/// PLACEINFO번호
		/// </summary>
		[Column("PLACEINFO번호")]
		public int PLACEINFO_Number { get; set; }
		/// <summary>
		/// 파일명
		/// </summary>
		[Column("파일명")]
		public string FileName { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 호텔번호
		/// </summary>
		[Column("호텔번호")]
		public int HotelNumber { get; set; }
	}
}