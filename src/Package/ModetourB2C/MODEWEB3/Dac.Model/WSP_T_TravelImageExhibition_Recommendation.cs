namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_여행사진공모전_추천
/// </summary>
public class WSP_T_TravelImageExhibition_Recommendation
{
	public const string SP_NAME = "WSP_T_여행사진공모전_추천";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 공모전횟수
		/// </summary>
		[Description("공모전횟수")]
		public short ExhibitionTimes { get; set; }
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