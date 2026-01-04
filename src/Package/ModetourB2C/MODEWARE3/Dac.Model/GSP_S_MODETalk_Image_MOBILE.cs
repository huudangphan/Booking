namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// GSP_S_모두톡_이미지_MOBILE
/// </summary>
public class GSP_S_MODETalk_Image_MOBILE
{
	public const string SP_NAME = "GSP_S_모두톡_이미지_MOBILE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 사원번호
		/// </summary>
		[Description("사원번호")]
		public int StaffNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// profile_image
		/// </summary>
		[Column("profile_image")]
		public string profile_image { get; set; }
	}
}