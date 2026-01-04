namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_우리모두기획전
/// </summary>
public class WSP_S_CMN_WooriMODESpecialEvent
{
	public const string SP_NAME = "WSP_S_CMN_우리모두기획전";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 게시여부
		/// </summary>
		[Description("게시여부")]
		public string PostOrNot { get; set; }
	}

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
		/// 설명
		/// </summary>
		[Column("설명")]
		public string Explaination { get; set; }
		/// <summary>
		/// 이미지
		/// </summary>
		[Column("이미지")]
		public string Image { get; set; }
		/// <summary>
		/// 링크
		/// </summary>
		[Column("링크")]
		public string Link { get; set; }
		/// <summary>
		/// 개시순서
		/// </summary>
		[Column("개시순서")]
		public int ReleaseOrder { get; set; }
		/// <summary>
		/// 개시여부
		/// </summary>
		[Column("개시여부")]
		public string ReleaseOrNot { get; set; }
		/// <summary>
		/// 새창여부
		/// </summary>
		[Column("새창여부")]
		public string NewWindowOrNot { get; set; }
		/// <summary>
		/// 사용여부
		/// </summary>
		[Column("사용여부")]
		public string UseOrNot { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 태그
		/// </summary>
		[Column("태그")]
		public string Tag { get; set; }
	}
}