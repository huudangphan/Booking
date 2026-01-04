using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModetourB2C.Dac.Model.MODEWEBBASE
{
    public class UserPrcProductReviewDeleteTran
    {
        public const string SPNAME = "UserPrcProductReviewDeleteTran";
        public class Parameters : BaseDbParameters
        {
            /// <summary>
            /// ReviewId
            /// </summary>
            [Description("ReviewId")]
            public string ReviewId { get; set; }

            /// <summary>
            /// SaveResult
            /// </summary>
            [Description("SaveResult")]
            [DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 1)]
            public string SaveResult { get; set; }

            /// <summary>
            /// FailureMessage
            /// </summary>
            [Description("FailureMessage")]
            [DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 4000)]
            public string FailureMessage { get; set; }
        }
    }
}
