using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModetourB2C.Dac.Model.MODEWEBBASE
{
    public class UserPrcProductReviewSaveTran
    {
        public const string SPNAME = "UserPrcProductReviewSaveTran";
        public class Parameters : BaseDbParameters
        {
            /// <summary>
            /// ReviewId
            /// </summary>
            [Description("ReviewId")]
            public string ReviewId { get; set; }

            /// <summary>
            /// WriterName
            /// </summary>
            [Description("WriterName")]
            public string WriterName { get; set; }

            /// <summary>
            /// WriterNickName
            /// </summary>
            [Description("WriterNickName")]
            public string WriterNickName { get; set; }

            /// <summary>
            /// Title
            /// </summary>
            [Description("Title")]
            public string Title { get; set; }

            /// <summary>
            /// Contents
            /// </summary>
            [Description("Contents")]
            public string Contents { get; set; }

            /// <summary>
            /// DepartureDate
            /// </summary>
            [Description("DepartureDate")]
            public string DepartureDate { get; set; }

            /// <summary>
            /// ProductTitle
            /// </summary>
            [Description("ProductTitle")]
            public string ProductTitle { get; set; }

            /// <summary>
            /// TotalPoint
            /// </summary>
            [Description("TotalPoint")]
            public int TotalPoint { get; set; }

            /// <summary>
            /// SchedulePoint
            /// </summary>
            [Description("SchedulePoint")]
            public int SchedulePoint { get; set; }

            /// <summary>
            /// HotelPoint
            /// </summary>
            [Description("HotelPoint")]
            public int HotelPoint { get; set; }

            /// <summary>
            /// AirPoint
            /// </summary>
            [Description("AirPoint")]
            public int AirPoint { get; set; }

            /// <summary>
            /// FoodPoint
            /// </summary>
            [Description("FoodPoint")]
            public int FoodPoint { get; set; }

            /// <summary>
            /// IsDomastic
            /// </summary>
            [Description("IsDomastic")]
            public Boolean? IsDomastic { get; set; }

            /// <summary>
            /// LikeCount
            /// </summary>
            [Description("LikeCount")]
            public int LikeCount { get; set; }

            /// <summary>
            /// AsisMemberNo
            /// </summary>
            [Description("AsisMemberNo")]
            public int AsisMemberNo { get; set; }

            /// <summary>
            /// Hashtag
            /// </summary>
            [Description("Hashtag")]
            public string Hashtag { get; set; }

            /// <summary>
            /// Images
            /// </summary>
            [Description("Images")]
            public string Images { get; set; }

            /// <summary>
            /// WorkType
            /// </summary>
            [Description("WorkType")]
            public string WorkType { get; set; }
            /// <summary>
            /// OrderNumber
            /// </summary>
            [Description("AsisOrderNumber")]
            public int AsisOrderNumber { get; set; }

            /// <summary>
            /// GroupNumber
            /// </summary>
            [Description("AsisGroupNumber")]
            public int AsisGroupNumber { get; set; }

            ///// <summary>
            ///// GroupNumber
            ///// </summary>
            //[Description("AsisAdditionalInfo")]
            //public string AsisAdditionalInfo { get; set; }
            
            /// <summary>
            /// SaveResult
            /// </summary>
            [DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 1)]
            public string SaveResult { get; set; }

            /// <summary>
            /// FailureMessage
            /// </summary>
            [DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 4000)]
            public string FailureMessage { get; set; }
        }
    }

}
