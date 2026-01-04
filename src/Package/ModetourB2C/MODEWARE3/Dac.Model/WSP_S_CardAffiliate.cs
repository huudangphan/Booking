namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_카드가맹점
/// </summary>
public class WSP_S_CardAffiliate
{
	public const string SP_NAME = "WSP_S_카드가맹점";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 사용여부
		/// </summary>
		[Description("사용여부")]
		public string UseOrNot { get; set; }
		/// <summary>
		/// 상점아이디
		/// </summary>
		[Description("상점아이디")]
		public string Shop_ID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 가맹점번호
		/// </summary>
		[Column("가맹점번호")]
		public string AffiliateNumber { get; set; }
		/// <summary>
		/// MID
		/// </summary>
		[Column("MID")]
		public string MID { get; set; }
		/// <summary>
		/// 카드코드
		/// </summary>
		[Column("카드코드")]
		public string CardCode { get; set; }
		/// <summary>
		/// 카드코드명
		/// </summary>
		[Column("카드코드명")]
		public string CardCodeName { get; set; }
		/// <summary>
		/// 카드거래처번호
		/// </summary>
		[Column("카드거래처번호")]
		public int CardCustomerNumber { get; set; }
		/// <summary>
		/// 카드거래처명
		/// </summary>
		[Column("카드거래처명")]
		public int CardCustomerName { get; set; }
		/// <summary>
		/// 은행거래처번호
		/// </summary>
		[Column("은행거래처번호")]
		public int BankCustomerNumber { get; set; }
		/// <summary>
		/// 은행거래처명
		/// </summary>
		[Column("은행거래처명")]
		public int BankCustomerName { get; set; }
		/// <summary>
		/// 전표번호
		/// </summary>
		[Column("전표번호")]
		public int StatementNumber { get; set; }
		/// <summary>
		/// 수수료
		/// </summary>
		[Column("수수료")]
		public double Fee { get; set; }
		/// <summary>
		/// 사용여부
		/// </summary>
		[Column("사용여부")]
		public string UseOrNot { get; set; }
		/// <summary>
		/// 모두투어_담당부서
		/// </summary>
		[Column("모두투어_담당부서")]
		public string MODETOUR_ResponsibilityDepartment { get; set; }
		/// <summary>
		/// 모두투어_담당자번호
		/// </summary>
		[Column("모두투어_담당자번호")]
		public int MODETOUR_ManagerNumber { get; set; }
		/// <summary>
		/// 모두투어_담당자명
		/// </summary>
		[Column("모두투어_담당자명")]
		public int MODETOUR_ManagerName { get; set; }
		/// <summary>
		/// PG사명
		/// </summary>
		[Column("PG사명")]
		public string PG_CompanyName { get; set; }
		/// <summary>
		/// PG사_담당자정보
		/// </summary>
		[Column("PG사_담당자정보")]
		public string PG_Company_ManagerInfo { get; set; }
		/// <summary>
		/// 카드사_담당자정보
		/// </summary>
		[Column("카드사_담당자정보")]
		public string CardCompany_ManagerInfo { get; set; }
		/// <summary>
		/// 비고
		/// </summary>
		[Column("비고")]
		public string Note { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public string RegisterDate { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Column("등록자")]
		public string Registerer { get; set; }
		/// <summary>
		/// 수정일
		/// </summary>
		[Column("수정일")]
		public string EditionDate { get; set; }
		/// <summary>
		/// 수정자
		/// </summary>
		[Column("수정자")]
		public string Editor { get; set; }
		/// <summary>
		/// 선택
		/// </summary>
		[Column("선택")]
		public string Select { get; set; }
		/// <summary>
		/// 입금적요
		/// </summary>
		[Column("입금적요")]
		public string DepositBrief { get; set; }
	}
}