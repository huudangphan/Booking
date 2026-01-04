namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_XML_현대카드예약전송
/// </summary>
public class WSP_S_XML_HyundaeCardReservationSending
{
	public const string SP_NAME = "WSP_S_XML_현대카드예약전송";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// INUM
		/// </summary>
		[Description("INUM")]
		public int INUM { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// IP
		/// </summary>
		[Description("IP")]
		public string IP { get; set; }
		/// <summary>
		/// APP
		/// </summary>
		[Description("APP")]
		public string APP { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// GDNM
		/// </summary>
		[Column("GDNM")]
		public string GDNM { get; set; }
		/// <summary>
		/// SANGPUM_NO
		/// </summary>
		[Column("SANGPUM_NO")]
		public string SANGPUM_NO { get; set; }
		/// <summary>
		/// STT_DT
		/// </summary>
		[Column("STT_DT")]
		public string STT_DT { get; set; }
		/// <summary>
		/// ED_DT
		/// </summary>
		[Column("ED_DT")]
		public string ED_DT { get; set; }
		/// <summary>
		/// ORD_DT
		/// </summary>
		[Column("ORD_DT")]
		public string ORD_DT { get; set; }
		/// <summary>
		/// ADT_A
		/// </summary>
		[Column("ADT_A")]
		public long ADT_A { get; set; }
		/// <summary>
		/// CH_A
		/// </summary>
		[Column("CH_A")]
		public long CH_A { get; set; }
		/// <summary>
		/// BB_A
		/// </summary>
		[Column("BB_A")]
		public long BB_A { get; set; }
		/// <summary>
		/// CH_A_Nobed
		/// </summary>
		[Column("CH_A_Nobed")]
		public long CH_A_Nobed { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 판매
		/// </summary>
		[Column("판매")]
		public long Sales { get; set; }
		/// <summary>
		/// 추가금액
		/// </summary>
		[Column("추가금액")]
		public long AddAmount { get; set; }
		/// <summary>
		/// 커미션
		/// </summary>
		[Column("커미션")]
		public long Commission { get; set; }
		/// <summary>
		/// 부가세
		/// </summary>
		[Column("부가세")]
		public long Surtax { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// TRAVELLER_NO
		/// </summary>
		[Column("TRAVELLER_NO")]
		public int TRAVELLER_NO { get; set; }
		/// <summary>
		/// FP_TEL
		/// </summary>
		[Column("FP_TEL")]
		public string FP_TEL { get; set; }
		/// <summary>
		/// FP_PH
		/// </summary>
		[Column("FP_PH")]
		public string FP_PH { get; set; }
		/// <summary>
		/// FP_KNM
		/// </summary>
		[Column("FP_KNM")]
		public string FP_KNM { get; set; }
		/// <summary>
		/// FP_ENM
		/// </summary>
		[Column("FP_ENM")]
		public string FP_ENM { get; set; }
		/// <summary>
		/// FP_RBRN
		/// </summary>
		[Column("FP_RBRN")]
		public string FP_RBRN { get; set; }
		/// <summary>
		/// SEX
		/// </summary>
		[Column("SEX")]
		public string SEX { get; set; }
		/// <summary>
		/// FP_PSPT_YN
		/// </summary>
		[Column("FP_PSPT_YN")]
		public string FP_PSPT_YN { get; set; }
		/// <summary>
		/// FP_PSPT_NO
		/// </summary>
		[Column("FP_PSPT_NO")]
		public string FP_PSPT_NO { get; set; }
		/// <summary>
		/// FP_PSPT_ED_DT
		/// </summary>
		[Column("FP_PSPT_ED_DT")]
		public DateTime FP_PSPT_ED_DT { get; set; }
		/// <summary>
		/// FP_VS_YN
		/// </summary>
		[Column("FP_VS_YN")]
		public string FP_VS_YN { get; set; }
		/// <summary>
		/// SBC_EMAIL
		/// </summary>
		[Column("SBC_EMAIL")]
		public string SBC_EMAIL { get; set; }
		/// <summary>
		/// FP_PRD_A
		/// </summary>
		[Column("FP_PRD_A")]
		public long FP_PRD_A { get; set; }
		/// <summary>
		/// CUSTOMER_REQUEST
		/// </summary>
		[Column("CUSTOMER_REQUEST")]
		public string CUSTOMER_REQUEST { get; set; }
		/// <summary>
		/// COMMENTS
		/// </summary>
		[Column("COMMENTS")]
		public string COMMENTS { get; set; }
		/// <summary>
		/// FP_PRD_FEE
		/// </summary>
		[Column("FP_PRD_FEE")]
		public long FP_PRD_FEE { get; set; }
		/// <summary>
		/// ACCOUNT_YN
		/// </summary>
		[Column("ACCOUNT_YN")]
		public long ACCOUNT_YN { get; set; }
		/// <summary>
		/// FP_PRD_ADD_A
		/// </summary>
		[Column("FP_PRD_ADD_A")]
		public long FP_PRD_ADD_A { get; set; }
	}
}