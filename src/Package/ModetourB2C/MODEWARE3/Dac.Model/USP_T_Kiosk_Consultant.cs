namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_키오스크_상담
/// </summary>
public class USP_T_Kiosk_Consultant
{
	public const string SP_NAME = "USP_T_키오스크_상담";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 상담신청번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("상담신청번호")]
		public int ConsultantRequestNumber { get; set; }
		/// <summary>
		/// 상담신청일
		/// </summary>
		[Description("상담신청일")]
		public DateTime ConsultantRequestDate { get; set; }
		/// <summary>
		/// 기기번호
		/// </summary>
		[Description("기기번호")]
		public int EquipmentNumber { get; set; }
		/// <summary>
		/// 상담가능시작일
		/// </summary>
		[Description("상담가능시작일")]
		public DateTime ConsultantPossibleStartDate { get; set; }
		/// <summary>
		/// 상담가능종료일
		/// </summary>
		[Description("상담가능종료일")]
		public DateTime ConsultantPossibleEndDate { get; set; }
		/// <summary>
		/// 상담상태
		/// </summary>
		[Description("상담상태")]
		public string ConsultantState { get; set; }
		/// <summary>
		/// 연락처
		/// </summary>
		[Description("연락처")]
		public string Contact { get; set; }
		/// <summary>
		/// 특선상품번호
		/// </summary>
		[Description("특선상품번호")]
		public int SpecialSelectionProductNumber { get; set; }
		/// <summary>
		/// 상담직원번호
		/// </summary>
		[Description("상담직원번호")]
		public int ConsultantEmployeeNumber { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 비고
		/// </summary>
		[Description("비고")]
		public string Note { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Description("등록자")]
		public int Registerer { get; set; }
	}

}