namespace Modetour.B2C.Entity.Package
{
    /// <summary>
    /// 장소이미지테마    
    /// place image theme
    /// </summary>
    public class PlaceImageThemeModel
    {
        /// <summary>
        /// 일정_세부번호   
        /// schedule_detail number
        /// </summary>
        public int ItiDetailNo { get; set; }
        /// <summary>
        /// 장소이미지테마 일련번호     
        /// Place Image Theme Serial Number
        /// </summary>
        public int SerialNo { get; set; }
        /// <summary>
        /// 장소이미지 파일번호  
        /// Location image file number
        /// </summary>
        public int FileNo { get; set; }
        /// <summary>
        /// 장소이미지 테마코드 
        ///  Place image theme code
        /// </summary>
        public string ThemeCode { get; set; }

    }
}
