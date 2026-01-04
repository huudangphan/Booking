namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_무인센딩인솔자_이슈사항_이슈일련번호
/// </summary>
public class WSP_S_UnmannedSendingLeader_Issues_IssueSerialNumber
{
	public const string SP_NAME = "WSP_S_무인센딩인솔자_이슈사항_이슈일련번호";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 이슈일련번호
		/// </summary>
		[Description("이슈일련번호")]
		public int IssueSerialNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 이슈일련번호
		/// </summary>
		[Column("이슈일련번호")]
		public int IssueSerialNumber { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 구분코드
		/// </summary>
		[Column("구분코드")]
		public string ClassificationCode { get; set; }
		/// <summary>
		/// 고객명
		/// </summary>
		[Column("고객명")]
		public string CustomerName { get; set; }
		/// <summary>
		/// 나이
		/// </summary>
		[Column("나이")]
		public int Age { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public string RegisterDate { get; set; }
		/// <summary>
		/// 발생일
		/// </summary>
		[Column("발생일")]
		public string OccurDate { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Column("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 첨부파일일련번호
		/// </summary>
		[Column("첨부파일일련번호")]
		public int AttachFileSerialNumber { get; set; }
		/// <summary>
		/// 이슈일련번호
		/// </summary>
		[Column("이슈일련번호")]
		public int IssueSerialNumber { get; set; }
		/// <summary>
		/// 첨부파일명
		/// </summary>
		[Column("첨부파일명")]
		public string AttachFileName { get; set; }
	}
}