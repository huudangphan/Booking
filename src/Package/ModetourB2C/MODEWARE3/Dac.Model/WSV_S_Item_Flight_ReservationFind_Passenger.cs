namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSV_S_아이템_항공_예약조회_탑승자
/// </summary>
public class WSV_S_Item_Flight_ReservationFind_Passenger
{
	public const string SP_NAME = "WSV_S_아이템_항공_예약조회_탑승자";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 예약자번호
		/// </summary>
		[Description("예약자번호")]
		public int BookerNumber { get; set; }
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

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Column("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 영문성
		/// </summary>
		[Column("영문성")]
		public string EnglishLastName { get; set; }
		/// <summary>
		/// 영문이름
		/// </summary>
		[Column("영문이름")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 영문성명
		/// </summary>
		[Column("영문성명")]
		public string EnglishName2 { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Column("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 생년월일
		/// </summary>
		[Column("생년월일")]
		public string BirthYearMonthDay { get; set; }
		/// <summary>
		/// 여권번호
		/// </summary>
		[Column("여권번호")]
		public string PassportNumber { get; set; }
		/// <summary>
		/// 여권만료일
		/// </summary>
		[Column("여권만료일")]
		public string PassportExpirationDate { get; set; }
		/// <summary>
		/// 여권국적코드
		/// </summary>
		[Column("여권국적코드")]
		public string PassportNationalityCode { get; set; }
		/// <summary>
		/// 여권발행국코드
		/// </summary>
		[Column("여권발행국코드")]
		public string PassportPublishCountryCode { get; set; }
		/// <summary>
		/// 고객정보수정일
		/// </summary>
		[Column("고객정보수정일")]
		public DateTime CustomerInfoEditionDate { get; set; }
		/// <summary>
		/// 고객정보수정자
		/// </summary>
		[Column("고객정보수정자")]
		public int CustomerInfoEditor { get; set; }
		/// <summary>
		/// 아피스입력여부
		/// </summary>
		[Column("아피스입력여부")]
		public string ApisInputOrNot { get; set; }
		/// <summary>
		/// PNR
		/// </summary>
		[Column("PNR")]
		public string PNR { get; set; }
		/// <summary>
		/// 현지주소
		/// </summary>
		[Column("현지주소")]
		public string LocalAddress { get; set; }
		/// <summary>
		/// 현지연락처
		/// </summary>
		[Column("현지연락처")]
		public string LocalContact { get; set; }
		/// <summary>
		/// HP
		/// </summary>
		[Column("HP")]
		public string HP { get; set; }
		/// <summary>
		/// 전화
		/// </summary>
		[Column("전화")]
		public string Phone { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 여권정보등록일
		/// </summary>
		[Column("여권정보등록일")]
		public DateTime PassportInfoRegisterDate { get; set; }
	}
}