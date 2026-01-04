namespace ModetourB2C.Dac.Model.MODEWARE3.Package;

/// <summary>
/// WSP_S_CMN_단체리스트
/// </summary>
public class GetRepresentativeImageQuery
{
    public const string STRING_QUERY = "SELECT 장소이미지경로 from 패키지단체_장소이미지 where 단체번호 = {0}";

    public class Result1 : IDbResult
    {
        /// <summary>
        /// 단체번호
        /// </summary>
        [Column("장소이미지경로")]
        public string Result { get; set; }
    }
}