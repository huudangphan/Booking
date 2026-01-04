namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_우리모두_인원정보
/// </summary>
public class WSP_S_CMN_WooriMODE_NumberOfPeopleInfo
{
	public const string SP_NAME = "WSP_S_CMN_우리모두_인원정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 순서
		/// </summary>
		[Column("순서")]
		public int Order { get; set; }
		/// <summary>
		/// 인원시작
		/// </summary>
		[Column("인원시작")]
		public int NumberOfPeopleStart { get; set; }
		/// <summary>
		/// 인원종료
		/// </summary>
		[Column("인원종료")]
		public int NumberOfPeopleEnd { get; set; }
		/// <summary>
		/// 인원
		/// </summary>
		[Column("인원")]
		public string NumberOfPeople { get; set; }
		/// <summary>
		/// 어른요금
		/// </summary>
		[Column("어른요금")]
		public long AdultFare { get; set; }
		/// <summary>
		/// 소아요금
		/// </summary>
		[Column("소아요금")]
		public long KidFare { get; set; }
		/// <summary>
		/// 유아요금
		/// </summary>
		[Column("유아요금")]
		public long ToddlerFare { get; set; }
		/// <summary>
		/// 어른인상액
		/// </summary>
		[Column("어른인상액")]
		public long Adult인상Amount { get; set; }
		/// <summary>
		/// 소아요금_E
		/// </summary>
		[Column("소아요금_E")]
		public long KidFare_E { get; set; }
	}
}