namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_여행사진공모전_신청서
/// </summary>
public class WSP_S_TravelImageExhibition_RegistrationForm
{
	public const string SP_NAME = "WSP_S_여행사진공모전_신청서";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 공모전횟수
		/// </summary>
		[Description("공모전횟수")]
		public short ExhibitionTimes { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Description("아이디")]
		public string ID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// IDX
		/// </summary>
		[Column("IDX")]
		public int IDX { get; set; }
		/// <summary>
		/// 출품사진명
		/// </summary>
		[Column("출품사진명")]
		public string ExhibitedProductPictureName { get; set; }
		/// <summary>
		/// 촬영장소
		/// </summary>
		[Column("촬영장소")]
		public string TakingPhotoPlace { get; set; }
	}
}