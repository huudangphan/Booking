namespace Modetour.B2C.Entity.Package
{
    public class Ext_PlaceExternalLinkModel
    {
        /// <summary>
        ///  장소_외부연동 Parse Json Header
        /// </summary>
        public Ext_HeaderModel header { get; set; }
        /// <summary>
        /// 장소_외부연동 Parse Json Response
        /// </summary>
        public Ext_ResponseModel response { get; set; }
        /// <summary>
        /// 유효성 Data -1: 헤더데이터 오류, 0: 데이터없음, 1: 유효
        /// </summary>
        public int Validity { get; set; }
    }
}
