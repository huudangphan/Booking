namespace Modetour.B2C.Entity.Package
{
    public class Ext_ResponseModel
    {
        /// <summary>
        /// 마감시간
        /// </summary>
        public string finishTime { get; set; }
        /// <summary>
        /// 아이템코드
        /// </summary>
        public string itemCode { get; set; }
        /// <summary>
        /// crc
        /// </summary>
        public string crc { get; set; }
        /// <summary>
        /// ctc
        /// </summary>
        public string ctc { get; set; }
        /// <summary>
        /// 국가명_영문
        /// </summary>
        public string ctnE { get; set; }
        /// <summary>
        /// 국가명_한글
        /// </summary>
        public string ctnK { get; set; }
        /// <summary>
        /// hcd
        /// </summary>
        public string hcd { get; set; }
        /// <summary>
        /// 호텔명_영문
        /// </summary>
        public string hotelNameE { get; set; }
        /// <summary>
        /// 호텔명_한글
        /// </summary>
        public string hotelNameK { get; set; }
        /// <summary>
        /// 호텔성급
        /// </summary>
        public string hotelClass { get; set; }
        /// <summary>
        /// 전화번호
        /// </summary>
        public string hotelTel { get; set; }
        /// <summary>
        /// 팩스번호
        /// </summary>
        public string hotelFax { get; set; }
        /// <summary>
        /// 우편번호
        /// </summary>
        public string hotelPostal { get; set; }
        /// <summary>
        /// 주소
        /// </summary>
        public string hotelAddress { get; set; }
        /// <summary>
        /// 위도
        /// </summary>
        public string latitude { get; set; }
        /// <summary>
        /// 경도
        /// </summary>
        public string longitude { get; set; }
        /// <summary>
        /// 위치
        /// </summary>
        public string hotelLocation { get; set; }
        /// <summary>
        /// 메인이미지 url
        /// </summary>
        public string mainImage { get; set; }
        /// <summary>
        /// cki
        /// </summary>
        public string cki { get; set; }
        /// <summary>
        /// cko
        /// </summary>
        public string cko { get; set; }
        /// <summary>
        /// 호텔룸수
        /// </summary>
        public string hotelRoomCnt { get; set; }
        /// <summary>
        /// 호텔층수
        /// </summary>
        public string hotelFloor { get; set; }
        /// <summary>
        /// 체이큰마감시간
        /// </summary>
        public string ckifinish { get; set; }
        /// <summary>
        /// 최소체이크인나이
        /// </summary>
        public string ckiMinage { get; set; }
        /// <summary>
        /// 준공연도
        /// </summary>
        public string completedYear { get; set; }
        /// <summary>
        /// 빌딩수
        /// </summary>
        public string towerCount { get; set; }
        /// <summary>
        /// 트립어드바이저코드
        /// </summary>
        public string tripAdvisorCode { get; set; }
        /// <summary>
        /// 트립어드바이저성급
        /// </summary>
        public string tripAdvisorClass { get; set; }
        /// <summary>
        /// 트립어드바이저리뷰
        /// </summary>
        public string tripAdvisorReview { get; set; }
        /// <summary>
        /// 트립어드바이저 image url 올빼미
        /// </summary>
        public string tripAdvisorURL { get; set; }
        /// <summary>
        /// 호텔설명
        /// </summary>
        public string hotelHeedDesc { get; set; }
        /// <summary>
        /// 선택사항설명
        /// </summary>
        public string hotelChoiceServiceDesc { get; set; }
        /// <summary>
        /// 가격설명
        /// </summary>
        public string hotelRequirePriceDesc { get; set; }
        /// <summary>
        /// 시설설명
        /// </summary>
        public string hotelFacilityDesc { get; set; }
        /// <summary>
        /// 방설명
        /// </summary>
        public string hotelRoomDesc { get; set; }
        /// <summary>
        /// 애머니티설명
        /// </summary>
        public string hotelAmenitiesDesc { get; set; }
        /// <summary>
        /// 식사설명
        /// </summary>
        public string hotelDinningAmenitiesDesc { get; set; }
        /// <summary>
        /// 비즈니스시설설명
        /// </summary>
        public string hotelBusinessDesc { get; set; }
        /// <summary>
        /// 동물동반설명
        /// </summary>
        public string hotelAnimalDesc { get; set; }
        /// <summary>
        /// 장애인지원설명
        /// </summary>
        public string hotelHandicapDesc { get; set; }
        /// <summary>
        /// 방애머니티 
        /// </summary>
        public string roomAmenities { get; set; }
        /// <summary>
        /// 방애머니티 split data '|'
        /// </summary>
        public List<string> arrroomAmenities { get; set; }
        /// <summary>
        /// 장실애머니티
        /// </summary>
        public string bathRoomAmenities { get; set; }
        /// <summary>
        /// 장실애머니티 split data '|'
        /// </summary>
        public List<string> arrbathRoomAmenities { get; set; }
        /// <summary>
        /// 인터넷애머니티
        /// </summary>
        public string interNetAmenities { get; set; }
        /// <summary>
        /// 인터넷애머니티 split data '|'
        /// </summary>
        public List<string> arrinterNetAmenities { get; set; }
        /// <summary>
        /// 야외시설애머니티
        /// </summary>
        public string poolAmenities { get; set; }
        /// <summary>
        /// 야외시설애머니티 split data '|'
        /// </summary>
        public List<string> arrpoolAmenities { get; set; }
        /// <summary>
        /// 식사애머니티
        /// </summary>
        public string restrantAmenities { get; set; }
        /// <summary>
        /// 식사애머니티 split data '|'
        /// </summary>
        public List<string> arrrestrantAmenities { get; set; }
        /// <summary>
        /// 시설애머니티
        /// </summary>
        public string facilityAmenities { get; set; }
        /// <summary>
        /// 시설애머니티 split data '|'
        /// </summary>
        public List<string> arrfacilityAmenities { get; set; }
        /// <summary>
        /// 기본애머니티
        /// </summary>
        public string defaultAmenities { get; set; }
        /// <summary>
        /// 기본애머니티 split data '|'
        /// </summary>
        public List<string> arrdefaultAmenities { get; set; }
        /// <summary>
        /// 주차애머니티
        /// </summary>
        public string parkingAmenities { get; set; }
        /// <summary>
        /// 주차애머니티 split data '|'
        /// </summary>
        public List<string> arrparkingAmenities { get; set; }
        /// <summary>
        /// 셔틀애머니티
        /// </summary>
        public string suttleAmenities { get; set; }
        /// <summary>
        /// 셔틀애머니티 split data '|'
        /// </summary>
        public List<string> arrsuttleAmenities { get; set; }
        /// <summary>
        /// 카드애머니티
        /// </summary>
        public string creditAmenities { get; set; }
        /// <summary>
        /// 카드애머니티 split data '|'
        /// </summary>
        public List<string> arrcreditAmenities { get; set; }

        /// <summary>
        /// arr 호텔 이미지 
        /// </summary>
        public Ext_ImageModel hotelImage { get; set; }
    }
}
