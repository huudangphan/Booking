namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_웹사이트정보
/// </summary>
public class WSP_S_WebsiteInfo
{
	public const string SP_NAME = "WSP_S_웹사이트정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 아이디
		/// </summary>
		[Description("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 웹사이트번호
		/// </summary>
		[Description("웹사이트번호")]
		public int WebSiteNumber { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// PTID1
		/// </summary>
		[Column("PTID1")]
		public int PTID1 { get; set; }
		/// <summary>
		/// PTID2
		/// </summary>
		[Column("PTID2")]
		public int PTID2 { get; set; }
		/// <summary>
		/// 관계종류
		/// </summary>
		[Column("관계종류")]
		public string RelationshipType { get; set; }
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
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
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
		/// 상태23
		/// </summary>
		[Column("상태23")]
		public string State23 { get; set; }
		/// <summary>
		/// 상태24
		/// </summary>
		[Column("상태24")]
		public string State24 { get; set; }
		/// <summary>
		/// 상태25
		/// </summary>
		[Column("상태25")]
		public string State25 { get; set; }
		/// <summary>
		/// 상태26
		/// </summary>
		[Column("상태26")]
		public string State26 { get; set; }
		/// <summary>
		/// 상태27
		/// </summary>
		[Column("상태27")]
		public string State27 { get; set; }
		/// <summary>
		/// 상태28
		/// </summary>
		[Column("상태28")]
		public string State28 { get; set; }
		/// <summary>
		/// 상태29
		/// </summary>
		[Column("상태29")]
		public string State29 { get; set; }
		/// <summary>
		/// 상태30
		/// </summary>
		[Column("상태30")]
		public string State30 { get; set; }
		/// <summary>
		/// 상태31
		/// </summary>
		[Column("상태31")]
		public string State31 { get; set; }
		/// <summary>
		/// 상태32
		/// </summary>
		[Column("상태32")]
		public string State32 { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 웹사이트번호
		/// </summary>
		[Column("웹사이트번호")]
		public int WebSiteNumber { get; set; }
		/// <summary>
		/// 웹사이트
		/// </summary>
		[Column("웹사이트")]
		public string WebSite { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 전시방식코드
		/// </summary>
		[Column("전시방식코드")]
		public string ShowingMethodCode { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 웹사이트번호1
		/// </summary>
		[Column("웹사이트번호1")]
		public int WebSiteNumber1 { get; set; }
		/// <summary>
		/// 웹페이지번호
		/// </summary>
		[Column("웹페이지번호")]
		public int WebPageNumber { get; set; }
		/// <summary>
		/// 담당자
		/// </summary>
		[Column("담당자")]
		public int Manager { get; set; }
		/// <summary>
		/// 비고1
		/// </summary>
		[Column("비고1")]
		public string Note1 { get; set; }
		/// <summary>
		/// 비고2
		/// </summary>
		[Column("비고2")]
		public string Note2 { get; set; }
		/// <summary>
		/// 웹사이트종류코드
		/// </summary>
		[Column("웹사이트종류코드")]
		public string WebSiteTypeCode { get; set; }
		/// <summary>
		/// 시작경로
		/// </summary>
		[Column("시작경로")]
		public string StartRoute { get; set; }
		/// <summary>
		/// 파일타입
		/// </summary>
		[Column("파일타입")]
		public string FileType { get; set; }
		/// <summary>
		/// 사용여부
		/// </summary>
		[Column("사용여부")]
		public string UseOrNot { get; set; }
		/// <summary>
		/// 등록일1
		/// </summary>
		[Column("등록일1")]
		public DateTime RegisterDate1 { get; set; }
		/// <summary>
		/// 수정일
		/// </summary>
		[Column("수정일")]
		public DateTime EditionDate { get; set; }
		/// <summary>
		/// 도메인업체
		/// </summary>
		[Column("도메인업체")]
		public string DomainCompany { get; set; }
		/// <summary>
		/// 업체정보1
		/// </summary>
		[Column("업체정보1")]
		public string CompanyInfo1 { get; set; }
		/// <summary>
		/// 업체정보2
		/// </summary>
		[Column("업체정보2")]
		public string CompanyInfo2 { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// PTID1
		/// </summary>
		[Column("PTID1")]
		public int PTID1 { get; set; }
		/// <summary>
		/// PTID2
		/// </summary>
		[Column("PTID2")]
		public int PTID2 { get; set; }
		/// <summary>
		/// 관계종류
		/// </summary>
		[Column("관계종류")]
		public string RelationshipType { get; set; }
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
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
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
		/// 상태23
		/// </summary>
		[Column("상태23")]
		public string State23 { get; set; }
		/// <summary>
		/// 상태24
		/// </summary>
		[Column("상태24")]
		public string State24 { get; set; }
		/// <summary>
		/// 상태25
		/// </summary>
		[Column("상태25")]
		public string State25 { get; set; }
		/// <summary>
		/// 상태26
		/// </summary>
		[Column("상태26")]
		public string State26 { get; set; }
		/// <summary>
		/// 상태27
		/// </summary>
		[Column("상태27")]
		public string State27 { get; set; }
		/// <summary>
		/// 상태28
		/// </summary>
		[Column("상태28")]
		public string State28 { get; set; }
		/// <summary>
		/// 상태29
		/// </summary>
		[Column("상태29")]
		public string State29 { get; set; }
		/// <summary>
		/// 상태30
		/// </summary>
		[Column("상태30")]
		public string State30 { get; set; }
		/// <summary>
		/// 상태31
		/// </summary>
		[Column("상태31")]
		public string State31 { get; set; }
		/// <summary>
		/// 상태32
		/// </summary>
		[Column("상태32")]
		public string State32 { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// PTCODE
		/// </summary>
		[Column("PTCODE")]
		public string PTCODE { get; set; }
		/// <summary>
		/// PTKNAME
		/// </summary>
		[Column("PTKNAME")]
		public string PTKNAME { get; set; }
		/// <summary>
		/// PTENAME
		/// </summary>
		[Column("PTENAME")]
		public string PTENAME { get; set; }
		/// <summary>
		/// ID_NO
		/// </summary>
		[Column("ID_NO")]
		public string ID_NO { get; set; }
		/// <summary>
		/// X아이디
		/// </summary>
		[Column("X아이디")]
		public string X_ID { get; set; }
		/// <summary>
		/// 종류
		/// </summary>
		[Column("종류")]
		public string Type { get; set; }
		/// <summary>
		/// 대표계좌번호
		/// </summary>
		[Column("대표계좌번호")]
		public int RepresentativeAccountNumber { get; set; }
		/// <summary>
		/// HASH_주민번호
		/// </summary>
		[Column("HASH_주민번호")]
		public string HASH_CitizenIDNumber { get; set; }
		/// <summary>
		/// HASH_PTID
		/// </summary>
		[Column("HASH_PTID")]
		public string HASH_PTID { get; set; }
		/// <summary>
		/// HASH_ID_NO
		/// </summary>
		[Column("HASH_ID_NO")]
		public string HASH_ID_NO { get; set; }
		/// <summary>
		/// DI
		/// </summary>
		[Column("DI")]
		public string DI { get; set; }
		/// <summary>
		/// 아이핀인증여부
		/// </summary>
		[Column("아이핀인증여부")]
		public string IPINVerificationOrNot { get; set; }
		/// <summary>
		/// IDXKEY_ID_NO
		/// </summary>
		[Column("IDXKEY_ID_NO")]
		public string IDXKEY_ID_NO { get; set; }
		/// <summary>
		/// CI
		/// </summary>
		[Column("CI")]
		public string CI { get; set; }
		/// <summary>
		/// 가라인증여부
		/// </summary>
		[Column("가라인증여부")]
		public string FakeCertificationOrNot { get; set; }
		/// <summary>
		/// ID_NO2
		/// </summary>
		[Column("ID_NO2")]
		public string ID_NO2 { get; set; }
		/// <summary>
		/// ENC_ID_NO2
		/// </summary>
		[Column("ENC_ID_NO2")]
		public byte[] ENC_ID_NO2 { get; set; }
		/// <summary>
		/// PTKNAME_REAL
		/// </summary>
		[Column("PTKNAME_REAL")]
		public string PTKNAME_REAL { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// 웹사이트번호
		/// </summary>
		[Column("웹사이트번호")]
		public int WebSiteNumber { get; set; }
		/// <summary>
		/// 웹사이트
		/// </summary>
		[Column("웹사이트")]
		public string WebSite { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 전시방식코드
		/// </summary>
		[Column("전시방식코드")]
		public string ShowingMethodCode { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
	}
}