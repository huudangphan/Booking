namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_가족합산_첨부파일
/// </summary>
public class USP_T_TotalFamilyCalculation_AttachedFile
{
	public const string SP_NAME = "USP_T_가족합산_첨부파일";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 마스터번호
		/// </summary>
		[Description("마스터번호")]
		public int MasterNumber { get; set; }
		/// <summary>
		/// 첨부파일
		/// </summary>
		[Description("첨부파일")]
		public string AttachFile { get; set; }
	}

}