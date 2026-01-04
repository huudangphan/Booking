using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModetourB2C.ModeWebBase
{
    public class UserPrcSearchResultFilterListJSONRead
    {
        public const string SPNAME = "UserPrcSearchResultFilterListJSONRead";
        public class Parameters : BaseDbParameters
        {
            /// <summary>
            /// TYPE
            /// </summary>
            [Description("ProductGroupType")]
            public string ProductGroupType { get; set; }            
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
