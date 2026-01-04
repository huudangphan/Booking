namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_TP_PRODUCT_SELECT
/// </summary>
public class ACP_TP_PRODUCT_SELECT
{
	public const string SP_NAME = "ACP_TP_PRODUCT_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// MAIN_IDX
		/// </summary>
		[Description("MAIN_IDX")]
		public int MAIN_IDX { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// MAIN_IDX
		/// </summary>
		[Column("MAIN_IDX")]
		public int MAIN_IDX { get; set; }
		/// <summary>
		/// BI_IDX
		/// </summary>
		[Column("BI_IDX")]
		public int BI_IDX { get; set; }
		/// <summary>
		/// CATEGORYNAME1
		/// </summary>
		[Column("CATEGORYNAME1")]
		public string CATEGORYNAME1 { get; set; }
		/// <summary>
		/// CATEGORYNAME2
		/// </summary>
		[Column("CATEGORYNAME2")]
		public string CATEGORYNAME2 { get; set; }
		/// <summary>
		/// START_DT
		/// </summary>
		[Column("START_DT")]
		public DateTime START_DT { get; set; }
		/// <summary>
		/// END_DT
		/// </summary>
		[Column("END_DT")]
		public DateTime END_DT { get; set; }
		/// <summary>
		/// PAY_DT
		/// </summary>
		[Column("PAY_DT")]
		public DateTime PAY_DT { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// GL_목표모객
		/// </summary>
		[Column("GL_목표모객")]
		public long GL_GoalAudience { get; set; }
		/// <summary>
		/// 특선상품번호
		/// </summary>
		[Column("특선상품번호")]
		public int SpecialSelectionProductNumber { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// GL_VI
		/// </summary>
		[Column("GL_VI")]
		public double GL_VI { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// MAIN_IDX
		/// </summary>
		[Column("MAIN_IDX")]
		public int MAIN_IDX { get; set; }
		/// <summary>
		/// TYPE
		/// </summary>
		[Column("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// TITLE
		/// </summary>
		[Column("TITLE")]
		public string TITLE { get; set; }
		/// <summary>
		/// START_DT
		/// </summary>
		[Column("START_DT")]
		public DateTime START_DT { get; set; }
		/// <summary>
		/// END_DT
		/// </summary>
		[Column("END_DT")]
		public DateTime END_DT { get; set; }
		/// <summary>
		/// MOD_REGDATE
		/// </summary>
		[Column("MOD_REGDATE")]
		public DateTime MOD_REGDATE { get; set; }
		/// <summary>
		/// MOD_AUS_PTID
		/// </summary>
		[Column("MOD_AUS_PTID")]
		public int MOD_AUS_PTID { get; set; }
		/// <summary>
		/// PTKNAME
		/// </summary>
		[Column("PTKNAME")]
		public string PTKNAME { get; set; }
	}
}