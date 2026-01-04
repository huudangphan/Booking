namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_마일리지샵_상품조회_상세
/// </summary>
public class WSP_S_CMN_MileageShop_ProductFind_Detail
{
	public const string SP_NAME = "WSP_S_CMN_마일리지샵_상품조회_상세";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 마일리지상품no
		/// </summary>
		[Description("마일리지상품no")]
		public int MileageProduct_NO { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 마일리지상품no
		/// </summary>
		[Column("마일리지상품no")]
		public int MileageProduct_NO { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 마일리지
		/// </summary>
		[Column("마일리지")]
		public int Mileage { get; set; }
		/// <summary>
		/// 섬네일
		/// </summary>
		[Column("섬네일")]
		public string Thumbnail { get; set; }
		/// <summary>
		/// 상세이미지경로
		/// </summary>
		[Column("상세이미지경로")]
		public string DetailImageRoute { get; set; }
		/// <summary>
		/// 옵션유무
		/// </summary>
		[Column("옵션유무")]
		public string OptionOrNot { get; set; }
		/// <summary>
		/// 특별이벤트
		/// </summary>
		[Column("특별이벤트")]
		public string SpecialEvent { get; set; }
		/// <summary>
		/// 상품업체유무
		/// </summary>
		[Column("상품업체유무")]
		public string ProductCompanyOrNot { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 옵션번호
		/// </summary>
		[Column("옵션번호")]
		public int OptionNumber { get; set; }
		/// <summary>
		/// 옵션명
		/// </summary>
		[Column("옵션명")]
		public string OptionName { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 상품업체번호
		/// </summary>
		[Column("상품업체번호")]
		public int ProductCompanyNumber { get; set; }
		/// <summary>
		/// 상품업체명
		/// </summary>
		[Column("상품업체명")]
		public string ProductCompanyName { get; set; }
		/// <summary>
		/// 전화번호
		/// </summary>
		[Column("전화번호")]
		public string PhoneNumber { get; set; }
		/// <summary>
		/// 상담가능시간
		/// </summary>
		[Column("상담가능시간")]
		public string ConsultantPossibleTime { get; set; }
		/// <summary>
		/// 점심시간
		/// </summary>
		[Column("점심시간")]
		public string LunchTime { get; set; }
		/// <summary>
		/// 발주메일주소
		/// </summary>
		[Column("발주메일주소")]
		public string OrderMailAddress { get; set; }
	}
}