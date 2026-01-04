using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModetourB2C.ModeWebBase
{
    public class UserPrcAreaKeywordListJSONRead
    {
        public const string SPNAME = "UserPrcAreaKeywordListJSONRead";
        public class Parameters : BaseDbParameters
        {
            /// <summary>
            /// ProductGroupType
            /// </summary>
            [Description("AreaKeywordType")]
            public string AreaKeywordType { get; set; }      
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
