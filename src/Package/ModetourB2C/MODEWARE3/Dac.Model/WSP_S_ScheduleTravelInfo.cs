namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_일정여행정보
/// </summary>
public class WSP_S_ScheduleTravelInfo
{
	public const string SP_NAME = "WSP_S_일정여행정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 일정번호
		/// </summary>
		[Description("일정번호")]
		public int ScheduleNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 객체번호
		/// </summary>
		[Column("객체번호")]
		public int ObjectNumber { get; set; }
		/// <summary>
		/// PLACEINFO번호
		/// </summary>
		[Column("PLACEINFO번호")]
		public int PLACEINFO_Number { get; set; }
		/// <summary>
		/// 이미지
		/// </summary>
		[Column("이미지")]
		public string Image { get; set; }
		/// <summary>
		/// 이미지명
		/// </summary>
		[Column("이미지명")]
		public string ImageName { get; set; }
		/// <summary>
		/// 객체타입
		/// </summary>
		[Column("객체타입")]
		public string ObjectType { get; set; }
		/// <summary>
		/// 순서
		/// </summary>
		[Column("순서")]
		public int Order { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 지역1
		/// </summary>
		[Column("지역1")]
		public string Region1 { get; set; }
		/// <summary>
		/// 지역1번호
		/// </summary>
		[Column("지역1번호")]
		public int Region1Number { get; set; }
		/// <summary>
		/// 지역2
		/// </summary>
		[Column("지역2")]
		public string Region2 { get; set; }
		/// <summary>
		/// 지역2번호
		/// </summary>
		[Column("지역2번호")]
		public int Region2Number { get; set; }
		/// <summary>
		/// 지역2_영문
		/// </summary>
		[Column("지역2_영문")]
		public string Region2_English { get; set; }
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
		/// <summary>
		/// 객체명_영문
		/// </summary>
		[Column("객체명_영문")]
		public string ObjectName_English { get; set; }
		/// <summary>
		/// 객체타입
		/// </summary>
		[Column("객체타입")]
		public string ObjectType { get; set; }
		/// <summary>
		/// 단체일정일련번호
		/// </summary>
		[Column("단체일정일련번호")]
		public int GroupScheduleSerialNumber { get; set; }
		/// <summary>
		/// 호텔등급
		/// </summary>
		[Column("호텔등급")]
		public string HotelClass { get; set; }
		/// <summary>
		/// 호텔연락처
		/// </summary>
		[Column("호텔연락처")]
		public string HotelContact { get; set; }
		/// <summary>
		/// 지역2코드
		/// </summary>
		[Column("지역2코드")]
		public string Region2Code { get; set; }
		/// <summary>
		/// 좌표
		/// </summary>
		[Column("좌표")]
		public string Coordinate { get; set; }
		/// <summary>
		/// 지역0번호
		/// </summary>
		[Column("지역0번호")]
		public int Region0Number { get; set; }
		/// <summary>
		/// 일정날짜
		/// </summary>
		[Column("일정날짜")]
		public string ScheduleDate { get; set; }
		/// <summary>
		/// 지역1코드
		/// </summary>
		[Column("지역1코드")]
		public string Region1Code { get; set; }
		/// <summary>
		/// 설명
		/// </summary>
		[Column("설명")]
		public string Explaination { get; set; }
	}
}