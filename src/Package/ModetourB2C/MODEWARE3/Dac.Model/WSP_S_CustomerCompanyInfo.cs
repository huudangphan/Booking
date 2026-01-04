namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_거래처회사정보
/// </summary>
public class WSP_S_CustomerCompanyInfo
{
	public const string SP_NAME = "WSP_S_거래처회사정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PARTYID
		/// </summary>
		[Description("PARTYID")]
		public int PARTYID { get; set; }
		/// <summary>
		/// 사업자번호
		/// </summary>
		[Description("사업자번호")]
		public string LicenseeNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// PTID1
		/// </summary>
		[Column("PTID1")]
		public int PTID1 { get; set; }
		/// <summary>
		/// PTID2
		/// </summary>
		[Column("PTID2")]
		public int PTID2 { get; set; }
		/// <summary>
		/// 전화
		/// </summary>
		[Column("전화")]
		public string Phone { get; set; }
		/// <summary>
		/// 팩스
		/// </summary>
		[Column("팩스")]
		public string Fax { get; set; }
		/// <summary>
		/// 회사대표메일
		/// </summary>
		[Column("회사대표메일")]
		public string CompanyRepresentativeMail { get; set; }
		/// <summary>
		/// 회사명
		/// </summary>
		[Column("회사명")]
		public string CompanyName { get; set; }
		/// <summary>
		/// 대표자
		/// </summary>
		[Column("대표자")]
		public string Representative { get; set; }
		/// <summary>
		/// 담당영업지점
		/// </summary>
		[Column("담당영업지점")]
		public string ResponsibilityBusinessBranch { get; set; }
		/// <summary>
		/// 회사우편번호
		/// </summary>
		[Column("회사우편번호")]
		public string CompanyZipCode { get; set; }
		/// <summary>
		/// 회사주소1
		/// </summary>
		[Column("회사주소1")]
		public string CompanyAddress1 { get; set; }
		/// <summary>
		/// 회사주소2
		/// </summary>
		[Column("회사주소2")]
		public string CompanyAddress2 { get; set; }
		/// <summary>
		/// 사업자번호
		/// </summary>
		[Column("사업자번호")]
		public string LicenseeNumber { get; set; }
		/// <summary>
		/// 회사구분
		/// </summary>
		[Column("회사구분")]
		public string CompanyClassification { get; set; }
		/// <summary>
		/// 지점명
		/// </summary>
		[Column("지점명")]
		public string BranchName { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 별칭
		/// </summary>
		[Column("별칭")]
		public string Nickname { get; set; }
		/// <summary>
		/// Chk
		/// </summary>
		[Column("Chk")]
		public string Chk { get; set; }
	}
}