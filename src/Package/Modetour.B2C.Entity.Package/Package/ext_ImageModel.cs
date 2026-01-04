namespace Modetour.B2C.Entity.Package
{
    public class Ext_ImageModel
    {
        /// <summary>
        /// Json Image Data 묶음, 구분자 = '|'
        /// </summary>
        public List<string> image { get; set; }
        /// <summary>
        /// Json Image parse 작은이미지 url
        /// </summary>
        public List<string> sImage { get; set; }
        /// <summary>
        /// Json Image parse 큰이미지 url
        /// </summary>
        public List<string> bImage { get; set; }
        /// <summary>
        /// Json Image parse 이미지 타입
        /// </summary>
        public List<string> ImageType { get; set; }
    }
}
