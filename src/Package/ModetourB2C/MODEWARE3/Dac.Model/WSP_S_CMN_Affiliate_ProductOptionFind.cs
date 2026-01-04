namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_제휴_상품옵션조회
/// </summary>
public class WSP_S_CMN_Affiliate_ProductOptionFind
{
	public const string SP_NAME = "WSP_S_CMN_제휴_상품옵션조회";

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 이름
		/// </summary>
		[Column("이름")]
		public string Name { get; set; }
		/// <summary>
		/// 그룹명
		/// </summary>
		[Column("그룹명")]
		public string GroupName { get; set; }
		/// <summary>
		/// 기본값
		/// </summary>
		[Column("기본값")]
		public string DefaultValue { get; set; }
		/// <summary>
		/// 속성
		/// </summary>
		[Column("속성")]
		public string Attribute { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public short Sorting { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 옵션일련번호
		/// </summary>
		[Column("옵션일련번호")]
		public int OptionSerialNumber { get; set; }
		/// <summary>
		/// 설정값
		/// </summary>
		[Column("설정값")]
		public string SettingValue { get; set; }
		/// <summary>
		/// 수정여부
		/// </summary>
		[Column("수정여부")]
		public string EditionOrNot { get; set; }
		/// <summary>
		/// 사용여부
		/// </summary>
		[Column("사용여부")]
		public string UseOrNot { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
	}
}