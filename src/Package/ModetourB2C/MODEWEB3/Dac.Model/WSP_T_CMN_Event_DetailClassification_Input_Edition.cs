namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_CMN_이벤트_세부구분_입력_수정
/// </summary>
public class WSP_T_CMN_Event_DetailClassification_Input_Edition
{
	public const string SP_NAME = "WSP_T_CMN_이벤트_세부구분_입력_수정";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 구역번호
		/// </summary>
		[Description("구역번호")]
		public int AreaNumber { get; set; }
		/// <summary>
		/// 세부구분번호
		/// </summary>
		[Description("세부구분번호")]
		public int DetailClassificationNumber { get; set; }
		/// <summary>
		/// 세부구분명
		/// </summary>
		[Description("세부구분명")]
		public string DetailClassificationName { get; set; }
		/// <summary>
		/// 설명
		/// </summary>
		[Description("설명")]
		public string Explaination { get; set; }
		/// <summary>
		/// 순서
		/// </summary>
		[Description("순서")]
		public int Order { get; set; }
		/// <summary>
		/// 사용여부
		/// </summary>
		[Description("사용여부")]
		public string UseOrNot { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Description("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 수정일
		/// </summary>
		[Description("수정일")]
		public DateTime EditionDate { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
		/// <summary>
		/// 결과2
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 20)]
		[Description("결과2")]
		public string Result2 { get; set; }
	}

}