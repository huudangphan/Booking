namespace Modetour.B2C.Entity.Package
{
    /// <summary>
	/// 항공비고 --air note
	/// </summary>
	public class AirRemarksModel
    {
        /// <summary>
        /// 항공비고명 --  airline name
        /// </summary>
        public string RemarksName { get; set; }
        /// <summary>
        /// 항공비고내용 --Aviation Remarks
        /// </summary>
        public string RemarksContents { get; set; }
        /// <summary>
        /// 항공비고_마스터일련번호 --Aviation Remarks_Master Serial Number
        /// </summary>
        public int MasterNo { get; set; }
    }
}
