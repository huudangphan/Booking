namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_TM_SNS_SHARE_COUNT
/// </summary>
public class WSP_S_CMN_TM_SNS_SHARE_COUNT
{
	public const string SP_NAME = "WSP_S_CMN_TM_SNS_SHARE_COUNT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// Year
		/// </summary>
		[Description("Year")]
		public string Year { get; set; }
		/// <summary>
		/// Month
		/// </summary>
		[Description("Month")]
		public string Month { get; set; }
		/// <summary>
		/// PivotGubun
		/// </summary>
		[Description("PivotGubun")]
		public string PivotGubun { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// EmotionalCnt
		/// </summary>
		[Column("EmotionalCnt")]
		public int EmotionalCnt { get; set; }
		/// <summary>
		/// PlaceCnt
		/// </summary>
		[Column("PlaceCnt")]
		public int PlaceCnt { get; set; }
		/// <summary>
		/// RealtipCnt
		/// </summary>
		[Column("RealtipCnt")]
		public int RealtipCnt { get; set; }
		/// <summary>
		/// StorymCnt
		/// </summary>
		[Column("StorymCnt")]
		public int StorymCnt { get; set; }
		/// <summary>
		/// TvMCnt
		/// </summary>
		[Column("TvMCnt")]
		public int TvMCnt { get; set; }
		/// <summary>
		/// AudioMCnt
		/// </summary>
		[Column("AudioMCnt")]
		public int AudioMCnt { get; set; }
		/// <summary>
		/// RegYY
		/// </summary>
		[Column("RegYY")]
		public int RegYY { get; set; }
		/// <summary>
		/// RegMM
		/// </summary>
		[Column("RegMM")]
		public int RegMM { get; set; }
		/// <summary>
		/// RegDD
		/// </summary>
		[Column("RegDD")]
		public int RegDD { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// FacebookCnt
		/// </summary>
		[Column("FacebookCnt")]
		public int FacebookCnt { get; set; }
		/// <summary>
		/// TwitterCnt
		/// </summary>
		[Column("TwitterCnt")]
		public int TwitterCnt { get; set; }
		/// <summary>
		/// KakaoTalkCnt
		/// </summary>
		[Column("KakaoTalkCnt")]
		public int KakaoTalkCnt { get; set; }
		/// <summary>
		/// RegYY
		/// </summary>
		[Column("RegYY")]
		public int RegYY { get; set; }
		/// <summary>
		/// RegMM
		/// </summary>
		[Column("RegMM")]
		public int RegMM { get; set; }
		/// <summary>
		/// RegDD
		/// </summary>
		[Column("RegDD")]
		public int RegDD { get; set; }
	}
}