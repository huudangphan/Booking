namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_기초코드
/// </summary>
public class USP_S_BasicCode
{
	public const string SP_NAME = "USP_S_기초코드";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 종류
		/// </summary>
		[Description("종류")]
		public string Type { get; set; }
		/// <summary>
		/// 세부종류
		/// </summary>
		[Description("세부종류")]
		public string DetailType { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 코드
		/// </summary>
		[Column("코드")]
		public string Code { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
		/// <summary>
		/// 비고
		/// </summary>
		[Column("비고")]
		public string Note { get; set; }
		/// <summary>
		/// 사용
		/// </summary>
		[Column("사용")]
		public string Use { get; set; }
		/// <summary>
		/// 상태1
		/// </summary>
		[Column("상태1")]
		public string State1 { get; set; }
		/// <summary>
		/// 상태2
		/// </summary>
		[Column("상태2")]
		public string State2 { get; set; }
		/// <summary>
		/// 상태3
		/// </summary>
		[Column("상태3")]
		public string State3 { get; set; }
		/// <summary>
		/// 상태4
		/// </summary>
		[Column("상태4")]
		public string State4 { get; set; }
		/// <summary>
		/// 상태5
		/// </summary>
		[Column("상태5")]
		public string State5 { get; set; }
		/// <summary>
		/// 종류
		/// </summary>
		[Column("종류")]
		public string Type { get; set; }
		/// <summary>
		/// 상태6
		/// </summary>
		[Column("상태6")]
		public string State6 { get; set; }
		/// <summary>
		/// 상태7
		/// </summary>
		[Column("상태7")]
		public string State7 { get; set; }
		/// <summary>
		/// 상태8
		/// </summary>
		[Column("상태8")]
		public string State8 { get; set; }
		/// <summary>
		/// 상태9
		/// </summary>
		[Column("상태9")]
		public string State9 { get; set; }
		/// <summary>
		/// 상태10
		/// </summary>
		[Column("상태10")]
		public string State10 { get; set; }
		/// <summary>
		/// 상태11
		/// </summary>
		[Column("상태11")]
		public string State11 { get; set; }
		/// <summary>
		/// 상태12
		/// </summary>
		[Column("상태12")]
		public string State12 { get; set; }
		/// <summary>
		/// 상태13
		/// </summary>
		[Column("상태13")]
		public string State13 { get; set; }
		/// <summary>
		/// 상태14
		/// </summary>
		[Column("상태14")]
		public string State14 { get; set; }
		/// <summary>
		/// 상태15
		/// </summary>
		[Column("상태15")]
		public string State15 { get; set; }
		/// <summary>
		/// 상태16
		/// </summary>
		[Column("상태16")]
		public string State16 { get; set; }
		/// <summary>
		/// 상태17
		/// </summary>
		[Column("상태17")]
		public string State17 { get; set; }
		/// <summary>
		/// 상태18
		/// </summary>
		[Column("상태18")]
		public string State18 { get; set; }
		/// <summary>
		/// 상태19
		/// </summary>
		[Column("상태19")]
		public string State19 { get; set; }
		/// <summary>
		/// 상태20
		/// </summary>
		[Column("상태20")]
		public string State20 { get; set; }
		/// <summary>
		/// 상태21
		/// </summary>
		[Column("상태21")]
		public string State21 { get; set; }
		/// <summary>
		/// 상태22
		/// </summary>
		[Column("상태22")]
		public string State22 { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public byte Sorting { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 코드
		/// </summary>
		[Column("코드")]
		public string Code { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 코드
		/// </summary>
		[Column("코드")]
		public string Code { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public int Sorting { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// 코드
		/// </summary>
		[Column("코드")]
		public string Code { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
		/// <summary>
		/// 상태6
		/// </summary>
		[Column("상태6")]
		public string State6 { get; set; }
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// 직무소분류코드
		/// </summary>
		[Column("직무소분류코드")]
		public string DutySubClassificationCode { get; set; }
		/// <summary>
		/// 직종코드
		/// </summary>
		[Column("직종코드")]
		public string JobTypeCode { get; set; }
	}

	public class Result6 : IDbResult
	{
		/// <summary>
		/// 대분류
		/// </summary>
		[Column("대분류")]
		public string MajorClassification { get; set; }
		/// <summary>
		/// 코드
		/// </summary>
		[Column("코드")]
		public string Code { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
		/// <summary>
		/// 비고
		/// </summary>
		[Column("비고")]
		public string Note { get; set; }
		/// <summary>
		/// 내용설명
		/// </summary>
		[Column("내용설명")]
		public string ContentExplaination { get; set; }
	}

	public class Result7 : IDbResult
	{
		/// <summary>
		/// 지표코드
		/// </summary>
		[Column("지표코드")]
		public string IndexCode { get; set; }
		/// <summary>
		/// 지표명
		/// </summary>
		[Column("지표명")]
		public string IndexName { get; set; }
		/// <summary>
		/// 비고
		/// </summary>
		[Column("비고")]
		public string Note { get; set; }
		/// <summary>
		/// 사용처
		/// </summary>
		[Column("사용처")]
		public string Usage { get; set; }
		/// <summary>
		/// BSC관점
		/// </summary>
		[Column("BSC관점")]
		public string BSC_Perspectives { get; set; }
		/// <summary>
		/// 지표구분
		/// </summary>
		[Column("지표구분")]
		public string IndexClassification { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
	}

	public class Result8 : IDbResult
	{
		/// <summary>
		/// 지표코드
		/// </summary>
		[Column("지표코드")]
		public string IndexCode { get; set; }
		/// <summary>
		/// 지표명
		/// </summary>
		[Column("지표명")]
		public string IndexName { get; set; }
		/// <summary>
		/// 비고
		/// </summary>
		[Column("비고")]
		public string Note { get; set; }
		/// <summary>
		/// 사용처
		/// </summary>
		[Column("사용처")]
		public string Usage { get; set; }
		/// <summary>
		/// BSC관점
		/// </summary>
		[Column("BSC관점")]
		public string BSC_Perspectives { get; set; }
		/// <summary>
		/// 지표구분
		/// </summary>
		[Column("지표구분")]
		public string IndexClassification { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 평가방법코드
		/// </summary>
		[Column("평가방법코드")]
		public string EvaluationWayCode { get; set; }
		/// <summary>
		/// 평가방법
		/// </summary>
		[Column("평가방법")]
		public string EvaluationWay { get; set; }
		/// <summary>
		/// 평가구분
		/// </summary>
		[Column("평가구분")]
		public string EvaluationClassification { get; set; }
		/// <summary>
		/// 표본단위
		/// </summary>
		[Column("표본단위")]
		public string ExampleUnit { get; set; }
		/// <summary>
		/// 평가주기
		/// </summary>
		[Column("평가주기")]
		public string EvaluationCycle { get; set; }
	}

	public class Result9 : IDbResult
	{
		/// <summary>
		/// 분류
		/// </summary>
		[Column("분류")]
		public string Classification { get; set; }
		/// <summary>
		/// 코드
		/// </summary>
		[Column("코드")]
		public string Code { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
	}

	public class Result10 : IDbResult
	{
		/// <summary>
		/// 코드
		/// </summary>
		[Column("코드")]
		public string Code { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
		/// <summary>
		/// 년월
		/// </summary>
		[Column("년월")]
		public string YearMonth { get; set; }
		/// <summary>
		/// 계수
		/// </summary>
		[Column("계수")]
		public decimal Modulus { get; set; }
	}

	public class Result11 : IDbResult
	{
		/// <summary>
		/// 선택
		/// </summary>
		[Column("선택")]
		public string Select { get; set; }
		/// <summary>
		/// 코드
		/// </summary>
		[Column("코드")]
		public string Code { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
		/// <summary>
		/// 기타의견
		/// </summary>
		[Column("기타의견")]
		public string OtherOpinion { get; set; }
	}

	public class Result12 : IDbResult
	{
		/// <summary>
		/// 선택
		/// </summary>
		[Column("선택")]
		public string Select { get; set; }
		/// <summary>
		/// 코드
		/// </summary>
		[Column("코드")]
		public string Code { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
		/// <summary>
		/// 최대점수
		/// </summary>
		[Column("최대점수")]
		public string MaximumScore { get; set; }
		/// <summary>
		/// 사유1
		/// </summary>
		[Column("사유1")]
		public string Reason1 { get; set; }
		/// <summary>
		/// 사유2
		/// </summary>
		[Column("사유2")]
		public string Reason2 { get; set; }
		/// <summary>
		/// 점수
		/// </summary>
		[Column("점수")]
		public double Score { get; set; }
	}

	public class Result13 : IDbResult
	{
		/// <summary>
		/// 코드
		/// </summary>
		[Column("코드")]
		public string Code { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
		/// <summary>
		/// 비고
		/// </summary>
		[Column("비고")]
		public string Note { get; set; }
		/// <summary>
		/// 사용
		/// </summary>
		[Column("사용")]
		public string Use { get; set; }
		/// <summary>
		/// 상태1
		/// </summary>
		[Column("상태1")]
		public string State1 { get; set; }
		/// <summary>
		/// 상태2
		/// </summary>
		[Column("상태2")]
		public string State2 { get; set; }
		/// <summary>
		/// 상태3
		/// </summary>
		[Column("상태3")]
		public string State3 { get; set; }
		/// <summary>
		/// 상태4
		/// </summary>
		[Column("상태4")]
		public string State4 { get; set; }
		/// <summary>
		/// 상태5
		/// </summary>
		[Column("상태5")]
		public string State5 { get; set; }
		/// <summary>
		/// 종류
		/// </summary>
		[Column("종류")]
		public string Type { get; set; }
		/// <summary>
		/// 상태6
		/// </summary>
		[Column("상태6")]
		public string State6 { get; set; }
		/// <summary>
		/// 상태7
		/// </summary>
		[Column("상태7")]
		public string State7 { get; set; }
		/// <summary>
		/// 상태8
		/// </summary>
		[Column("상태8")]
		public string State8 { get; set; }
		/// <summary>
		/// 상태9
		/// </summary>
		[Column("상태9")]
		public string State9 { get; set; }
		/// <summary>
		/// 상태10
		/// </summary>
		[Column("상태10")]
		public string State10 { get; set; }
		/// <summary>
		/// 상태11
		/// </summary>
		[Column("상태11")]
		public string State11 { get; set; }
		/// <summary>
		/// 상태12
		/// </summary>
		[Column("상태12")]
		public string State12 { get; set; }
		/// <summary>
		/// 상태13
		/// </summary>
		[Column("상태13")]
		public string State13 { get; set; }
		/// <summary>
		/// 상태14
		/// </summary>
		[Column("상태14")]
		public string State14 { get; set; }
		/// <summary>
		/// 상태15
		/// </summary>
		[Column("상태15")]
		public string State15 { get; set; }
		/// <summary>
		/// 상태16
		/// </summary>
		[Column("상태16")]
		public string State16 { get; set; }
		/// <summary>
		/// 상태17
		/// </summary>
		[Column("상태17")]
		public string State17 { get; set; }
		/// <summary>
		/// 상태18
		/// </summary>
		[Column("상태18")]
		public string State18 { get; set; }
		/// <summary>
		/// 상태19
		/// </summary>
		[Column("상태19")]
		public string State19 { get; set; }
		/// <summary>
		/// 상태20
		/// </summary>
		[Column("상태20")]
		public string State20 { get; set; }
		/// <summary>
		/// 상태21
		/// </summary>
		[Column("상태21")]
		public string State21 { get; set; }
		/// <summary>
		/// 상태22
		/// </summary>
		[Column("상태22")]
		public string State22 { get; set; }
		/// <summary>
		/// 코드번호
		/// </summary>
		[Column("코드번호")]
		public int CodeNumber { get; set; }
		/// <summary>
		/// CODE
		/// </summary>
		[Column("CODE")]
		public string CODE2 { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public byte Sorting { get; set; }
	}
}