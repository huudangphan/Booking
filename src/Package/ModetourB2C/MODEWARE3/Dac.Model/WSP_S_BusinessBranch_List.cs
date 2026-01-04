namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_영업지점_리스트
/// </summary>
public class WSP_S_BusinessBranch_List
{
	public const string SP_NAME = "WSP_S_영업지점_리스트";

	public class Result : IDbResult
	{
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
}