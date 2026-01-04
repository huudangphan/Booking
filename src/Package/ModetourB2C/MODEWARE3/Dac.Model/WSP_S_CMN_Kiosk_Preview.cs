namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_키오스크_미리보기
/// </summary>
public class WSP_S_CMN_Kiosk_Preview
{
	public const string SP_NAME = "WSP_S_CMN_키오스크_미리보기";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// TYPE
		/// </summary>
		[Description("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// 기기번호
		/// </summary>
		[Description("기기번호")]
		public int EquipmentNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 템플릿타입코드
		/// </summary>
		[Column("템플릿타입코드")]
		public string TemplateTypeCode { get; set; }
		/// <summary>
		/// 배경이미지타입코드
		/// </summary>
		[Column("배경이미지타입코드")]
		public string BackgroundImageTypeCode { get; set; }
		/// <summary>
		/// 이미지명
		/// </summary>
		[Column("이미지명")]
		public string ImageName { get; set; }
		/// <summary>
		/// 이미지경로
		/// </summary>
		[Column("이미지경로")]
		public string ImageRoute { get; set; }
		/// <summary>
		/// 폰트색상
		/// </summary>
		[Column("폰트색상")]
		public string FontColor { get; set; }
		/// <summary>
		/// 상단문구
		/// </summary>
		[Column("상단문구")]
		public string TopWords { get; set; }
		/// <summary>
		/// 중간문구
		/// </summary>
		[Column("중간문구")]
		public string MiddleWords { get; set; }
		/// <summary>
		/// 하단문구
		/// </summary>
		[Column("하단문구")]
		public string BottomWords { get; set; }
	}
}