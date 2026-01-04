namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_무인센딩인솔자_체크리스트
/// </summary>
public class WSP_T_UnmannedSendingLeader_CheckList
{
	public const string SP_NAME = "WSP_T_무인센딩인솔자_체크리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 체크자
		/// </summary>
		[Description("체크자")]
		public int Checker { get; set; }
		/// <summary>
		/// T_집합
		/// </summary>
		[DapperParameter(DbType.Object)]
		[Description("T_집합")]
		public List<TYPE_UnmannedSendingLeader_CheckListSaving> T_Gathering { get; set; }
	}

}