namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_부서소팀
/// </summary>
public class USP_S_DepartmentSubTeam
{
	public const string SP_NAME = "USP_S_부서소팀";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 종류
		/// </summary>
		[Description("종류")]
		public string Type { get; set; }
		/// <summary>
		/// 세부종류
		/// </summary>
		[Description("세부종류")]
		public string DetailType { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 선택
		/// </summary>
		[Column("선택")]
		public string Select { get; set; }
		/// <summary>
		/// 코드
		/// </summary>
		[Column("코드")]
		public int Code { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
		/// <summary>
		/// 부서번호
		/// </summary>
		[Column("부서번호")]
		public int DepartmentNumber { get; set; }
		/// <summary>
		/// 부서명
		/// </summary>
		[Column("부서명")]
		public string DepartmentName { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 선택
		/// </summary>
		[Column("선택")]
		public string Select { get; set; }
		/// <summary>
		/// 코드
		/// </summary>
		[Column("코드")]
		public int Code { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 코드
		/// </summary>
		[Column("코드")]
		public int Code { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// 선택
		/// </summary>
		[Column("선택")]
		public string Select { get; set; }
		/// <summary>
		/// 코드
		/// </summary>
		[Column("코드")]
		public int Code { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
		/// <summary>
		/// 순번
		/// </summary>
		[Column("순번")]
		public int Order { get; set; }
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// 코드
		/// </summary>
		[Column("코드")]
		public int Code { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
		/// <summary>
		/// 순서
		/// </summary>
		[Column("순서")]
		public int Order { get; set; }
	}

	public class Result6 : IDbResult
	{
		/// <summary>
		/// 코드
		/// </summary>
		[Column("코드")]
		public int Code { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public int Sorting { get; set; }
	}

	public class Result7 : IDbResult
	{
		/// <summary>
		/// 대본부번호
		/// </summary>
		[Column("대본부번호")]
		public int HeadOfficeNumber { get; set; }
		/// <summary>
		/// 대본부명
		/// </summary>
		[Column("대본부명")]
		public string HeadOfficeName { get; set; }
		/// <summary>
		/// 소본부번호
		/// </summary>
		[Column("소본부번호")]
		public int SubHeadofficeNumber { get; set; }
		/// <summary>
		/// 소본부명
		/// </summary>
		[Column("소본부명")]
		public string SubHeadofficeName { get; set; }
	}
}