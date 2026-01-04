namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_모바일웹기획전
/// </summary>
public class WSP_S_CMN_MobileWebSpecialEvent
{
	public const string SP_NAME = "WSP_S_CMN_모바일웹기획전";

	public class Result : IDbResult
	{
		/// <summary>
		/// 모바일순서
		/// </summary>
		[Column("모바일순서")]
		public int MobileOrder { get; set; }
		/// <summary>
		/// 기획전번호
		/// </summary>
		[Column("기획전번호")]
		public int SpecialEventNumber { get; set; }
		/// <summary>
		/// 이미지_모바일
		/// </summary>
		[Column("이미지_모바일")]
		public string Image_Mobile { get; set; }
		/// <summary>
		/// 모바일_메인
		/// </summary>
		[Column("모바일_메인")]
		public string Mobile_Main { get; set; }
		/// <summary>
		/// 경로
		/// </summary>
		[Column("경로")]
		public string Route { get; set; }
		/// <summary>
		/// 기획전명
		/// </summary>
		[Column("기획전명")]
		public string SpecialEventName { get; set; }
		/// <summary>
		/// 게시시작일
		/// </summary>
		[Column("게시시작일")]
		public DateTime PostStartDate { get; set; }
		/// <summary>
		/// 게시만료일
		/// </summary>
		[Column("게시만료일")]
		public DateTime PostExpirationDate { get; set; }
	}
}