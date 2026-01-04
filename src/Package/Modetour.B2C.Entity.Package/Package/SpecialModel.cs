namespace Modetour.B2C.Entity.Package
{
    public class SpecialModel
    {
        /// <summary>
        /// 결과코드
        /// </summary>
        public string Code { set; get; }

        /// <summary>
        /// 결과메시지
        /// </summary>
        public string Msg { get; set; }

        /// <summary>
        /// 상품코드
        /// </summary>
        public string PCode { get; set; }

        /// <summary>
        /// 특가명
        /// </summary>
        public string SpecialName { get; set; }

        /// <summary>
        /// 단체명
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// 부제목
        /// </summary>
        public string ProductSubName { get; set; }

        /// <summary>
        /// MDPICK
        /// </summary>
        public string MdPick { get; set; }

        /// <summary>
        /// 설명
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 이미지경로
        /// </summary>
        public string ImagePath { get; set; }

        /// <summary>
        /// 이미지
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// 최소단체번호
        /// </summary>
        public string MinPnum { get; set; }

        /// <summary>
        /// 최초출발일
        /// </summary>
        public string FirstSDate { get; set; }

        /// <summary>
        /// 마지막출발일
        /// </summary>
        public string LastSDate { get; set; }

        /// <summary>
        /// 대표국가
        /// </summary>
        public string NationPlid { get; set; }

        /// <summary>
        /// 대표도시
        /// </summary>
        public string CityPlid { get; set; }

        /// <summary>
        /// 대표국가명
        /// </summary>
        public string NationName { get; set; }

        /// <summary>
        /// 대표도시명
        /// </summary>
        public string CityName { get; set; }

        /// <summary>
        /// 지역번호
        /// </summary>
        public string AreaNo { get; set; }

        /// <summary>
        /// 기준일
        /// </summary>
        public string StandardDate { get; set; }

        /// <summary>
        /// 마감일
        /// </summary>
        public string DeadlineDate { get; set; }

        /// <summary>
        /// 최소가격
        /// </summary>
        public string MinPrice { get; set; }

        /// <summary>
        /// 노출시작일 
        /// </summary>
        public string DisplayAddDay { get; set; }

        /// <summary>
        /// 상품마감여부 add by 2021.10.20(신지영)
        /// </summary>
        public string CloseTF { get; set; }

    }
}
