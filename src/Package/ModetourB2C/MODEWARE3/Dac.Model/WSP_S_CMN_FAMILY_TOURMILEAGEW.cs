namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_FAMILY_TOURMILEAGEW
/// </summary>
public class WSP_S_CMN_FAMILY_TOURMILEAGEW
{
	public const string SP_NAME = "WSP_S_CMN_FAMILY_TOURMILEAGEW";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 가족회원번호
		/// </summary>
		[Description("가족회원번호")]
		public string FamilyMemberNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 마스터번호
		/// </summary>
		[Column("마스터번호")]
		public int MasterNumber { get; set; }
		/// <summary>
		/// 가족일련번호
		/// </summary>
		[Column("가족일련번호")]
		public int FamilySerialNumber { get; set; }
		/// <summary>
		/// 가족회원번호
		/// </summary>
		[Column("가족회원번호")]
		public string FamilyMemberNumber { get; set; }
		/// <summary>
		/// 가족회원이름
		/// </summary>
		[Column("가족회원이름")]
		public string FamilyMemberName { get; set; }
		/// <summary>
		/// 신청자회원번호
		/// </summary>
		[Column("신청자회원번호")]
		public string RequesterMemberNumber { get; set; }
		/// <summary>
		/// 신청자이름
		/// </summary>
		[Column("신청자이름")]
		public string RequesterName { get; set; }
		/// <summary>
		/// 관계
		/// </summary>
		[Column("관계")]
		public string Relationship { get; set; }
		/// <summary>
		/// 신청구분
		/// </summary>
		[Column("신청구분")]
		public string RequestClassification { get; set; }
		/// <summary>
		/// 인증상태
		/// </summary>
		[Column("인증상태")]
		public string VerificationState { get; set; }
		/// <summary>
		/// 가족동의
		/// </summary>
		[Column("가족동의")]
		public string FamilyAgree { get; set; }
		/// <summary>
		/// 가족동의일
		/// </summary>
		[Column("가족동의일")]
		public DateTime FamilyAgreeDate { get; set; }
		/// <summary>
		/// 신청일
		/// </summary>
		[Column("신청일")]
		public DateTime RequestDate { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 신청서류
		/// </summary>
		[Column("신청서류")]
		public string RequestDocument { get; set; }
		/// <summary>
		/// 해지작업일
		/// </summary>
		[Column("해지작업일")]
		public DateTime CancelWorkingDate { get; set; }
	}
}