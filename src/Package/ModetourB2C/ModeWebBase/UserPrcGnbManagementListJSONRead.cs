using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModetourB2C.ModeWebBase
{
    public class UserPrcGnbManagementListJSONRead
    {
        public const string spName = "UserPrcGnbManagementListJSONRead";
        public class UserPrcGnbManagementListJSONReadParameter : BaseDbParameters
        {
            /// <summary>
            /// DeviceType
            /// </summary>
            [Description("DeviceType")]
            public string DeviceType { get; set; }
            /// <summary>
            /// WebSiteType
            /// </summary>
            [Description("WebSiteType")]
            public string WebSiteType { get; set; }

            /// <summary>
            /// WebTemplateAreaType
            /// </summary>
            [Description("GnbType")]
            public string GnbType { get; set; }
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
