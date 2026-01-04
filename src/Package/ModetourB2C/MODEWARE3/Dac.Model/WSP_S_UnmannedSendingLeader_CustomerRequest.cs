namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_무인센딩인솔자_고객요청사항
/// </summary>
public class WSP_S_UnmannedSendingLeader_CustomerRequest
{
	public const string SP_NAME = "WSP_S_무인센딩인솔자_고객요청사항";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 성인
		/// </summary>
		[Column("성인")]
		public int Adult { get; set; }
		/// <summary>
		/// 아동
		/// </summary>
		[Column("아동")]
		public int Children { get; set; }
		/// <summary>
		/// 유아
		/// </summary>
		[Column("유아")]
		public int Toddler { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Column("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 예약번호
		/// </summary>
		[Column("예약번호")]
		public int BookingNumber { get; set; }
		/// <summary>
		/// 대표
		/// </summary>
		[Column("대표")]
		public string Representative { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Column("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 나이
		/// </summary>
		[Column("나이")]
		public int Age { get; set; }
		/// <summary>
		/// 방번호
		/// </summary>
		[Column("방번호")]
		public int RoomNumber { get; set; }
		/// <summary>
		/// 랜드
		/// </summary>
		[Column("랜드")]
		public string Land { get; set; }
		/// <summary>
		/// DEC_HP
		/// </summary>
		[Column("DEC_HP")]
		public string DEC_HP { get; set; }
		/// <summary>
		/// 고객요청사항
		/// </summary>
		[Column("고객요청사항")]
		public string CustomerRequest { get; set; }
		/// <summary>
		/// 판매비고
		/// </summary>
		[Column("판매비고")]
		public string SalesNote { get; set; }
		/// <summary>
		/// 영문이름2
		/// </summary>
		[Column("영문이름2")]
		public string EnglishName2 { get; set; }
		/// <summary>
		/// 성별코드
		/// </summary>
		[Column("성별코드")]
		public string GenderCode { get; set; }
		/// <summary>
		/// 예약운영
		/// </summary>
		[Column("예약운영")]
		public string ReservationOperation { get; set; }
		/// <summary>
		/// 예약운영전화번호
		/// </summary>
		[Column("예약운영전화번호")]
		public string ReservationOperationPhoneCallNumber { get; set; }
		/// <summary>
		/// 예약운영휴대폰번호
		/// </summary>
		[Column("예약운영휴대폰번호")]
		public string ReservationOperationPhoneNumberNumber { get; set; }
		/// <summary>
		/// 영업OP직원명
		/// </summary>
		[Column("영업OP직원명")]
		public string BusinessOPEmployeeName { get; set; }
		/// <summary>
		/// 영업OP직원휴대폰
		/// </summary>
		[Column("영업OP직원휴대폰")]
		public string BusinessOPEmployeePhoneNumber { get; set; }
		/// <summary>
		/// 샌딩경로
		/// </summary>
		[Column("샌딩경로")]
		public string SendingPath { get; set; }
		/// <summary>
		/// 아이콘비활성화
		/// </summary>
		[Column("아이콘비활성화")]
		public string IconFeeActivate { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 센딩자
		/// </summary>
		[Column("센딩자")]
		public string Sender { get; set; }
		/// <summary>
		/// 센딩자전화번호
		/// </summary>
		[Column("센딩자전화번호")]
		public string SenderPhoneCallNumber { get; set; }
	}
}