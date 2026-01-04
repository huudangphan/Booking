namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_가족합산_MT번호체크
/// </summary>
public class USP_S_TotalFamilyCalculation_MT_NumberCheck
{
	public const string SP_NAME = "USP_S_가족합산_MT번호체크";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// MT번호
		/// </summary>
		[Description("MT번호")]
		public string MT_Number { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// MT번호
		/// </summary>
		[Column("MT번호")]
		public string MT_Number { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 이름
		/// </summary>
		[Column("이름")]
		public string Name { get; set; }
		/// <summary>
		/// 생년월일
		/// </summary>
		[Column("생년월일")]
		public string BirthYearMonthDay { get; set; }
		/// <summary>
		/// 마일리지
		/// </summary>
		[Column("마일리지")]
		public long Mileage { get; set; }
		/// <summary>
		/// 휴대폰번호
		/// </summary>
		[Column("휴대폰번호")]
		public string PhoneNumber { get; set; }
	}
}