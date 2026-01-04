namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_통합이벤트_메모_관리자리스트
/// </summary>
public class WSP_S_CMN_IntegratedEvent_Memo_AdminList
{
	public const string SP_NAME = "WSP_S_CMN_통합이벤트_메모_관리자리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 이벤트번호
		/// </summary>
		[Description("이벤트번호")]
		public int EventNumber { get; set; }
		/// <summary>
		/// 당첨여부
		/// </summary>
		[Description("당첨여부")]
		public string WinnerOrNot { get; set; }
		/// <summary>
		/// 검색필드
		/// </summary>
		[Description("검색필드")]
		public string SearchingField { get; set; }
		/// <summary>
		/// 검색어
		/// </summary>
		[Description("검색어")]
		public string SearchingKeyword { get; set; }
		/// <summary>
		/// 등록일1
		/// </summary>
		[Description("등록일1")]
		public DateTime RegisterDate1 { get; set; }
		/// <summary>
		/// 등록일2
		/// </summary>
		[Description("등록일2")]
		public DateTime RegisterDate2 { get; set; }
		/// <summary>
		/// 현재페이지
		/// </summary>
		[Description("현재페이지")]
		public int CurrentPage { get; set; }
		/// <summary>
		/// 페이지당글개수
		/// </summary>
		[Description("페이지당글개수")]
		public int EachPageCharactersNumber { get; set; }
		/// <summary>
		/// 전체게시글수
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("전체게시글수")]
		public int EntirePostCharactersNumber { get; set; }
		/// <summary>
		/// 전체페이지수
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("전체페이지수")]
		public int EntirePageNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 구역번호
		/// </summary>
		[Column("구역번호")]
		public int AreaNumber { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 설명
		/// </summary>
		[Column("설명")]
		public string Explaination { get; set; }
		/// <summary>
		/// 대표이미지
		/// </summary>
		[Column("대표이미지")]
		public string RepresentativeImage { get; set; }
		/// <summary>
		/// 대표이미지2
		/// </summary>
		[Column("대표이미지2")]
		public string RepresentativeImage2 { get; set; }
		/// <summary>
		/// 이벤트경로
		/// </summary>
		[Column("이벤트경로")]
		public string EventRoute { get; set; }
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
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 추천수
		/// </summary>
		[Column("추천수")]
		public int RecommendNumber { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public int Sorting { get; set; }
		/// <summary>
		/// 사용여부
		/// </summary>
		[Column("사용여부")]
		public string UseOrNot { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 시작일
		/// </summary>
		[Column("시작일")]
		public DateTime StartDate { get; set; }
		/// <summary>
		/// 종료일
		/// </summary>
		[Column("종료일")]
		public DateTime EndDate { get; set; }
		/// <summary>
		/// 당첨등록시작일
		/// </summary>
		[Column("당첨등록시작일")]
		public DateTime WinnerRegisterStartDate { get; set; }
		/// <summary>
		/// 당첨등록종료일
		/// </summary>
		[Column("당첨등록종료일")]
		public DateTime WinnerRegisterEndDate { get; set; }
		/// <summary>
		/// 담당부서
		/// </summary>
		[Column("담당부서")]
		public int ResponsibilityDepartment { get; set; }
		/// <summary>
		/// 유투브영상경로
		/// </summary>
		[Column("유투브영상경로")]
		public string YoutubeVideoRoute { get; set; }
		/// <summary>
		/// 공지
		/// </summary>
		[Column("공지")]
		public string Notification { get; set; }
		/// <summary>
		/// 이미지쿠폰사용여부
		/// </summary>
		[Column("이미지쿠폰사용여부")]
		public string ImageCouponUseOrNot { get; set; }
		/// <summary>
		/// 모바일노출여부
		/// </summary>
		[Column("모바일노출여부")]
		public string MobileDisplayOrNot { get; set; }
		/// <summary>
		/// 모바일쿠폰이미지경로
		/// </summary>
		[Column("모바일쿠폰이미지경로")]
		public string MobileCouponImageRoute { get; set; }
		/// <summary>
		/// 세부구분번호
		/// </summary>
		[Column("세부구분번호")]
		public int DetailClassificationNumber { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Column("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 회원명
		/// </summary>
		[Column("회원명")]
		public string MemberName { get; set; }
		/// <summary>
		/// 회원주민번호
		/// </summary>
		[Column("회원주민번호")]
		public string MemberResidenceRegistrationNumber { get; set; }
		/// <summary>
		/// 사원번호
		/// </summary>
		[Column("사원번호")]
		public int StaffNumber { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Column("휴대폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 집전화
		/// </summary>
		[Column("집전화")]
		public string HomePhone { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 주소
		/// </summary>
		[Column("주소")]
		public string Address { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
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
		/// 번호1
		/// </summary>
		[Column("번호1")]
		public int Number1 { get; set; }
		/// <summary>
		/// 번호2
		/// </summary>
		[Column("번호2")]
		public int Number2 { get; set; }
		/// <summary>
		/// 번호3
		/// </summary>
		[Column("번호3")]
		public int Number3 { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 당첨여부
		/// </summary>
		[Column("당첨여부")]
		public string WinnerOrNot { get; set; }
		/// <summary>
		/// 당첨연락처
		/// </summary>
		[Column("당첨연락처")]
		public string WinnerContact { get; set; }
		/// <summary>
		/// 당첨주소
		/// </summary>
		[Column("당첨주소")]
		public string PrizeWinAddress { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 주문일
		/// </summary>
		[Column("주문일")]
		public string OrderDate { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Column("판매명세번호")]
		public string SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// CHK_주민번호
		/// </summary>
		[Column("CHK_주민번호")]
		public string CHK_CitizenIDNumber { get; set; }
		/// <summary>
		/// 외몇명
		/// </summary>
		[Column("외몇명")]
		public int Others { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 당첨여부
		/// </summary>
		[Column("당첨여부")]
		public string WinnerOrNot { get; set; }
		/// <summary>
		/// 당첨연락처
		/// </summary>
		[Column("당첨연락처")]
		public string WinnerContact { get; set; }
		/// <summary>
		/// 당첨주소
		/// </summary>
		[Column("당첨주소")]
		public string PrizeWinAddress { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 응모내용
		/// </summary>
		[Column("응모내용")]
		public string EnteringContent { get; set; }
		/// <summary>
		/// 응모기간
		/// </summary>
		[Column("응모기간")]
		public int EnteringPeriod { get; set; }
		/// <summary>
		/// 응모여부
		/// </summary>
		[Column("응모여부")]
		public int EnteringOrNot { get; set; }
		/// <summary>
		/// 당첨여부
		/// </summary>
		[Column("당첨여부")]
		public string WinnerOrNot { get; set; }
		/// <summary>
		/// 참여자
		/// </summary>
		[Column("참여자")]
		public string Participant { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Column("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 회원번호
		/// </summary>
		[Column("회원번호")]
		public int MemberNumber { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// 아이디
		/// </summary>
		[Column("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 회원번호
		/// </summary>
		[Column("회원번호")]
		public int MemberNumber { get; set; }
		/// <summary>
		/// 생년월일
		/// </summary>
		[Column("생년월일")]
		public string BirthYearMonthDay { get; set; }
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public string Column1 { get; set; }
	}

	public class Result6 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Column("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 회원명
		/// </summary>
		[Column("회원명")]
		public string MemberName { get; set; }
		/// <summary>
		/// 회원주민번호
		/// </summary>
		[Column("회원주민번호")]
		public string MemberResidenceRegistrationNumber { get; set; }
		/// <summary>
		/// 사원번호
		/// </summary>
		[Column("사원번호")]
		public int StaffNumber { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Column("휴대폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 집전화
		/// </summary>
		[Column("집전화")]
		public string HomePhone { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 주소
		/// </summary>
		[Column("주소")]
		public string Address { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
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
		/// 번호1
		/// </summary>
		[Column("번호1")]
		public int Number1 { get; set; }
		/// <summary>
		/// 번호2
		/// </summary>
		[Column("번호2")]
		public int Number2 { get; set; }
		/// <summary>
		/// 번호3
		/// </summary>
		[Column("번호3")]
		public int Number3 { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 당첨여부
		/// </summary>
		[Column("당첨여부")]
		public string WinnerOrNot { get; set; }
		/// <summary>
		/// 당첨연락처
		/// </summary>
		[Column("당첨연락처")]
		public string WinnerContact { get; set; }
		/// <summary>
		/// 당첨주소
		/// </summary>
		[Column("당첨주소")]
		public string PrizeWinAddress { get; set; }
		/// <summary>
		/// MT_NO
		/// </summary>
		[Column("MT_NO")]
		public string MT_NO { get; set; }
	}
}