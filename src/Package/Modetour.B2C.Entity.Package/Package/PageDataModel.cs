namespace Modetour.B2C.Entity.Package
{
    public class PageDataModel
    {
        /// <summary>
        /// 특선상품번호
        /// </summary>
        public string Idx { get; set; }

        /// <summary>
        /// 상품코드
        /// </summary>
        public string PCode { get; set; }

        /// <summary>
        /// 상품명
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 여행도시
        /// </summary>
        public string TravelCity { get; set; }

        /// <summary>
        /// MLOC 값
        /// </summary>
        public string MLOC { get; set; }

        /// <summary>
        /// 네비게이션 HTML
        /// </summary>
        public string NavigationHtml { get; set; }

        /// <summary>
        /// 네비게이션 data-navi 정보
        /// </summary>
        public string DataNavi { get; set; }

        /// <summary>
        /// 단체명 param
        /// </summary>
        //public string DName { get; set; }

        /// <summary>
        /// 출발일조건 param
        /// </summary>
        //public string DTS { get; set; }

        /// <summary>
        /// 항공코드목록 param
        /// </summary>
        //public string ACS { get; set; }

        /// <summary>
        /// 요일목록 param
        /// </summary>
        //public string WKS { get; set; }

        /// <summary>
        /// 박일 param
        /// </summary>
        //public string Days { get; set; }

        /// <summary>
        /// 가격조건 param
        /// </summary>
        //public string PS { get; set; }

        /// <summary>
        /// 특선상품 모델
        /// </summary>
        public SpecialModel Item { get; set; }

        /// <summary>
        /// 공휴일리스트 string형
        /// </summary>
        public string DateArrTxt { get; set; }
    }
}
