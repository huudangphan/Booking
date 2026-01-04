using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModetourB2C.ModeWebBase
{
    public class UserPrcTravelPrecautionListJSONRead
    {
        public const string SPNAME = "UserPrcTravelPrecautionListJSONRead";
        public class Parameters : BaseDbParameters
        {
            /// <summary>
            /// CountryUnique
            /// </summary>
            [Description("CountryUnique")]
            public string CountryUnique { get; set; }

            /// <summary>
            /// AreaUnique
            /// </summary>
            [Description("AreaUnique")]
            public string? AreaUnique { get; set; }
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
