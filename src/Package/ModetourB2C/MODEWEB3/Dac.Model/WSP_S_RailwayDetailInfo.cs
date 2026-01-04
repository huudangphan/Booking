namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_철도상세정보
/// </summary>
public class WSP_S_RailwayDetailInfo
{
	public const string SP_NAME = "WSP_S_철도상세정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 열차코드
		/// </summary>
		[Description("열차코드")]
		public string TrainCode { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 아이템번호
		/// </summary>
		[Column("아이템번호")]
		public int ItemNumber { get; set; }
		/// <summary>
		/// 열차코드
		/// </summary>
		[Column("열차코드")]
		public string TrainCode { get; set; }
		/// <summary>
		/// 열차명
		/// </summary>
		[Column("열차명")]
		public string TrainName { get; set; }
		/// <summary>
		/// 열차소개
		/// </summary>
		[Column("열차소개")]
		public string TrainIntroduction { get; set; }
	}
}