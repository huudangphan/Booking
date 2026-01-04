namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_고객만족도조사_주문번호확인
/// </summary>
public class WSP_S_CustomerSatisfactionRateSurvey_OrderNumberConfirm
{
	public const string SP_NAME = "WSP_S_고객만족도조사_주문번호확인";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 생일
		/// </summary>
		[Column("생일")]
		public DateTime Birthday { get; set; }
		/// <summary>
		/// 실제생일
		/// </summary>
		[Column("실제생일")]
		public DateTime RealBirthday { get; set; }
	}
}