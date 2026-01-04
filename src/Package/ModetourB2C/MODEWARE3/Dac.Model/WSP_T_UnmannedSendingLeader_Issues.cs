namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_무인센딩인솔자_이슈사항
/// </summary>
public class WSP_T_UnmannedSendingLeader_Issues
{
	public const string SP_NAME = "WSP_T_무인센딩인솔자_이슈사항";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 이슈일련번호
		/// </summary>
		[Description("이슈일련번호")]
		public int IssueSerialNumber { get; set; }
		/// <summary>
		/// 이슈구분
		/// </summary>
		[Description("이슈구분")]
		public string IssueClassification { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Description("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Description("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 발생일
		/// </summary>
		[Description("발생일")]
		public DateTime OccurDate { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Description("등록자")]
		public int Registerer { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Description("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// T_첨부파일
		/// </summary>
		[DapperParameter(DbType.Object)]
		[Description("T_첨부파일")]
		public List<TYPE_UnmannedSendingLeader_IssueImage> T_AttachFile { get; set; }
	}

}