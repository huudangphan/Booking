namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_상품등급제1
/// </summary>
public class WSP_S_ProductClassSystem1
{
	public const string SP_NAME = "WSP_S_상품등급제1";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 등급구분
		/// </summary>
		[Description("등급구분")]
		public string ClassClassification { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 지역명
		/// </summary>
		[Column("지역명")]
		public string RegionName { get; set; }
		/// <summary>
		/// 등급
		/// </summary>
		[Column("등급")]
		public string Class { get; set; }
		/// <summary>
		/// 항공
		/// </summary>
		[Column("항공")]
		public string Flight { get; set; }
		/// <summary>
		/// 호텔
		/// </summary>
		[Column("호텔")]
		public string Hotel { get; set; }
		/// <summary>
		/// 행사인원
		/// </summary>
		[Column("행사인원")]
		public string EventNumberOfPeople { get; set; }
		/// <summary>
		/// 차량
		/// </summary>
		[Column("차량")]
		public string Car { get; set; }
		/// <summary>
		/// 식사
		/// </summary>
		[Column("식사")]
		public string Meal { get; set; }
		/// <summary>
		/// 가이드
		/// </summary>
		[Column("가이드")]
		public string Guide { get; set; }
		/// <summary>
		/// 인솔자
		/// </summary>
		[Column("인솔자")]
		public string Leader { get; set; }
		/// <summary>
		/// 쇼핑
		/// </summary>
		[Column("쇼핑")]
		public string Shopping { get; set; }
		/// <summary>
		/// 선택관광
		/// </summary>
		[Column("선택관광")]
		public string SelectSightseeing { get; set; }
		/// <summary>
		/// 팁
		/// </summary>
		[Column("팁")]
		public string Tip { get; set; }
		/// <summary>
		/// 일정조건
		/// </summary>
		[Column("일정조건")]
		public string ScheduleCondition { get; set; }
		/// <summary>
		/// 골프장
		/// </summary>
		[Column("골프장")]
		public string GolfCourse { get; set; }
		/// <summary>
		/// 기타
		/// </summary>
		[Column("기타")]
		public string Other { get; set; }
	}
}