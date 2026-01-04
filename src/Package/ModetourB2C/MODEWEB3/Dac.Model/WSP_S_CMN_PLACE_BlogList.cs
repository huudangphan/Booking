namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_PLACE_블로그리스트
/// </summary>
public class WSP_S_CMN_PLACE_BlogList
{
	public const string SP_NAME = "WSP_S_CMN_PLACE_블로그리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PLID
		/// </summary>
		[Description("PLID")]
		public int PLID { get; set; }
		/// <summary>
		/// PLIDLIST
		/// </summary>
		[Description("PLIDLIST")]
		public string PLIDLIST { get; set; }
		/// <summary>
		/// HiddenYN
		/// </summary>
		[Description("HiddenYN")]
		public string HiddenYN { get; set; }
		/// <summary>
		/// ListCt
		/// </summary>
		[Description("ListCt")]
		public int ListCt { get; set; }
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
		/// 주소
		/// </summary>
		[Column("주소")]
		public string Address { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 블로그주소
		/// </summary>
		[Column("블로그주소")]
		public string BlogAddress { get; set; }
		/// <summary>
		/// 블로그명
		/// </summary>
		[Column("블로그명")]
		public string BlogName { get; set; }
		/// <summary>
		/// 숨김
		/// </summary>
		[Column("숨김")]
		public string Hide { get; set; }
		/// <summary>
		/// 동의여부
		/// </summary>
		[Column("동의여부")]
		public string AgreeOrNot { get; set; }
		/// <summary>
		/// 동의일
		/// </summary>
		[Column("동의일")]
		public DateTime AgreeDate { get; set; }
	}
}