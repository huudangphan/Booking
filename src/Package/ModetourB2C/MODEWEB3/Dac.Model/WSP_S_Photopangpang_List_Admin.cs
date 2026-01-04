namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_포토팡팡_리스트_관리자
/// </summary>
public class WSP_S_Photopangpang_List_Admin
{
	public const string SP_NAME = "WSP_S_포토팡팡_리스트_관리자";

	public class Result : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 사진
		/// </summary>
		[Column("사진")]
		public string Picture { get; set; }
		/// <summary>
		/// 작성일
		/// </summary>
		[Column("작성일")]
		public DateTime WrittingDate { get; set; }
		/// <summary>
		/// 여행지
		/// </summary>
		[Column("여행지")]
		public string TravelSpot { get; set; }
		/// <summary>
		/// 정보반영
		/// </summary>
		[Column("정보반영")]
		public bool InfoReflect { get; set; }
	}
}