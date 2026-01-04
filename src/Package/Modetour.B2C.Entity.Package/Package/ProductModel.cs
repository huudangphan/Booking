namespace Modetour.B2C.Entity.Package
{
    public class ProductModel
    {
        /// <summary>
        /// 상품코드
        /// </summary>
        public string PCode { get; set; }

        /// <summary>
        /// 단체번호 
        /// </summary>
        public string PNum { get; set; }

        /// <summary>
        /// 출발일자
        /// </summary>
        public string sDate { get; set; }

        /// <summary>
        /// 출발요일
        /// </summary>
        public string sWeekDay { get; set; }

        /// <summary>
        /// 출발시간
        /// </summary>
        public string sTime { get; set; }

        /// <summary>
        /// 출발시간 타입
        /// </summary>
        public string sTimeType { get; set; }

        /// <summary>
        /// 상품코드.상품명
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 테마 클래스명
        /// </summary>
        //public string ThemeClassName { get; set; }

        /// <summary>
        /// 테마명
        /// </summary>
        public string ThemeName { get; set; }

        /// <summary>
        /// 출발지Code[ex:ICN, PUS, CJJ등]
        /// </summary>
        public string SLocationCode { get; set; }

        /// <summary>
        /// 출발지명[ex:서울출발, 부산출발등]
        /// </summary>
        public string SLocation { get; set; }

        /// <summary>
        /// 출발지 클래스명
        /// </summary>
        public string SLocationClassName { get; set; }

        /// <summary>
        /// 단체.상품명
        /// </summary>
        public string PName { get; set; }

        /// <summary>
        /// 항공코드
        /// </summary>
        public string AirCode { get; set; }

        /// <summary>
        /// 항공사명
        /// </summary>
        public string AirName { get; set; }

        /// <summary>
        /// 항공사 이미지
        /// </summary>
        public string AirImg { get; set; }

        /// <summary>
        /// 외국항공
        /// </summary>
        public string ForeignAir { get; set; }

        /// <summary>
        /// 교통수단
        /// </summary>
        public string Transport { get; set; }

        /// <summary>
        /// 저가항공사
        /// </summary>
        public string LowAir { get; set; }

        /// <summary>
        /// 여행기간
        /// </summary>
        public string Period { get; set; }

        /// <summary>
        /// 판매가[어른]
        /// </summary>
        public int AdultPrice { get; set; }

        /// <summary>
        /// 쇼핑횟수
        /// </summary>
        public string ShoppingCnt { get; set; }

        /// <summary>
        /// 가이드여부(가이드확정)
        /// </summary>
        public string IsGuide { get; set; }

        /// <summary>
        /// 호텔등급 img
        /// </summary>
        public string HotelLevel { get; set; }

        /// <summary>
        /// 호텔등급 number
        /// </summary>
        public string HotelLevelCount { get; set; }

        /// <summary>
        /// 현지필수경비여부
        /// </summary>
        public string IsMust { get; set; }

        /// <summary>
        /// 현지필수경비통화[단위]
        /// </summary>
        public string CurrecyUnit { get; set; }

        /// <summary>
        /// 현지필수경비
        /// </summary>
        public string MustCost { get; set; }

        /// <summary>
        /// 예약상태[예약가능/출발확정/대기예약]
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// 예약상태 Class
        /// </summary>
        public string StateClass { get; set; }

        /// <summary>
        /// 골프 라운딩 홀수
        /// </summary>
        public string GolfHoleNum { get; set; }

        /// <summary>
        /// 지역번호(국내제주 및 국내내륙 테마)
        /// </summary>
        public string AreaNum { get; set; }

        /// <summary>
        /// 단독여행 단체테마
        /// </summary>
        public string GroupTheme { get; set; }

        /// <summary>
        /// 골프캐디
        /// </summary>
        public string GolfCaddie { get; set; }

        /// <summary>
        /// 골프카트
        /// </summary>
        public string GolfCart { get; set; }

        /// <summary>
        /// 내림차순[최고가순] 
        /// </summary>
        public string DescSort { get; set; }

        /// <summary>
        /// 오름차순[최저가순]
        /// </summary>
        public string AscSort { get; set; }

        /// <summary>
        /// 상태값 기준 정렬순서
        /// </summary>
        public string StateSort { get; set; }

        /// <summary>
        /// 접두어명
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// 로고파일
        /// </summary>
        public string LogoImage { get; set; }

        /// <summary>
        /// 프로모션마스터번호
        /// </summary>
        public string PromotionNo { get; set; }

    }
}
