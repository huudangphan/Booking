namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_마일리지_가족합산마일리지NEW
/// </summary>
public class USP_S_Mileage_TotalFamilyCalculationMileage_NEW
{
	public const string SP_NAME = "USP_S_마일리지_가족합산마일리지NEW";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 회원번호
		/// </summary>
		[Description("회원번호")]
		public string MemberNumber { get; set; }
		/// <summary>
		/// 사용가능마일리지
		/// </summary>
		[DapperParameter(DbType.Int64, ParameterDirection.InputOutput, 8)]
		[Description("사용가능마일리지")]
		public long UsePossibleMileage { get; set; }
		/// <summary>
		/// 가족합산마일리지
		/// </summary>
		[DapperParameter(DbType.Int64, ParameterDirection.InputOutput, 8)]
		[Description("가족합산마일리지")]
		public long FamilySumMilege { get; set; }
		/// <summary>
		/// 사용가능조회여부
		/// </summary>
		[Description("사용가능조회여부")]
		public string UsePossibleSearchOrNot { get; set; }
		/// <summary>
		/// 조회구분
		/// </summary>
		[Description("조회구분")]
		public string SearchClassification { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 회원번호
		/// </summary>
		[Column("회원번호")]
		public string MemberNumber { get; set; }
		/// <summary>
		/// 적립마일리지
		/// </summary>
		[Column("적립마일리지")]
		public long AccumulationMileage { get; set; }
		/// <summary>
		/// 사용마일리지
		/// </summary>
		[Column("사용마일리지")]
		public long UseMileage { get; set; }
		/// <summary>
		/// 소멸마일리지
		/// </summary>
		[Column("소멸마일리지")]
		public long ExtinctedMileage { get; set; }
		/// <summary>
		/// 잔여마일리지
		/// </summary>
		[Column("잔여마일리지")]
		public long BalanceMileage { get; set; }
		/// <summary>
		/// 예정마일리지
		/// </summary>
		[Column("예정마일리지")]
		public long ExpectedMileage { get; set; }
		/// <summary>
		/// 가족마일리지
		/// </summary>
		[Column("가족마일리지")]
		public int FamilyMileage { get; set; }
		/// <summary>
		/// 사용가능마일리지
		/// </summary>
		[Column("사용가능마일리지")]
		public long UsePossibleMileage { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 회원명
		/// </summary>
		[Column("회원명")]
		public string MemberName { get; set; }
		/// <summary>
		/// 관계
		/// </summary>
		[Column("관계")]
		public string Relationship { get; set; }
		/// <summary>
		/// 생년월일
		/// </summary>
		[Column("생년월일")]
		public string BirthYearMonthDay { get; set; }
		/// <summary>
		/// 회원번호
		/// </summary>
		[Column("회원번호")]
		public string MemberNumber { get; set; }
		/// <summary>
		/// 잔여마일리지
		/// </summary>
		[Column("잔여마일리지")]
		public long BalanceMileage { get; set; }
		/// <summary>
		/// 가족일련번호
		/// </summary>
		[Column("가족일련번호")]
		public int FamilySerialNumber { get; set; }
		/// <summary>
		/// SEQ
		/// </summary>
		[Column("SEQ")]
		public long SEQ { get; set; }
	}
}