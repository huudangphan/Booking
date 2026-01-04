using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModetourB2C.Dac.Model.MODEWEBBASE
{
    public class UserPrcProductReviewCommentSave
    {
        public const string SPNAME = "UserPrcProductReviewCommentSave";
        public class Parameters : BaseDbParameters
        {
            /// <summary>
            /// ReviewCommentId
            /// </summary>
            [Description("ReviewCommentId")]
            public string ReviewCommentId { get; set; }

            /// <summary>
            /// ReviewId
            /// </summary>
            [Description("ReviewId")]
            public string ReviewId { get; set; }

            /// <summary>
            /// IsReComment
            /// </summary>
            [Description("IsReComment")]
            public Boolean IsReComment { get; set; }

            /// <summary>
            /// RefReviewCommentId
            /// </summary>
            [Description("RefReviewCommentId")]
            public string RefReviewCommentId { get; set; }

            /// <summary>
            /// RefWriterNickName
            /// </summary>
            [Description("RefWriterNickName")]
            public string RefWriterNickName { get; set; }

            /// <summary>
            /// WriterNickName
            /// </summary>
            [Description("WriterNickName")]
            public string WriterNickName { get; set; }

            /// <summary>
            /// WriterName        
            /// </summary>
            [Description("WriterName")]
            public string WriterName { get; set; }

            /// <summary>
            /// Contents
            /// </summary>
            [Description("Contents")]
            public string Contents { get; set; }

            /// <summary>
            /// AsisMemberNo
            /// </summary>
            [Description("AsisMemberNo")]
            public int AsisMemberNo { get; set; }

            /// <summary>
            /// SortOrder
            /// </summary>
            [Description("SortOrder")]
            public int SortOrder { get; set; }

            /// <summary>
            /// WorkType
            /// </summary>
            [Description("WorkType")]
            public string WorkType { get; set; }

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
