namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_일정별이미지검색
/// </summary>
public class WSP_S_EachScheduleImageSearch
{
	public const string SP_NAME = "WSP_S_일정별이미지검색";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
	}

}