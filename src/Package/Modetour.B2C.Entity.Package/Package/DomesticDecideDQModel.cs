namespace Modetour.B2C.Entity.Package
{
    /// <summary>
    /// 국내출발확정
    /// </summary>
    public class DomesticDecideDQModel

    {    /// <summary>
         /// 웹지역번호 -- web area code
         /// </summary>
        public int AreaNo { get; set; }

        /// <summary>
        /// 사이트번호 --site number
        /// </summary>
        public int SiteNo { get; set; }

        /// <summary>
        /// 거래처번호 --account number
        /// </summary>
        public int AgentNo { get; set; }
    }
}
