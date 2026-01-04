namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSV_S_카드사정보
/// </summary>
public class WSV_S_CardCompanyInfo
{
	public const string SP_NAME = "WSV_S_카드사정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 카드번호
		/// </summary>
		[Description("카드번호")]
		public string CardNumber { get; set; }
		/// <summary>
		/// GDS
		/// </summary>
		[Description("GDS")]
		public string GDS { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
		/// <summary>
		/// 에러메시지
		/// </summary>
		[DapperParameter(DbType.String, ParameterDirection.InputOutput, 1000)]
		[Description("에러메시지")]
		public string ErrorMessage { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// cardNumber
		/// </summary>
		[Column("cardNumber")]
		public string cardNumber { get; set; }
		/// <summary>
		/// cardCompany
		/// </summary>
		[Column("cardCompany")]
		public string cardCompany { get; set; }
		/// <summary>
		/// companyNumber
		/// </summary>
		[Column("companyNumber")]
		public int companyNumber { get; set; }
		/// <summary>
		/// binTypeCode
		/// </summary>
		[Column("binTypeCode")]
		public string binTypeCode { get; set; }
		/// <summary>
		/// binType
		/// </summary>
		[Column("binType")]
		public string binType { get; set; }
		/// <summary>
		/// ownerTypeCode
		/// </summary>
		[Column("ownerTypeCode")]
		public string ownerTypeCode { get; set; }
		/// <summary>
		/// ownerType
		/// </summary>
		[Column("ownerType")]
		public string ownerType { get; set; }
		/// <summary>
		/// brand
		/// </summary>
		[Column("brand")]
		public string brand { get; set; }
		/// <summary>
		/// jointUse
		/// </summary>
		[Column("jointUse")]
		public string jointUse { get; set; }
		/// <summary>
		/// installment
		/// </summary>
		[Column("installment")]
		public string installment { get; set; }
		/// <summary>
		/// cardCode
		/// </summary>
		[Column("cardCode")]
		public string cardCode { get; set; }
		/// <summary>
		/// mileageCheck
		/// </summary>
		[Column("mileageCheck")]
		public string mileageCheck { get; set; }
		/// <summary>
		/// samsung2V3Check
		/// </summary>
		[Column("samsung2V3Check")]
		public string samsung2V3Check { get; set; }
		/// <summary>
		/// smileCheck
		/// </summary>
		[Column("smileCheck")]
		public string smileCheck { get; set; }
		/// <summary>
		/// amadeus
		/// </summary>
		[Column("amadeus")]
		public string amadeus { get; set; }
		/// <summary>
		/// abacus
		/// </summary>
		[Column("abacus")]
		public string abacus { get; set; }
		/// <summary>
		/// galileo
		/// </summary>
		[Column("galileo")]
		public string galileo { get; set; }
	}
}