namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_일정표_출입국정보
/// </summary>
public class WSP_S_ScheduleTable_ImmigrationInfo
{
	public const string SP_NAME = "WSP_S_일정표_출입국정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 장소번호묶음
		/// </summary>
		[Description("장소번호묶음")]
		public string PlaceNumberPack { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 출입국정보번호
		/// </summary>
		[Column("출입국정보번호")]
		public int ImmigrationInfoNumber { get; set; }
		/// <summary>
		/// 장소번호
		/// </summary>
		[Column("장소번호")]
		public int PlaceNumber { get; set; }
		/// <summary>
		/// 파일종류
		/// </summary>
		[Column("파일종류")]
		public string FileType { get; set; }
		/// <summary>
		/// 파일명
		/// </summary>
		[Column("파일명")]
		public string FileName { get; set; }
		/// <summary>
		/// 비고
		/// </summary>
		[Column("비고")]
		public string Note { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Column("등록자")]
		public int Registerer { get; set; }
	}
}