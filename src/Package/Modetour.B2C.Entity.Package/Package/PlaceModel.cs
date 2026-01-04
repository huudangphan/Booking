using Modetour.Models.Datas;

namespace Modetour.B2C.Entity.Package
{
    public class PlaceModel
    {
        public class Result : IDbResult
        {
            /// <summary>
            /// 일정_세부번호
            /// </summary>

            public int ItiDetailNo { get; set; }
            /// <summary>
            /// 일정_날짜
            /// </summary>

            public DateTime ItiDate { get; set; }
            /// <summary>
            /// 일정_일차
            /// </summary>

            public int ItiDays { get; set; }
            /// <summary>
            /// 일정_순서
            /// </summary>

            public int ItiSeq { get; set; }
            /// <summary>
            /// 일정_서비스종류코드
            /// </summary>

            public string ItiServiceCode { get; set; }
            /// <summary>
            /// 일정_장소명
            /// </summary>

            public string ItiPlaceName { get; set; }
            /// <summary>
            /// 일정_장소그룹번호
            /// </summary>

            public int ItiPlaceGroupNo { get; set; }
            /// <summary>
            /// 일정_장소그룹명
            /// </summary>

            public string ItiPlaceGroupName { get; set; }
            /// <summary>
            /// 일정_서비스이름
            /// </summary>

            public string ItiServiceName { get; set; }
            /// <summary>
            /// 일정_한줄설명
            /// </summary>

            public string ItiSummaryDes { get; set; }
            /// <summary>
            /// 일정_간략설명
            /// </summary>

            public string ItiDetailDes { get; set; }
            /// <summary>
            /// 일정_핵심여행지여부 0 : 1
            /// </summary>

            public int ItiPointPlace { get; set; }
            /// <summary>
            /// 일정_핵심여행지순서
            /// </summary>

            public int ItiPointPlaceSeq { get; set; }
            /// <summary>
            /// 일정_특전여부 0 : 1
            /// </summary>

            public int ItiBenefit { get; set; }
            /// <summary>
            /// 일정_강조표시여부 0 : 1
            /// </summary>

            public int ItiHighlight { get; set; }
            /// <summary>
            /// 장소번호
            /// </summary>

            public int PlaceNo { get; set; }
            /// <summary>
            /// 구글OUTLINK여부 0 : 1
            /// </summary>

            public int OutLinkFlag { get; set; }
            /// <summary>
            /// 장소그룹 장소 노출순서
            /// </summary>

            public int PlaceSeq { get; set; }

            /// <summary>
            /// 상위장소번호
            /// </summary>
            public int ParentPlaceNo { get; set; }

            /// <summary>
            /// 장소분류코드
            /// </summary>
            public string PlaceCategory { get; set; }

            /// <summary>
            /// 장소그룹_일정표노출명
            /// </summary>
            public string ExposeName { get; set; }

            /// <summary>
            /// 장소이름 한글
            /// </summary>
            public string PlaceNameK { get; set; }

            /// <summary>
            /// 장소이름 영어
            /// </summary>
            public string PlaceNameE { get; set; }

            /// <summary>
            /// 장소이름 현지
            /// </summary>
            public string PlaceNameL { get; set; }

            /// <summary>
            /// 대륙코드
            /// </summary>
            public string ContinentCode { get; set; }

            /// <summary>
            /// 국가코드
            /// </summary>
            public string CountryCode { get; set; }

            /// <summary>
            /// 국가번호
            /// </summary>
            public int CountryNo { get; set; }

            /// <summary>
            /// 지방코드
            /// </summary>
            public string AreaCode { get; set; }

            /// <summary>
            /// 도시코드
            /// </summary>
            public string CityCode { get; set; }

            /// <summary>
            /// 공항코드
            /// </summary>
            public string AirPortCode { get; set; }

            /// <summary>
            /// 위도
            /// </summary>
            public decimal GridY { get; set; }

            /// <summary>
            /// 경도
            /// </summary>
            public decimal GridX { get; set; }

            /// <summary>
            /// 일정등록수
            /// </summary>
            public int RegCount { get; set; }

            /// <summary>
            /// Path
            /// </summary>
            public string PlacePath { get; set; }

            /// <summary>
            /// 사용여부 0 : 1
            /// </summary>
            public int Used { get; set; }

            /// <summary>
            /// 카피라이팅
            /// </summary>
            public string Copyright { get; set; }

            /// <summary>
            /// 한줄설명
            /// </summary>
            public string SummaryDes { get; set; }

            /// <summary>
            /// 등급
            /// </summary>
            public string Rating { get; set; }

            /// <summary>
            /// 주소
            /// </summary>
            public string Address { get; set; }

            /// <summary>
            /// 연락처
            /// </summary>
            public string ContactTel { get; set; }

            /// <summary>
            /// 홈페이지
            /// </summary>
            public string HomePage { get; set; }

            /// <summary>
            /// 찾아가는길
            /// </summary>
            public string ContactWay { get; set; }

