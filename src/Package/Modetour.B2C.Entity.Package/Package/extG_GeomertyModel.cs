namespace Modetour.B2C.Entity.Package
{
    public class ExtG_GeomertyModel
    {
        /// <summary>
        /// 위경도
        /// </summary>
        public ExtG_LocationModel location { get; set; }
        /// <summary>
        /// 위경도 상세
        /// </summary>
        public ExtG_ViewportModel viewport { get; set; }
    }

    public class ExtG_ViewportModel
    {
        /// <summary>
        /// 위경도1
        /// </summary>
        public ExtG_LocationModel northeast { get; set; }
        /// <summary>
        /// 위경도2
        /// </summary>
        public ExtG_LocationModel southwest { get; set; }
    }

    public class ExtG_LocationModel
    {
        /// <summary>
        /// 위도
        /// </summary>
        public string lat { get; set; }
        /// <summary>
        /// 경도
        /// </summary>
        public string lng { get; set; }
    }
}
