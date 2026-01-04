namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_가족합산
/// </summary>
public class USP_T_TotalFamilyCalculation
{
	public const string SP_NAME = "USP_T_가족합산";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 마스터번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("마스터번호")]
		public int MasterNumber { get; set; }
		/// <summary>
		/// 신청자
		/// </summary>
		[Description("신청자")]
		public int Requester { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Description("등록자")]
		public int Registerer { get; set; }
		/// <summary>
		/// 인증상태
		/// </summary>
		[Description("인증상태")]
		public string VerificationState { get; set; }
		/// <summary>
		/// 신청서류
		/// </summary>
		[Description("신청서류")]
		public string RequestDocument { get; set; }
		/// <summary>
		/// 신청자회원번호
		/// </summary>
		[Description("신청자회원번호")]
		public string RequesterMemberNumber { get; set; }
		/// <summary>
		/// 수정자
		/// </summary>
		[Description("수정자")]
		public int Editor { get; set; }
	}

}