using Modetour.B2C.Entity.Package.PackageXml;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Entity.Package
{
    public class FixedDomesticSubMainPackage
    {
        [JsonProperty("logo")]
        public Logo Logo { get; set; }

        [JsonProperty("topBanners")]
        public TopBanners TopBanners { get; set; }

        [JsonProperty("marketingPopUp")]
        public MarketingPopUp MarketingPopUp { get; set; }

        [JsonProperty("mainBanners")]
        public MainBanner[] MainBanners { get; set; }

        [JsonProperty("mediumBanner")]
        public MediumBanner[] MediumBanner { get; set; }
    }
    public partial class Logo
    {
        [JsonProperty("id")]
     
        public long Id { get; set; }

        [JsonProperty("exposurePeriod")]
        public ExposurePeriod ExposurePeriod { get; set; }

        [JsonProperty("exposurePosition")]
        public string[] ExposurePosition { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("linkedBannerId")]
        public string LinkedBannerId { get; set; }

        [JsonProperty("logoName")]
        public string LogoName { get; set; }

        [JsonProperty("manager")]
        public string Manager { get; set; }

        [JsonProperty("progress")]
        public string Progress { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("registrationDate")]
        public string RegistrationDate { get; set; }
    }

    public partial class ExposurePeriodFixDomestic
    {
        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public partial class MainBanner
    {
        [JsonProperty("id")]        
        public long Id { get; set; }

        [JsonProperty("exposurePeriod")]
        public ExposurePeriod ExposurePeriod { get; set; }

        [JsonProperty("manager")]
        public string Manager { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }

        [JsonProperty("mobile")]
        public Mobile Mobile { get; set; }

        [JsonProperty("pc")]
        public Mobile Pc { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("progress")]
        public string Progress { get; set; }

        [JsonProperty("ranking")]
        public long Ranking { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("registrationDate")]
        public string RegistrationDate { get; set; }
    }

    public partial class Mobile
    {
        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("promotionalText")]
        public PromotionalText[] PromotionalText { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("layers", NullValueHandling = NullValueHandling.Ignore)]
        public object[] Layers { get; set; }
    }

    public partial class PromotionalText
    {
        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public partial class MarketingPopUp
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("content")]
        public Content Content { get; set; }

        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("exposurePeriod")]
        public ExposurePeriod ExposurePeriod { get; set; }

        [JsonProperty("manager")]
        public string Manager { get; set; }

        [JsonProperty("order")]
        public long Order { get; set; }

        [JsonProperty("progress")]
        public string Progress { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("registrationDate")]
        public string RegistrationDate { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }
    }

    public partial class Content
    {
        [JsonProperty("image")]
        public string Image { get; set; }
    }

    public partial class MediumBanner
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("area")]
    
        public long Area { get; set; }

        [JsonProperty("exposurePeriod")]
        public ExposurePeriod ExposurePeriod { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("manager")]
        public string Manager { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("progress")]
        public string Progress { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("registrationDate")]
        public string RegistrationDate { get; set; }

        [JsonProperty("promotionalText", NullValueHandling = NullValueHandling.Ignore)]
        public PromotionalText[] PromotionalText { get; set; }
    }

    public partial class TopBanners
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("bannerTitle")]
        public string BannerTitle { get; set; }

        [JsonProperty("exposureLocation")]
        public string ExposureLocation { get; set; }

        [JsonProperty("exposurePeriod")]
        public ExposurePeriod ExposurePeriod { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("manager")]
        public string Manager { get; set; }

        [JsonProperty("progress")]
        public string Progress { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("registrationDate")]
        public string RegistrationDate { get; set; }
    }
    public partial class ExposurePeriod
    {
        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }
}
