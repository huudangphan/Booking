namespace Modetour.B2C.Entity.Package
{
	public class PlaceImageModel
	{
		/// <summary>
		/// 일정_세부번호
		/// </summary>
		public int ItiDetailNo { get; set; }
		/// <summary>
		/// 서비스종류코드
		/// </summary>
		public string ItiServiceCode { get; set; }
		/// <summary>
		/// 장소이미지 파일번호
		/// </summary>
		public int FileNo { get; set; }
		/// <summary>
		/// 장소번호
		/// </summary>
		public int PlaceNo { get; set; }
		/// <summary>
		/// 파일분류코드
		/// </summary>
		public string FileCategory { get; set; }
		/// <summary>
		/// 파일명
		/// </summary>
		public string FileName { get; set; }
		/// <summary>
		/// 파일크기
		/// </summary>
		public int FileSize { get; set; }
		/// <summary>
		/// 파일경로
		/// </summary>
		public string FilePath { get; set; }
		/// <summary>
		/// 해상도_가로
		/// </summary>
		public int FileWidth { get; set; }
		/// <summary>
		/// 해상도_세로
		/// </summary>
		public int FileHeight { get; set; }
		/// <summary>
		/// 간략설명
		/// </summary>
		public string FileDes { get; set; }
		/// <summary>
		/// 사용가능여부 0 : 1
		/// </summary>
		public int Used { get; set; }
		/// <summary>
		/// 베스트여부 0 : 1
		/// </summary>
		public int Best { get; set; }
		/// <summary>
		/// 파일 노출순서
		/// </summary>
		public int FileSeq { get; set; }
		/// <summary>
		/// 저작권여부
		/// </summary>
		public int Copyright { get; set; }
		/// <summary>
		/// 저작권번호
		/// </summary>
		public int CopyrightNo { get; set; }
		/// <summary>
		/// 파일명_S... 뭐지?
		/// </summary>
		public string FileNameS { get; set; }
		/// <summary>
		/// arr_장소이미지테마
		/// </summary>
		public List<PlaceImageThemeModel> arrTheme { get; set; }
	}
}
