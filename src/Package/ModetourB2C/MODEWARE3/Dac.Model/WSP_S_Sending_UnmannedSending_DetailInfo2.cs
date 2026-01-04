namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_센딩_무인센딩_상세정보2
/// </summary>
public class WSP_S_Sending_UnmannedSending_DetailInfo2
{
	public const string SP_NAME = "WSP_S_센딩_무인센딩_상세정보2";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 장소
		/// </summary>
		[Description("장소")]
		public string Place { get; set; }
		/// <summary>
		/// 장소2
		/// </summary>
		[Description("장소2")]
		public string Place2 { get; set; }
		/// <summary>
		/// 공항
		/// </summary>
		[Description("공항")]
		public string Airport { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
	}

}