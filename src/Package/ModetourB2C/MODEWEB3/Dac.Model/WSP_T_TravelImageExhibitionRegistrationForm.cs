namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_여행사진공모전신청서
/// </summary>
public class WSP_T_TravelImageExhibitionRegistrationForm
{
	public const string SP_NAME = "WSP_T_여행사진공모전신청서";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
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
		/// <summary>
		/// 출품사진명
		/// </summary>
		[Description("출품사진명")]
		public string ExhibitedProductPictureName { get; set; }
		/// <summary>
		/// 촬영장소
		/// </summary>
		[Description("촬영장소")]
		public string TakingPhotoPlace { get; set; }
	}

}