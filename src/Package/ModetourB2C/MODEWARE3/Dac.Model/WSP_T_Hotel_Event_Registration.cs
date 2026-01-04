namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_호텔_이벤트_등록
/// </summary>
public class WSP_T_Hotel_Event_Registration
{
	public const string SP_NAME = "WSP_T_호텔_이벤트_등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// Idx
		/// </summary>
		[Description("Idx")]
		public int Idx { get; set; }
		/// <summary>
		/// Name
		/// </summary>
		[Description("Name")]
		public string Name { get; set; }
		/// <summary>
		/// Info
		/// </summary>
		[Description("Info")]
		public string Info { get; set; }
		/// <summary>
		/// CSS
		/// </summary>
		[Description("CSS")]
		public string CSS { get; set; }
		/// <summary>
		/// BookingStartDate
		/// </summary>
		[Description("BookingStartDate")]
		public DateTime BookingStartDate { get; set; }
		/// <summary>
		/// BookingEndDate
		/// </summary>
		[Description("BookingEndDate")]
		public DateTime BookingEndDate { get; set; }
		/// <summary>
		/// CheckInStartDate
		/// </summary>
		[Description("CheckInStartDate")]
		public DateTime CheckInStartDate { get; set; }
		/// <summary>
		/// CheckInEndDate
		/// </summary>
		[Description("CheckInEndDate")]
		public DateTime CheckInEndDate { get; set; }
		/// <summary>
		/// ScheduleDay
		/// </summary>
		[Description("ScheduleDay")]
		public byte ScheduleDay { get; set; }
		/// <summary>
		/// ViewFlag
		/// </summary>
		[Description("ViewFlag")]
		public string ViewFlag { get; set; }
		/// <summary>
		/// GDS
		/// </summary>
		[Description("GDS")]
		public string GDS { get; set; }
	}

}