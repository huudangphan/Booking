using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Entity.Package.TravelCore
{
    public class PackageReservationViewModel
    {
        /// <summary>
        /// 주문번호
        /// </summary>
        public long? OrderNo { get; set; }

        /// <summary>
        /// 주문번호 hash값 add by 2019.11.19(신지영)
        /// </summary>
        public string HashOrderNo { get; set; }

        /// <summary>
        /// 예약자번호
        /// </summary>
        public long OrderPtid { get; set; }
        /// <summary>
        /// 단체번호
        /// </summary>
        public int Pnum { get; set; }

        /// <summary>
        /// 상품코드
        /// </summary>
        public string PCode { get; set; }

        /// <summary>
        /// 사이트번호
        /// </summary>
        public int SiteNo { get; set; }

        /// <summary>
        /// 거래처번호
        /// </summary>
        public int AgentNo { get; set; }

        /// <summary>
        /// 거래처직원번호
        /// </summary>
        public int? AgentEmpNo { get; set; }

        /// <summary>
        /// 임시 거래처번호
        /// </summary>
        public int TempAgentNo { get; set; }

        /// <summary>
        /// 임시 거래처직원번호
        /// </summary>
        public string TempAgentEmpNo { get; set; }

        /// <summary>
        /// 로그인정보?
        /// </summary>
        public string NoMember { get; set; }

        /// <summary>
        /// 조기예약할인여부
        /// </summary>
        public string EarlyBookingFlag { get; set; }

        /// <summary>
        /// 구매수단코드
        /// </summary>
        public string BuyCode { get; set; }

        /// <summary>
        /// 내부결제가능여부
        /// </summary>
        public string InnerPayFlag { get; set; }

        /// <summary>
        /// 성인 예약 인원수
        /// </summary>
        public int AdultCount { get; set; }

        /// <summary>
        /// 아동N 예약 인원수
        /// </summary>
        public int InfantNCount { get; set; }

        /// <summary>
        /// 아동E 예약 인원수
        /// </summary>
        public int InfantECount { get; set; }

        /// <summary>
        /// 유아 예약 인원수
        /// </summary>
        public int ChildCount { get; set; }

        /// <summary>
        /// 여행 총 인원
        /// </summary>
        public int TravelerCnt { get; set; }

        /// <summary>
        /// 특별약관동의여부
        /// </summary>
        public string SpecialClauseFlag { get; set; }

        /// <summary>
        /// 판매종류코드[ 01 : 패키지 , 00 : 티켓 , 02 : 랜드 (철도패스/입장권 등)]
        /// </summary>
        public string GoodsType { get; set; }

        /// <summary>
        /// 캠페인 ID(쿠키값)
        /// </summary>
        public string CampaignID { get; set; }

        /// <summary>
        /// 캠페인 날짜(쿠키값)
        /// </summary>
        public string CampaignDate { get; set; }

        /// <summary>
        /// 클럽커미션율
        /// </summary>
        public decimal CommissionRate { get; set; }

        /// <summary>
        /// 파트너여행사매칭여부 
        /// </summary>
        public string PartnerMatchingFlag { get; set; }

        /// <summary>
        /// 에러정보
        /// </summary>
        public Dictionary<string, string> ErrorItem { get; set; }

        /// <summary>
        /// 에러메세지[노출용]
        /// </summary>
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 시스템 에러메세지[확인용]
        /// </summary>
        public string SysErrorMsg { get; set; }

        /// <summary>
        /// 확인값
        /// </summary>
        public string Chdata { get; set; }
    }

}
