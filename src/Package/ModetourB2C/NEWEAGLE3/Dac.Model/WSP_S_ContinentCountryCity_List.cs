namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_대륙나라도시_리스트
/// </summary>
public class WSP_S_ContinentCountryCity_List
{
	public const string SP_NAME = "WSP_S_대륙나라도시_리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public int Classification { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// pID
		/// </summary>
		[Column("pID")]
		public int pID { get; set; }
		/// <summary>
		/// pName
		/// </summary>
		[Column("pName")]
		public string pName { get; set; }
		/// <summary>
		/// PlaceID
		/// </summary>
		[Column("PlaceID")]
		public int PlaceID { get; set; }
		/// <summary>
		/// 객체영문명
		/// </summary>
		[Column("객체영문명")]
		public string ObjectEnglishName { get; set; }
		/// <summary>
		/// 객체코드
		/// </summary>
		[Column("객체코드")]
		public string ObjectCode { get; set; }
		/// <summary>
		/// 객체타입
		/// </summary>
		[Column("객체타입")]
		public string ObjectType { get; set; }
	}
}