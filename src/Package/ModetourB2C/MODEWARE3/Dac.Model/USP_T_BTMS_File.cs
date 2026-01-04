namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_BTMS_파일
/// </summary>
public class USP_T_BTMS_File
{
	public const string SP_NAME = "USP_T_BTMS_파일";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 파일번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("파일번호")]
		public int FileNumber { get; set; }
		/// <summary>
		/// 파일명
		/// </summary>
		[Description("파일명")]
		public string FileName { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Description("등록자")]
		public int Registerer { get; set; }
	}

}