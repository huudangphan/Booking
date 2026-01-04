namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_이벤트_세부구분_리스트
/// </summary>
public class WSP_S_CMN_Event_DetailClassification_List
{
	public const string SP_NAME = "WSP_S_CMN_이벤트_세부구분_리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구역번호
		/// </summary>
		[Description("구역번호")]
		public int AreaNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 상세구분명
		/// </summary>
		[Column("상세구분명")]
		public string DetailClassificationName { get; set; }
		/// <summary>
		/// 세부구분번호
		/// </summary>
		[Column("세부구분번호")]
		public int DetailClassificationNumber { get; set; }
		/// <summary>
		/// 구역번호
		/// </summary>
		[Column("구역번호")]
		public int AreaNumber { get; set; }
		/// <summary>
		/// 세부구분명
		/// </summary>
		[Column("세부구분명")]
		public string DetailClassificationName2 { get; set; }
		/// <summary>
		/// 순서
		/// </summary>
		[Column("순서")]
		public int Order { get; set; }
		/// <summary>
		/// 사용여부
		/// </summary>
		[Column("사용여부")]
		public string UseOrNot { get; set; }
	}
}