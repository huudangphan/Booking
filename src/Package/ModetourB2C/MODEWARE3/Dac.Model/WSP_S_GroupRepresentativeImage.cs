namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_단체대표이미지
/// </summary>
public class WSP_S_GroupRepresentativeImage
{
	public const string SP_NAME = "WSP_S_단체대표이미지";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 대표이미지
		/// </summary>
		[Column("대표이미지")]
		public string RepresentativeImage { get; set; }
		/// <summary>
		/// 대표이미지명
		/// </summary>
		[Column("대표이미지명")]
		public string RepresentativeImageName { get; set; }
	}
}