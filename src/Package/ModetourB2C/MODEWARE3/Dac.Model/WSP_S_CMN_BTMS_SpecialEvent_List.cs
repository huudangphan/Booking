namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_BTMS_기획전_리스트
/// </summary>
public class WSP_S_CMN_BTMS_SpecialEvent_List
{
	public const string SP_NAME = "WSP_S_CMN_BTMS_기획전_리스트";

	public class Result : IDbResult
	{
		/// <summary>
		/// 기획전번호
		/// </summary>
		[Column("기획전번호")]
		public int SpecialEventNumber { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Column("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 이미지URL
		/// </summary>
		[Column("이미지URL")]
		public string Image_URL { get; set; }
		/// <summary>
		/// 이동URL
		/// </summary>
		[Column("이동URL")]
		public string Navigation_URL { get; set; }
		/// <summary>
		/// 순서
		/// </summary>
		[Column("순서")]
		public int Order { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Column("등록자")]
		public int Registerer { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 사용여부
		/// </summary>
		[Column("사용여부")]
		public string UseOrNot { get; set; }
		/// <summary>
		/// 게시시작일
		/// </summary>
		[Column("게시시작일")]
		public DateTime PostStartDate { get; set; }
		/// <summary>
		/// 게시종료일
		/// </summary>
		[Column("게시종료일")]
		public DateTime PostEndDate { get; set; }
	}
}