namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_여행사진공모전_댓글
/// </summary>
public class WSP_T_TravelImageExhibition_Comment
{
	public const string SP_NAME = "WSP_T_여행사진공모전_댓글";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 공모전일련번호
		/// </summary>
		[Description("공모전일련번호")]
		public int ExhibitionSerialNumber { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Description("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Description("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 삭제
		/// </summary>
		[Description("삭제")]
		public string Delete { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public int Column1 { get; set; }
	}
}