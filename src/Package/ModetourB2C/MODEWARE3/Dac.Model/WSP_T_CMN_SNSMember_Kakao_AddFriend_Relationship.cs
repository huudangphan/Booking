namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_SNS회원_카카오_플러스친구_관계
/// </summary>
public class WSP_T_CMN_SNSMember_Kakao_AddFriend_Relationship
{
	public const string SP_NAME = "WSP_T_CMN_SNS회원_카카오_플러스친구_관계";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// user_id
		/// </summary>
		[Description("user_id")]
		public string user_id { get; set; }
		/// <summary>
		/// plus_friend_public_id
		/// </summary>
		[Description("plus_friend_public_id")]
		public string plus_friend_public_id { get; set; }
		/// <summary>
		/// plus_friend_uuid
		/// </summary>
		[Description("plus_friend_uuid")]
		public string plus_friend_uuid { get; set; }
		/// <summary>
		/// relation
		/// </summary>
		[Description("relation")]
		public string relation { get; set; }
		/// <summary>
		/// updated_at
		/// </summary>
		[Description("updated_at")]
		public DateTime updated_at { get; set; }
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

}