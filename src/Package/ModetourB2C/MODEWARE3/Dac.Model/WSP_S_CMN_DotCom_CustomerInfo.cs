namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_닷컴_거래처정보
/// </summary>
public class WSP_S_CMN_DotCom_CustomerInfo
{
	public const string SP_NAME = "WSP_S_CMN_닷컴_거래처정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Description("거래처번호")]
		public int CustomerNumber { get; set; }
	}

	public class Result : IDbResult
	{
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
		/// 주소
		/// </summary>
		[Column("주소")]
		public string Address { get; set; }
		/// <summary>
		/// 거래처분류
		/// </summary>
		[Column("거래처분류")]
		public string CustomerClassification { get; set; }
		/// <summary>
		/// 거래처분류코드
		/// </summary>
		[Column("거래처분류코드")]
		public string CustomerClassificationCode { get; set; }
		/// <summary>
		/// 업종
		/// </summary>
		[Column("업종")]
		public string BusinessType { get; set; }
		/// <summary>
		/// 종목
		/// </summary>
		[Column("종목")]
		public string Event { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Column("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 사업자등록증확인
		/// </summary>
		[Column("사업자등록증확인")]
		public string BusinessLicenseConfirm { get; set; }
		/// <summary>
		/// 전화번호
		/// </summary>
		[Column("전화번호")]
		public string PhoneNumber { get; set; }
		/// <summary>
		/// 사업자번호
		/// </summary>
		[Column("사업자번호")]
		public string LicenseeNumber { get; set; }
		/// <summary>
		/// 팩스번호
		/// </summary>
		[Column("팩스번호")]
		public string FaxNumber { get; set; }
	}
}