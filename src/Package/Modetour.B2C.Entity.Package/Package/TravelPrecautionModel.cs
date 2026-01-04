using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Entity.Package.Package
{
    public partial class TravelPrecautionModel
    {
        [JsonProperty("CountryUnique")]
        public string CountryUnique { get; set; }

        [JsonProperty("AreaUnique")]
        public string AreaUnique { get; set; }

        [JsonProperty("KoreanName")]
        public string KoreanName { get; set; }

        [JsonProperty("EnglishName")]
        public string EnglishName { get; set; }


        [JsonProperty("SimilarWord")]
        public string SimilarWord { get; set; }

        [JsonProperty("TravelPrecautionName")]
        public string TravelPrecautionName { get; set; }


        [JsonProperty("TravelPrecautionContent")]
        public string TravelPrecautionContent { get; set; }


        [JsonProperty("TravelPrecautionTypeWebCode")]
        public string TravelPrecautionTypeWebCode { get; set; }

        [JsonProperty("TravelBan")]
        public List<TravelBan> TravelBan { get; set; }
        [JsonProperty("TravelAlarm")]
        public List<TravelAlarm> TravelAlarm { get; set; }
        [JsonProperty("Accident")]
        public List<Accident> Accident { get; set; }

        [JsonProperty("OpenApiOverseasArrival")]
        public List<OpenApiOverseasArrival> OpenApiOverseasArrival { get; set; }

        [JsonProperty("OpenApiCountrySafety")]
        public List<OpenApiCountrySafety> OpenApiCountrySafety { get; set; }
    }
    public partial class TravelBan
    {
        [JsonProperty("ContinentName")]
        public string ContinentName { get; set; }

        [JsonProperty("CountryName")]
        public string CountryName { get; set; }

        [JsonProperty("CountryEnglishName")]
        public string CountryEnglishName { get; set; }

        [JsonProperty("CountryIsoCode")]
        public string CountryIsoCode { get; set; }

        [JsonProperty("Ban")]
        public string Ban { get; set; }

        [JsonProperty("BanPartial")]
        public string BanPartial { get; set; }

        [JsonProperty("BanNote")]
        public string BanNote { get; set; }

        [JsonProperty("NationalFlagDownloadUrl")]
        public string NationalFlagDownloadUrl { get; set; }

        [JsonProperty("DangerousMapDownloadUrl")]
        public string DangerousMapDownloadUrl { get; set; }

        [JsonProperty("WrittenDate")]
        public string WrittenDate { get; set; }
    }

    public partial class TravelAlarm
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("DangerousMapDownloadUrl")]
        public string DangerousMapDownloadUrl { get; set; }

        [JsonProperty("NationalFlagDownloadUrl")]
        public string NationalFlagDownloadUrl { get; set; }

        [JsonProperty("MapDownloadUrl")]
        public string MapDownloadUrl { get; set; }

        [JsonProperty("AlarmLevel")]
        public string AlarmLevel { get; set; }

        [JsonProperty("RegionType")]
        public string RegionType { get; set; }

        [JsonProperty("Remark")]
        public string Remark { get; set; }

        [JsonProperty("WrittenDate")]
        public string WrittenDate { get; set; }


    }
    public partial class Accident
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("DangerousMapDownloadUrl")]
        public string DangerousMapDownloadUrl { get; set; }

        [JsonProperty("NationalFlagDownloadUrl")]
        public string NationalFlagDownloadUrl { get; set; }

        [JsonProperty("HtmlContent")]
        public string HtmlContent { get; set; }

        [JsonProperty("WrittenDate")]
        public string WrittenDate { get; set; }


    }

    public partial class OpenApiOverseasArrival
    {
        [JsonProperty("NoticeId")]
        public string NoticeId { get; set; }

        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("Content")]
        public string Content { get; set; }

        [JsonProperty("HtmlContent")]
        public string HtmlContent { get; set; }

        [JsonProperty("WrittenDate")]
        public string WrittenDate { get; set; }


    }
    public partial class OpenApiCountrySafety
    {
        [JsonProperty("NoticeId")]
        public string NoticeId { get; set; }

        [JsonProperty("CategoryName")]
        public string CategoryName { get; set; }

        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("HtmlContent")]
        public string HtmlContent { get; set; }

        [JsonProperty("FileDownloadUrl")]
        public string FileDownloadUrl { get; set; }
        [JsonProperty("FilePath")]
        public string FilePath { get; set; }

        [JsonProperty("WrittenDate")]
        public string WrittenDate { get; set; }

    }


}
