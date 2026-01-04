namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_무인센딩인솔자_유저정보
/// </summary>
public class WSP_S_UnmannedSendingLeader_UserInfo
{
	public const string SP_NAME = "WSP_S_무인센딩인솔자_유저정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Column("휴대폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 보증보험시작일
		/// </summary>
		[Column("보증보험시작일")]
		public string GuaranteeInsuranceStartDate { get; set; }
		/// <summary>
		/// 보증보험만료일
		/// </summary>
		[Column("보증보험만료일")]
		public string GuaranteeInsuranceExpirationDate { get; set; }
		/// <summary>
		/// 휴가시작일
		/// </summary>
		[Column("휴가시작일")]
		public string VacationStartDate { get; set; }
		/// <summary>
		/// 휴가종료일
		/// </summary>
		[Column("휴가종료일")]
		public string VacationEndDate { get; set; }
		/// <summary>
		/// 휴가몇일간
		/// </summary>
		[Column("휴가몇일간")]
		public int SomeDaysPeriodVacation { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Column("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 이미지파일명
		/// </summary>
		[Column("이미지파일명")]
		public string ImageFileName { get; set; }
	}
}