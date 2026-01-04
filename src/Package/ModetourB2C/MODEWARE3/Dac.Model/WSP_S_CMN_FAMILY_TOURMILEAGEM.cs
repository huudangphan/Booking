namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_FAMILY_TOURMILEAGEM
/// </summary>
public class WSP_S_CMN_FAMILY_TOURMILEAGEM
{
	public const string SP_NAME = "WSP_S_CMN_FAMILY_TOURMILEAGEM";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 마스터번호
		/// </summary>
		[Description("마스터번호")]
		public int MasterNumber { get; set; }
		/// <summary>
		/// 가족일련번호
		/// </summary>
		[Description("가족일련번호")]
		public int FamilySerialNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 신청자MT번호
		/// </summary>
		[Column("신청자MT번호")]
		public string Requester_MT_Number { get; set; }
		/// <summary>
		/// 신청자이름
		/// </summary>
		[Column("신청자이름")]
		public string RequesterName { get; set; }
		/// <summary>
		/// 신청자연락처
		/// </summary>
		[Column("신청자연락처")]
		public string RequesterContact { get; set; }
		/// <summary>
		/// 신청자PTID
		/// </summary>
		[Column("신청자PTID")]
		public int Requester_PTID { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 가족MT번호
		/// </summary>
		[Column("가족MT번호")]
		public string Family_MT_Number { get; set; }
		/// <summary>
		/// 가족이름
		/// </summary>
		[Column("가족이름")]
		public string FamilyName { get; set; }
		/// <summary>
		/// 가족연락처
		/// </summary>
		[Column("가족연락처")]
		public string FamilyContace { get; set; }
		/// <summary>
		/// 가족동의여부
		/// </summary>
		[Column("가족동의여부")]
		public string FamilyAgreeOrNot { get; set; }
		/// <summary>
		/// 가족PTID
		/// </summary>
		[Column("가족PTID")]
		public int Family_PTID { get; set; }
	}
}