using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModetourB2C.Dac.Model.MODEWEBBASE
{
    public class UserPrcProductReviewListJSONRead
    {
        public const string SPNAME = "UserPrcProductReviewListJSONRead";

        public class Parameters : BaseDbParameters
        {
          
            [Description("AsisMemberNo")]
            public int AsisMemberNo { get; set; }

            [Description("SearchType")]
            public string SearchType { get; set; }

            [Description("SearchWord")]
            public string SearchWord { get; set; }

            [Description("SearchFrom")]
            public string SearchFrom { get; set; }

            [Description("SearchTo")]
            public string SearchTo { get; set; }

            [Description("AsisOrderNumber")]
            public int AsisOrderNumber { get; set; }

            [Description("AsisGroupNumber")]
            public int AsisGroupNumber { get; set; }
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
                       