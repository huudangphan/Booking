namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_TM_STORYM_TOURIST_LIST
/// </summary>
public class WSP_S_CMN_TM_STORYM_TOURIST_LIST
{
	public const string SP_NAME = "WSP_S_CMN_TM_STORYM_TOURIST_LIST";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// AreaCode
		/// </summary>
		[Description("AreaCode")]
		public string AreaCode { get; set; }
		/// <summary>
		/// TouristCode
		/// </summary>
		[Description("TouristCode")]
		public string TouristCode { get; set; }
		/// <summary>
		/// Name
		/// </summary>
		[Description("Name")]
		public string Name { get; set; }
		/// <summary>
		/// UseFlag
		/// </summary>
		[Description("UseFlag")]
		public string UseFlag { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// Idx
		/// </summary>
		[Column("Idx")]
		public int Idx { get; set; }
		/// <summary>
		/// AreaCode
		/// </summary>
		[Column("AreaCode")]
		public string AreaCode { get; set; }
		/// <summary>
		/// TouristCode
		/// </summary>
		[Column("TouristCode")]
		public string TouristCode { get; set; }
		/// <summary>
		/// Name
		/// </summary>
		[Column("Name")]
		public string Name { get; set; }
		/// <summary>
		/// UseFlag
		/// </summary>
		[Column("UseFlag")]
		public string UseFlag { get; set; }
		/// <summary>
		/// Order
		/// </summary>
		[Column("Order")]
		public long Order { get; set; }
		/// <summary>
		/// KorName
		/// </summary>
		[Column("KorName")]
		public string KorName { get; set; }
		/// <summary>
		/// Img1
		/// </summary>
		[Column("Img1")]
		public string Img1 { get; set; }
	}
}