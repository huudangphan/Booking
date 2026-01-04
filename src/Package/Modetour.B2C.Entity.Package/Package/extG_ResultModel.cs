namespace Modetour.B2C.Entity.Package
{
    public class ExtG_ResultModel
    {
        /// <summary>
        /// 주소 --address
        /// </summary>
        public string formatted_address { get; set; }
        /// <summary>
        /// 전화번호 --Phone number
        /// </summary>
        public string formatted_phone_number { get; set; }
        /// <summary>
        /// 위치멤버 -- location member
        /// </summary>
        public ExtG_GeomertyModel geometry { get; set; }
        /// <summary> 
        /// 구글장소id --text place id
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 전화번호_국제 -- Phone_International194849
        /// </summary>
        public string international_phone_number { get; set; }
        /// <summary>
        /// 장소명 --name
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 닫/여는시간  --  Closing/opening hours
        /// </summary>
        public ExtG_PeriodsModel opening_hours { get; set; }
        /// <summary>
        /// 구글장소id2 --   google placeid2
        /// </summary>
        public string place_id { get; set; }
        /// <summary>
        /// 구글등급 -- Google Rating
        /// </summary>
        public string rating { get; set; }
        /// <summary>
        /// 구글장소호출 api key별 reference 
        /// </summary>
        public string reference { get; set; }
        /// <summary>
        /// 리뷰들 
        /// </summary>
        public List<ExtG_ReviewsModel> reviews { get; set; }
        /// <summary>
        /// 구글타입 ex 박물관, 흥미장소 등등 
        /// Google type ex museums, places of interest, etc.
        /// </summary>
        public List<string> types { get; set; }
        /// <summary>
        /// 구글맵주소
        /// google map address
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 장소홈페이지
        /// place homepage
        /// </summary>
        public string website { get; set; }
    }
}
