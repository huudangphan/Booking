namespace ModetourB2C.ModeWebBase
{
    public class UserPrcProductSearchGroupListJsonRead
    {
        public const string SPNAME = "UserPrcProductSearchGroupListJsonRead";

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