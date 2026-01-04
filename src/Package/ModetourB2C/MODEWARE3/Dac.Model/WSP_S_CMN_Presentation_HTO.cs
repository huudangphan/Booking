namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_설명회_HTO
/// </summary>
public class WSP_S_CMN_Presentation_HTO
{
	public const string SP_NAME = "WSP_S_CMN_설명회_HTO";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 호텔번호
		/// </summary>
		[Description("호텔번호")]
		public string HotelNumber { get; set; }
		/// <summary>
		/// 관광번호
		/// </summary>
		[Description("관광번호")]
		public string SightseeingNumber { get; set; }
		/// <summary>
		/// 옵션번호
		/// </summary>
		[Description("옵션번호")]
		public string OptionNumber { get; set; }
		/// <summary>
		/// 국가번호
		/// </summary>
		[Description("국가번호")]
		public string CountryNumber { get; set; }
		/// <summary>
		/// 도시번호
		/// </summary>
		[Description("도시번호")]
		public string CityNumber { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 골프장번호
		/// </summary>
		[Description("골프장번호")]
		public string GolfCourseNumber { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 국가번호
		/// </summary>
		[Column("국가번호")]
		public int CountryNumber { get; set; }
		/// <summary>
		/// 지역1
		/// </summary>
		[Column("지역1")]
		public string Region1 { get; set; }
		/// <summary>
		/// 속성1
		/// </summary>
		[Column("속성1")]
		public string Attribute1 { get; set; }
		/// <summary>
		/// 속성2
		/// </summary>
		[Column("속성2")]
		public string Attribute2 { get; set; }
		/// <summary>
		/// 설명
		/// </summary>
		[Column("설명")]
		public string Explaination { get; set; }
		/// <summary>
		/// SORT1
		/// </summary>
		[Column("SORT1")]
		public int SORT1 { get; set; }
		/// <summary>
		/// SORT2
		/// </summary>
		[Column("SORT2")]
		public int SORT2 { get; set; }
		/// <summary>
		/// 지역영문
		/// </summary>
		[Column("지역영문")]
		public string RegionEnglish { get; set; }
		/// <summary>
		/// 상위지역번호
		/// </summary>
		[Column("상위지역번호")]
		public int HighRankRegionNumber { get; set; }
		/// <summary>
		/// 국가코드
		/// </summary>
		[Column("국가코드")]
		public string CountryCode { get; set; }
		/// <summary>
		/// 날씨지역영문
		/// </summary>
		[Column("날씨지역영문")]
		public string WeatherRegionEnglish { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// PLACEIMAGE번호
		/// </summary>
		[Column("PLACEIMAGE번호")]
		public int PLACEIMAGE_Number { get; set; }
		/// <summary>
		/// PLACEINFO번호
		/// </summary>
		[Column("PLACEINFO번호")]
		public int PLACEINFO_Number { get; set; }
		/// <summary>
		/// 파일명
		/// </summary>
		[Column("파일명")]
		public string FileName { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 국가번호
		/// </summary>
		[Column("국가번호")]
		public int CountryNumber { get; set; }
		/// <summary>
		/// 지역1
		/// </summary>
		[Column("지역1")]
		public string Region1 { get; set; }
		/// <summary>
		/// 속성1
		/// </summary>
		[Column("속성1")]
		public string Attribute1 { get; set; }
		/// <summary>
		/// 속성2
		/// </summary>
		[Column("속성2")]
		public string Attribute2 { get; set; }
		/// <summary>
		/// 설명
		/// </summary>
		[Column("설명")]
		public string Explaination { get; set; }
		/// <summary>
		/// SORT1
		/// </summary>
		[Column("SORT1")]
		public int SORT1 { get; set; }
		/// <summary>
		/// 도시번호
		/// </summary>
		[Column("도시번호")]
		public int CityNumber { get; set; }
		/// <summary>
		/// 항목번호
		/// </summary>
		[Column("항목번호")]
		public int ItemNumber { get; set; }
		/// <summary>
		/// 주상위번호
		/// </summary>
		[Column("주상위번호")]
		public int StateHighRankNumber { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// 도시번호
		/// </summary>
		[Column("도시번호")]
		public int CityNumber { get; set; }
		/// <summary>
		/// 객체명
		/// </summary>
		[Column("객체명")]
		public string ObjectName { get; set; }
		/// <summary>
		/// 객체번호
		/// </summary>
		[Column("객체번호")]
		public int ObjectNumber { get; set; }
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// 국가번호
		/// </summary>
		[Column("국가번호")]
		public int CountryNumber { get; set; }
		/// <summary>
		/// 주번호
		/// </summary>
		[Column("주번호")]
		public int StateNumber { get; set; }
		/// <summary>
		/// 지역1
		/// </summary>
		[Column("지역1")]
		public string Region1 { get; set; }
		/// <summary>
		/// 도시번호
		/// </summary>
		[Column("도시번호")]
		public int CityNumber { get; set; }
		/// <summary>
		/// 속성1
		/// </summary>
		[Column("속성1")]
		public string Attribute1 { get; set; }
		/// <summary>
		/// 속성2
		/// </summary>
		[Column("속성2")]
		public string Attribute2 { get; set; }
		/// <summary>
		/// 설명
		/// </summary>
		[Column("설명")]
		public string Explaination { get; set; }
		/// <summary>
		/// SORT1
		/// </summary>
		[Column("SORT1")]
		public int SORT1 { get; set; }
		/// <summary>
		/// SORT2
		/// </summary>
		[Column("SORT2")]
		public int SORT2 { get; set; }
		/// <summary>
		/// 지역영문
		/// </summary>
		[Column("지역영문")]
		public string RegionEnglish { get; set; }
		/// <summary>
		/// 지역2
		/// </summary>
		[Column("지역2")]
		public string Region2 { get; set; }
		/// <summary>
		/// PLACEINFO번호
		/// </summary>
		[Column("PLACEINFO번호")]
		public int PLACEINFO_Number { get; set; }
		/// <summary>
		/// 날씨지역영문
		/// </summary>
		[Column("날씨지역영문")]
		public string WeatherRegionEnglish { get; set; }
	}

	public class Result6 : IDbResult
	{
		/// <summary>
		/// PLACEIMAGE번호
		/// </summary>
		[Column("PLACEIMAGE번호")]
		public int PLACEIMAGE_Number { get; set; }
		/// <summary>
		/// PLID
		/// </summary>
		[Column("PLID")]
		public int PLID { get; set; }
		/// <summary>
		/// PLACEINFO번호
		/// </summary>
		[Column("PLACEINFO번호")]
		public int PLACEINFO_Number { get; set; }
		/// <summary>
		/// 파일명
		/// </summary>
		[Column("파일명")]
		public string FileName { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
	}

	public class Result7 : IDbResult
	{
		/// <summary>
		/// 지역1
		/// </summary>
		[Column("지역1")]
		public string Region1 { get; set; }
		/// <summary>
		/// 지역2
		/// </summary>
		[Column("지역2")]
		public string Region2 { get; set; }
		/// <summary>
		/// 지역3
		/// </summary>
		[Column("지역3")]
		public string Region3 { get; set; }
		/// <summary>
		/// 항목번호
		/// </summary>
		[Column("항목번호")]
		public int ItemNumber { get; set; }
		/// <summary>
		/// 명칭
		/// </summary>
		[Column("명칭")]
		public string Name { get; set; }
		/// <summary>
		/// 명칭1
		/// </summary>
		[Column("명칭1")]
		public string Name1 { get; set; }
		/// <summary>
		/// 속성1
		/// </summary>
		[Column("속성1")]
		public string Attribute1 { get; set; }
		/// <summary>
		/// 속성2
		/// </summary>
		[Column("속성2")]
		public string Attribute2 { get; set; }
		/// <summary>
		/// 도시번호
		/// </summary>
		[Column("도시번호")]
		public int CityNumber { get; set; }
		/// <summary>
		/// 설명
		/// </summary>
		[Column("설명")]
		public string Explaination { get; set; }
		/// <summary>
		/// SORT
		/// </summary>
		[Column("SORT")]
		public int SORT { get; set; }
		/// <summary>
		/// 속성번호
		/// </summary>
		[Column("속성번호")]
		public int AttributeNumber { get; set; }
		/// <summary>
		/// 영문지역3
		/// </summary>
		[Column("영문지역3")]
		public string EnglishRegion3 { get; set; }
		/// <summary>
		/// PLACEINFO번호
		/// </summary>
		[Column("PLACEINFO번호")]
		public int PLACEINFO_Number { get; set; }
		/// <summary>
		/// 객체타입명
		/// </summary>
		[Column("객체타입명")]
		public string ObjectTypeName { get; set; }
	}

	public class Result8 : IDbResult
	{
		/// <summary>
		/// PLACEIMAGE번호
		/// </summary>
		[Column("PLACEIMAGE번호")]
		public int PLACEIMAGE_Number { get; set; }
		/// <summary>
		/// PLACEINFO번호
		/// </summary>
		[Column("PLACEINFO번호")]
		public int PLACEINFO_Number { get; set; }
		/// <summary>
		/// 파일명
		/// </summary>
		[Column("파일명")]
		public string FileName { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 호텔번호
		/// </summary>
		[Column("호텔번호")]
		public int HotelNumber { get; set; }
		/// <summary>
		/// 항목번호
		/// </summary>
		[Column("항목번호")]
		public int ItemNumber { get; set; }
	}

	public class Result9 : IDbResult
	{
		/// <summary>
		/// 호텔명
		/// </summary>
		[Column("호텔명")]
		public string HotelName { get; set; }
		/// <summary>
		/// 객실번호
		/// </summary>
		[Column("객실번호")]
		public int GuestRoomNumber { get; set; }
		/// <summary>
		/// 객실명
		/// </summary>
		[Column("객실명")]
		public string GuestRoomName { get; set; }
		/// <summary>
		/// 상위호텔번호
		/// </summary>
		[Column("상위호텔번호")]
		public int HighRankHotelNumber { get; set; }
		/// <summary>
		/// PLACEINFO번호
		/// </summary>
		[Column("PLACEINFO번호")]
		public int PLACEINFO_Number { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
	}

	public class Result10 : IDbResult
	{
		/// <summary>
		/// 지역1
		/// </summary>
		[Column("지역1")]
		public string Region1 { get; set; }
		/// <summary>
		/// 지역2
		/// </summary>
		[Column("지역2")]
		public string Region2 { get; set; }
		/// <summary>
		/// 지역3
		/// </summary>
		[Column("지역3")]
		public string Region3 { get; set; }
		/// <summary>
		/// 항목번호
		/// </summary>
		[Column("항목번호")]
		public int ItemNumber { get; set; }
		/// <summary>
		/// 명칭
		/// </summary>
		[Column("명칭")]
		public string Name { get; set; }
		/// <summary>
		/// 속성1
		/// </summary>
		[Column("속성1")]
		public string Attribute1 { get; set; }
		/// <summary>
		/// 속성2
		/// </summary>
		[Column("속성2")]
		public string Attribute2 { get; set; }
		/// <summary>
		/// 도시번호
		/// </summary>
		[Column("도시번호")]
		public int CityNumber { get; set; }
		/// <summary>
		/// 설명
		/// </summary>
		[Column("설명")]
		public string Explaination { get; set; }
		/// <summary>
		/// SORT
		/// </summary>
		[Column("SORT")]
		public int SORT { get; set; }
		/// <summary>
		/// 영문지역3
		/// </summary>
		[Column("영문지역3")]
		public string EnglishRegion3 { get; set; }
		/// <summary>
		/// PLACEINFO번호
		/// </summary>
		[Column("PLACEINFO번호")]
		public int PLACEINFO_Number { get; set; }
		/// <summary>
		/// 속성번호
		/// </summary>
		[Column("속성번호")]
		public int AttributeNumber { get; set; }
		/// <summary>
		/// 객체타입명
		/// </summary>
		[Column("객체타입명")]
		public string ObjectTypeName { get; set; }
	}

	public class Result11 : IDbResult
	{
		/// <summary>
		/// PLACEIMAGE번호
		/// </summary>
		[Column("PLACEIMAGE번호")]
		public int PLACEIMAGE_Number { get; set; }
		/// <summary>
		/// PLACEINFO번호
		/// </summary>
		[Column("PLACEINFO번호")]
		public int PLACEINFO_Number { get; set; }
		/// <summary>
		/// 파일명
		/// </summary>
		[Column("파일명")]
		public string FileName { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 항목번호
		/// </summary>
		[Column("항목번호")]
		public int ItemNumber { get; set; }
	}

	public class Result12 : IDbResult
	{
		/// <summary>
		/// 지역1
		/// </summary>
		[Column("지역1")]
		public string Region1 { get; set; }
		/// <summary>
		/// 지역2
		/// </summary>
		[Column("지역2")]
		public string Region2 { get; set; }
		/// <summary>
		/// 지역3
		/// </summary>
		[Column("지역3")]
		public string Region3 { get; set; }
		/// <summary>
		/// 항목번호
		/// </summary>
		[Column("항목번호")]
		public int ItemNumber { get; set; }
		/// <summary>
		/// 명칭
		/// </summary>
		[Column("명칭")]
		public string Name { get; set; }
		/// <summary>
		/// 속성1
		/// </summary>
		[Column("속성1")]
		public string Attribute1 { get; set; }
		/// <summary>
		/// 속성2
		/// </summary>
		[Column("속성2")]
		public string Attribute2 { get; set; }
		/// <summary>
		/// 도시번호
		/// </summary>
		[Column("도시번호")]
		public int CityNumber { get; set; }
		/// <summary>
		/// 설명
		/// </summary>
		[Column("설명")]
		public string Explaination { get; set; }
		/// <summary>
		/// SORT
		/// </summary>
		[Column("SORT")]
		public int SORT { get; set; }
		/// <summary>
		/// PLCODE
		/// </summary>
		[Column("PLCODE")]
		public string PLCODE { get; set; }
		/// <summary>
		/// 영문지역3
		/// </summary>
		[Column("영문지역3")]
		public string EnglishRegion3 { get; set; }
		/// <summary>
		/// PLACEINFO번호
		/// </summary>
		[Column("PLACEINFO번호")]
		public int PLACEINFO_Number { get; set; }
		/// <summary>
		/// 객체타입명
		/// </summary>
		[Column("객체타입명")]
		public string ObjectTypeName { get; set; }
	}

	public class Result13 : IDbResult
	{
		/// <summary>
		/// 선택관광명
		/// </summary>
		[Column("선택관광명")]
		public string SelectSightseeingName { get; set; }
		/// <summary>
		/// 선택관광통화
		/// </summary>
		[Column("선택관광통화")]
		public string SelectSightseeingCurrency { get; set; }
		/// <summary>
		/// 선택관광비용
		/// </summary>
		[Column("선택관광비용")]
		public long SelectSightseeingExpense { get; set; }
		/// <summary>
		/// 선택관광비용_아동
		/// </summary>
		[Column("선택관광비용_아동")]
		public int SelectSightseeingExpense_Kid { get; set; }
		/// <summary>
		/// 소요시간
		/// </summary>
		[Column("소요시간")]
		public string RequiredTime { get; set; }
		/// <summary>
		/// 대기장소
		/// </summary>
		[Column("대기장소")]
		public string WaitingPlace { get; set; }
		/// <summary>
		/// 동행여부
		/// </summary>
		[Column("동행여부")]
		public string AccompanyOrNot { get; set; }
	}

	public class Result14 : IDbResult
	{
		/// <summary>
		/// 지역1
		/// </summary>
		[Column("지역1")]
		public string Region1 { get; set; }
		/// <summary>
		/// 지역2
		/// </summary>
		[Column("지역2")]
		public string Region2 { get; set; }
		/// <summary>
		/// 지역3
		/// </summary>
		[Column("지역3")]
		public string Region3 { get; set; }
		/// <summary>
		/// 항목번호
		/// </summary>
		[Column("항목번호")]
		public int ItemNumber { get; set; }
		/// <summary>
		/// 명칭
		/// </summary>
		[Column("명칭")]
		public string Name { get; set; }
		/// <summary>
		/// 명칭1
		/// </summary>
		[Column("명칭1")]
		public string Name1 { get; set; }
		/// <summary>
		/// 속성1
		/// </summary>
		[Column("속성1")]
		public string Attribute1 { get; set; }
		/// <summary>
		/// 속성2
		/// </summary>
		[Column("속성2")]
		public string Attribute2 { get; set; }
		/// <summary>
		/// 도시번호
		/// </summary>
		[Column("도시번호")]
		public int CityNumber { get; set; }
		/// <summary>
		/// 설명
		/// </summary>
		[Column("설명")]
		public string Explaination { get; set; }
		/// <summary>
		/// SORT
		/// </summary>
		[Column("SORT")]
		public int SORT { get; set; }
		/// <summary>
		/// 속성번호
		/// </summary>
		[Column("속성번호")]
		public int AttributeNumber { get; set; }
		/// <summary>
		/// 영문지역3
		/// </summary>
		[Column("영문지역3")]
		public string EnglishRegion3 { get; set; }
		/// <summary>
		/// 지역_코드1
		/// </summary>
		[Column("지역_코드1")]
		public string Region_Code1 { get; set; }
		/// <summary>
		/// 지역_코드2
		/// </summary>
		[Column("지역_코드2")]
		public string Region_Code2 { get; set; }
		/// <summary>
		/// 도시_코드
		/// </summary>
		[Column("도시_코드")]
		public string City_Code { get; set; }
		/// <summary>
		/// 객체타입명
		/// </summary>
		[Column("객체타입명")]
		public string ObjectTypeName { get; set; }
	}

	public class Result15 : IDbResult
	{
		/// <summary>
		/// PLKNAME
		/// </summary>
		[Column("PLKNAME")]
		public string PLKNAME { get; set; }
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
		/// TYPEID
		/// </summary>
		[Column("TYPEID")]
		public int TYPEID { get; set; }
		/// <summary>
		/// P_PLID
		/// </summary>
		[Column("P_PLID")]
		public int P_PLID { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
		/// <summary>
		/// SELPID
		/// </summary>
		[Column("SELPID")]
		public int SELPID { get; set; }
		/// <summary>
		/// sort
		/// </summary>
		[Column("sort")]
		public int sort { get; set; }
		/// <summary>
		/// PLENAME
		/// </summary>
		[Column("PLENAME")]
		public string PLENAME { get; set; }
	}

	public class Result16 : IDbResult
	{
		/// <summary>
		/// P_PLID
		/// </summary>
		[Column("P_PLID")]
		public int P_PLID { get; set; }
		/// <summary>
		/// SELPID
		/// </summary>
		[Column("SELPID")]
		public int SELPID { get; set; }
		/// <summary>
		/// PLACEIMAGE번호
		/// </summary>
		[Column("PLACEIMAGE번호")]
		public int PLACEIMAGE_Number { get; set; }
		/// <summary>
		/// PLACEINFO번호
		/// </summary>
		[Column("PLACEINFO번호")]
		public int PLACEINFO_Number { get; set; }
		/// <summary>
		/// 파일명
		/// </summary>
		[Column("파일명")]
		public string FileName { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
	}

	public class Result17 : IDbResult
	{
		/// <summary>
		/// 쇼핑품목
		/// </summary>
		[Column("쇼핑품목")]
		public string ShoppingProductList { get; set; }
		/// <summary>
		/// 쇼핑장소
		/// </summary>
		[Column("쇼핑장소")]
		public string ShoppingPlace { get; set; }
		/// <summary>
		/// 소요시간
		/// </summary>
		[Column("소요시간")]
		public string RequiredTime { get; set; }
		/// <summary>
		/// 환불여부
		/// </summary>
		[Column("환불여부")]
		public string RefundOrNot { get; set; }
	}

	public class Result18 : IDbResult
	{
		/// <summary>
		/// 선택관광명
		/// </summary>
		[Column("선택관광명")]
		public string SelectSightseeingName { get; set; }
		/// <summary>
		/// 선택관광통화
		/// </summary>
		[Column("선택관광통화")]
		public string SelectSightseeingCurrency { get; set; }
		/// <summary>
		/// 선택관광비용
		/// </summary>
		[Column("선택관광비용")]
		public long SelectSightseeingExpense { get; set; }
		/// <summary>
		/// 선택관광비용_아동
		/// </summary>
		[Column("선택관광비용_아동")]
		public int SelectSightseeingExpense_Kid { get; set; }
		/// <summary>
		/// 소요시간
		/// </summary>
		[Column("소요시간")]
		public string RequiredTime { get; set; }
		/// <summary>
		/// 진행최소인원
		/// </summary>
		[Column("진행최소인원")]
		public string ProgressMinimumNumberOfPeople { get; set; }
		/// <summary>
		/// 대기장소
		/// </summary>
		[Column("대기장소")]
		public string WaitingPlace { get; set; }
		/// <summary>
		/// 동행여부
		/// </summary>
		[Column("동행여부")]
		public string AccompanyOrNot { get; set; }
	}
}