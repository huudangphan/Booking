namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_T_임원회의자료_파일열람
/// </summary>
public class WSP_T_ExecutiveMeetingMaterial_FileReading
{
	public const string SP_NAME = "WSP_T_임원회의자료_파일열람";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 순서
		/// </summary>
		[Description("순서")]
		public byte Order { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
	}

}