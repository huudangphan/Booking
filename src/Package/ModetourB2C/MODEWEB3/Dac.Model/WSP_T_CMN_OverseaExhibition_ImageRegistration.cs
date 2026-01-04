namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_CMN_해외박람회_이미지등록
/// </summary>
public class WSP_T_CMN_OverseaExhibition_ImageRegistration
{
	public const string SP_NAME = "WSP_T_CMN_해외박람회_이미지등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 해외박람회_이미지
		/// </summary>
		[DapperParameter(DbType.Object)]
		[Description("해외박람회_이미지")]
		public List<TYPE_OverseaExhibition_Image> OverseaExhibition_Image { get; set; }
		/// <summary>
		/// RESULT
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("RESULT")]
		public int RESULT { get; set; }
		/// <summary>
		/// ERRORMSG
		/// </summary>
		[DapperParameter(DbType.String, ParameterDirection.InputOutput, -1)]
		[Description("ERRORMSG")]
		public string ERRORMSG { get; set; }
	}

}