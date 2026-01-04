namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// WSP_S_업무요청게시판_카테고리담당_검색
/// </summary>
public class WSP_S_DutyRequestNoticeboard_CategoryResponsibility_Search
{
	public const string SP_NAME = "WSP_S_업무요청게시판_카테고리담당_검색";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 카테고리
		/// </summary>
		[Description("카테고리")]
		public int Category { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
		/// <summary>
		/// MSG
		/// </summary>
		[DapperParameter(DbType.String, ParameterDirection.InputOutput, 100)]
		[Description("MSG")]
		public string MSG { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// idx
		/// </summary>
		[Column("idx")]
		public int idx { get; set; }
		/// <summary>
		/// 담당자
		/// </summary>
		[Column("담당자")]
		public string Manager { get; set; }
		/// <summary>
		/// 카테고리
		/// </summary>
		[Column("카테고리")]
		public int Category { get; set; }
		/// <summary>
		/// 카테고리명
		/// </summary>
		[Column("카테고리명")]
		public string CategoryName { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
	}
}