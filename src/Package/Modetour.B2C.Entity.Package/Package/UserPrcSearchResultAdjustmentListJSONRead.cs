using Modetour.Models.Datas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Entity.Package.Package
{
    public class UserPrcSearchResultAdjustmentListJSONRead
    {
        public const string SP_NAME = "UserPrcSearchResultAdjustmentListJSONRead";
        public class Parameters : BaseDbParameters
        {
            /// <summary>
            /// ProductGroupType
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
