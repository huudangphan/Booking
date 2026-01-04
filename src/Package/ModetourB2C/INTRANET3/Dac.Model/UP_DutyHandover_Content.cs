namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// UP_업무인수인계_내용
/// </summary>
public class UP_DutyHandover_Content
{
	public const string SP_NAME = "UP_업무인수인계_내용";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 부서코드
		/// </summary>
		[Column("부서코드")]
		public int DepartmentCode { get; set; }
		/// <summary>
		/// 직위코드
		/// </summary>
		[Column("직위코드")]
		public string PositionCode { get; set; }
		/// <summary>
		/// 부서구분
		/// </summary>
		[Column("부서구분")]
		public string DepartmentClassification { get; set; }
		/// <summary>
		/// 이름
		/// </summary>
		[Column("이름")]
		public string Name { get; set; }
		/// <summary>
		/// 인수자
		/// </summary>
		[Column("인수자")]
		public string Receiver { get; set; }
		/// <summary>
		/// 출장일1
		/// </summary>
		[Column("출장일1")]
		public string BusinessTripDate1 { get; set; }
		/// <summary>
		/// 출장일2
		/// </summary>
		[Column("출장일2")]
		public string BusinessTripDate2 { get; set; }
		/// <summary>
		/// 사유
		/// </summary>
		[Column("사유")]
		public string Reason { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 집전화
		/// </summary>
		[Column("집전화")]
		public string HomePhone { get; set; }
		/// <summary>
		/// 핸펀
		/// </summary>
		[Column("핸펀")]
		public string Cellphone { get; set; }
		/// <summary>
		/// 작성일
		/// </summary>
		[Column("작성일")]
		public DateTime WrittingDate { get; set; }
		/// <summary>
		/// 직위명
		/// </summary>
		[Column("직위명")]
		public string PositionName { get; set; }
		/// <summary>
		/// 부서명
		/// </summary>
		[Column("부서명")]
		public string DepartmentName { get; set; }
	}
}