            /// <summary>
            /// 영업시간
            /// </summary>
            public string SalesTime { get; set; }

            /// <summary>
            /// 이용요금
            /// </summary>
            public string Charge { get; set; }

            /// <summary>
            /// 소요시간
            /// </summary>
            public string TakeTime { get; set; }

            /// <summary>
            /// 대체일정
            /// </summary>
            public string AlterPlace { get; set; }

            /// <summary>
            /// 시설규모
            /// </summary>
            public string PlaceSize { get; set; }

            /// <summary>
            /// 부대시설
            /// </summary>
            public string AdditionalPlace { get; set; }

            /// <summary>
            /// 세부정보
            /// </summary>
            public string DetailDes { get; set; }

            /// <summary>
            /// 강조사항
            /// </summary>
            public string HighlightDes { get; set; }

            /// <summary>
            /// 서머타임
            /// </summary>
            public string SummerTime { get; set; }

            /// <summary>
            /// 숙소타입
            /// </summary>
            public string PlaceType { get; set; }

            /// <summary>
            /// 날씨영문명? 뭐지
            /// </summary>
            public string WeatherE { get; set; }

            /// <summary>
            /// 컨텐츠수
            /// </summary>
            public int ContentsCount { get; set; }

            /// <summary>
            /// 컨텐츠수_하위포함
            /// </summary>
            public int ContentsCountWithChild { get; set; }

            /// <summary>
            /// 등록자
            /// </summary>
            public int RegUser { get; set; }

            /// <summary>
            /// 등록일
            /// </summary>
            public DateTime RegTime { get; set; }

            /// <summary>
            /// 장소정보 비고
            /// </summary>
            public string Remarks { get; set; }

            /// <summary>
            /// 구글키
            /// </summary>
            public string GoogleKey { get; set; }

            /// <summary>
            /// 아이템번호
            /// </summary>
            public int ItemNo { get; set; }

            /// <summary>
            /// 승인여부 0 : 1
            /// </summary>
            public int Approve { get; set; }

            /// <summary>
            /// 수정자
            /// </summary>
            public int UpdateUser { get; set; }

            /// <summary>
            /// 수정일
            /// </summary>
            public DateTime UpdateTime { get; set; }

            /// <summary>
            /// 영업시간_구글
            /// </summary>
            public string SalesTime_GG { get; set; }

            /// <summary>
            /// 내부이미지우선노출
            /// </summary>
            public string ModeImgPriority { get; set; }

            /// <summary>
            /// 대체장소_한글이름
            /// </summary>
            public string AlterPlaceNameK { get; set; }

            /// <summary>
            /// arr_장소키워드
            /// </summary>
            public List<PlaceKeywordModel> arrKeyword { get; set; }

            /// <summary>
            /// arr_장소이미지
            /// </summary>
            public List<PlaceImageModel>? arrPlaceImge { get; set; }

            /// <summary>
            /// 외부연동 데이터_트립어드바이저
            /// </summary>
            public Ext_PlaceExternalLinkModel ExternalLink { get; set; }

            ///// <summary>
            ///// 외부연동 데이터_트립어드바이저_리뷰내용
            ///// </summary>
            public Ext_PlaceReviewModel ExternalLinkReview { get; set; }

            ///// <summary>
            ///// 외부연동 데이터_구글
            ///// </summary>
            public ExtG_GoogleExternalLinkModel ExternalLink_GG { get; set; }

            /// <summary>
            /// 구글지도파일명
            /// </summary>
            public string GoogleMapImg { get; set; }

            /// <summary>
            /// 서비스이름WITH한줄설명
            /// </summary>
            public string ServiceWITHSummary { get; set; }

            /// <summary>
            /// 방문도시대상여부
            /// </summary>
            public string VisitCityFlag { get; set; }

            /// <summary>
            /// 타임라인노출여부
            /// </summary>
            public string TimeLineFlag { get; set; }

            /// <summary>
            /// 바디아이콘종류
            /// </summary>
            public string BodyIconKind { get; set; }

            /// <summary>
            /// 서비스코드명노출
            /// </summary>
            public string ServiceCodeFlag { get; set; }

            /// <summary>
            /// 라벨노출여부
            /// </summary>
            public string LabelFlag { get; set; }

            /// <summary>
            /// 간략타임라인항목
            /// </summary>
            public string sTimeLineItem { get; set; }

            /// <summary>
            /// 상세타임라인항목
            /// </summary>
            public string dTimeLineItem { get; set; }

            /// <summary>
            /// 푸터노출여부
            /// </summary>
            public string TimeLineFooterFlag { get; set; }

            /// <summary>
            /// 모달여부
            /// </summary>

            public string ModalFlag { get; set; }
            public bool? DisplayLabel { get; set; }

            public string PlaceClassificationCode { get; set; }
            public string? CityName { get; set; }
            public string ServiceExplaination { get; set; }
        }
    }
}