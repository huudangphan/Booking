namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_T_임원회의자료_삭제
/// </summary>
public class WSP_T_ExecutiveMeetingMaterial_Delete
{
	public const string SP_NAME = "WSP_T_임원회의자료_삭제";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 게시판번호
		/// </summary>
		[Description("게시판번호")]
		public int NoticeboardNumber { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 스텝1
		/// </summary>
		[Description("스텝1")]
		public int Step1 { get; set; }
		/// <summary>
		/// 스텝2
		/// </summary>
		[Description("스텝2")]
		public byte Step2 { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 파일폴더
		/// </summary>
		[Column("파일폴더")]
		public string FileFolder { get; set; }
		/// <summary>
		/// 파일명
		/// </summary>
		[Column("파일명")]
		public string FileName { get; set; }
	}
}