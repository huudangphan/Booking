namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WEB_S_리조트_정보
/// </summary>
public class WEB_S_Resort_Info
{
	public const string SP_NAME = "WEB_S_리조트_정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PLID
		/// </summary>
		[Description("PLID")]
		public int PLID { get; set; }
		/// <summary>
		/// INFOTYPE
		/// </summary>
		[Description("INFOTYPE")]
		public int INFOTYPE { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 파일주소
		/// </summary>
		[Column("파일주소")]
		public string FileAddress { get; set; }
		/// <summary>
		/// 사진명
		/// </summary>
		[Column("사진명")]
		public string PictureName { get; set; }
		/// <summary>
		/// PLID
		/// </summary>
		[Column("PLID")]
		public int PLID { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 리조트명
		/// </summary>
		[Column("리조트명")]
		public string ResortName { get; set; }
		/// <summary>
		/// 리조트영문명
		/// </summary>
		[Column("리조트영문명")]
		public string ResortEnglishName { get; set; }
		/// <summary>
		/// 객실명
		/// </summary>
		[Column("객실명")]
		public string GuestRoomName { get; set; }
		/// <summary>
		/// 객실영문명
		/// </summary>
		[Column("객실영문명")]
		public string GuestRoomEnglishName { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// PLID
		/// </summary>
		[Column("PLID")]
		public int PLID { get; set; }
		/// <summary>
		/// INFOTYPE번호
		/// </summary>
		[Column("INFOTYPE번호")]
		public int INFOTYPE_Number { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 리조트명
		/// </summary>
		[Column("리조트명")]
		public string ResortName { get; set; }
		/// <summary>
		/// 리조트영문명
		/// </summary>
		[Column("리조트영문명")]
		public string ResortEnglishName { get; set; }
		/// <summary>
		/// 객실명
		/// </summary>
		[Column("객실명")]
		public string GuestRoomName { get; set; }
		/// <summary>
		/// 객실영문명
		/// </summary>
		[Column("객실영문명")]
		public string GuestRoomEnglishName { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// PLID
		/// </summary>
		[Column("PLID")]
		public int PLID { get; set; }
		/// <summary>
		/// INFOTYPE번호
		/// </summary>
		[Column("INFOTYPE번호")]
		public int INFOTYPE_Number { get; set; }
		/// <summary>
		/// SORT
		/// </summary>
		[Column("SORT")]
		public int SORT { get; set; }
	}
}