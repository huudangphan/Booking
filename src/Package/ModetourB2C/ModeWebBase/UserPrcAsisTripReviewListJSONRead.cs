namespace ModetourB2C.ModeWebBase
{
    public class UserPrcAsisTripReviewListJSONRead
    {
        public const string SPNAME = "UserPrcAsisTripReviewListJSONRead";

        public class Parameters : BaseDbParameters
        {
            /// <summary>
            /// PTID
            /// </summary>
            [Description("PTID")]
            public int Ptid { get; set; }

            [Description("CurrentPage")]
            public int CurrentPage { get; set; }

            [Description("EachPageCharactersNumber")]
            public int EachPageCharactersNumber { get; set; }

            [Description("Region")]
            public string Region { get; set; }

            [Description("ProductCode")]
            public string ProductCode { get; set; }

            [Description("ItemClassification")]
            public string ItemClasifitcation { get; set; }

            [Description("Customer")]
            public int Customer { get; set; }
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