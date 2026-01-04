using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModetourB2C.ModeWebBase
{
    public class UserPrcAsisProductListJSONRead
    {
        public const string SPNAME = "UserPrcAsisProductListJSONRead";
        public class Parameters : BaseDbParameters
        {
            /// <summary>
            /// TYPE
            /// </summary>
            [Description("GroupCls")]
            public string GroupCls { get; set; }
            /// <summary>
            /// GR_IDX
            /// </summary>
            [Description("StartDate")]
            public string StartDate { get; set; }
            /// <summary>
            /// AUS_PTID
            /// </summary>
            [Description("EndDate")]
            public string EndDate { get; set; }
            /// <summary>
            /// MW_START
            /// </summary>
            [Description("ItemCode")]
            public string ItemCode { get; set; }         
        }
        public class Result : IDbResult
        {
            /// <summary>
            /// ResultJson
            /// </summary>
            [Column("ResultJson")]
            public string ResultJson { get; set; }
        }
    }
}
