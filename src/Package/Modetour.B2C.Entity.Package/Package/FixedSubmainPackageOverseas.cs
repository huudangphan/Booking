using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Entity.Package.Package
{
    public class FixedSubmainPackageOverseas
    {
        [JsonProperty("logo")]
        public LogoFixedOverseas Logo { get; set; }

        [JsonProperty("topBanners")]
        public TopBannersOverseasPackage TopBanners { get; set; }

        [JsonProperty("marketingPopUp")]
        public MarketingPopUpMarketingPopUpOverseas MarketingPopUp { get; set; }

        [JsonProperty("mainBanners")]
        public MainBannerOverseas[] MainBanners { get; set; }

        [JsonProperty("mediumBanner")]
        public MediumBannerOverseas[] MediumBanner { get; set; }
    }
    public partial class LogoFixedOverseas
    {
        [JsonProperty("id")]
   
        public long Id { get; set; }

        [JsonProperty("exposurePeriod")]
        public ExposurePeriodOverseasPackage ExposurePeriod { get; set; }

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

    public partial class ExposurePeriodOverseasPackage
    {
        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public partial class MainBannerOverseas
    {
        [JsonProperty("id")]
     
        public long Id { get; set; }

        [JsonProperty("exposurePeriod")]
        public ExposurePeriodOverseasPackage ExposurePeriod { get; set; }

        [JsonProperty("manager")]
        public string Manager { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }

        [JsonProperty("mobile")]
        public MobileMobileOverseas Mobile { get; set; }

        [JsonProperty("pc")]
        public MobileMobileOverseas Pc { get; set; }

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

    public partial class MobileMobileOverseas
    {
        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("promotionalText")]
        public PromotionalTextPackageOverseas[] PromotionalText { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("layers", NullValueHandling = NullValueHandling.Ignore)]
        public object[] Layers { get; set; }
    }

    public partial class PromotionalTextPackageOverseas
    {
        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public partial class MarketingPopUpMarketingPopUpOverseas
    {
        [JsonProperty("id")]
        
        public long Id { get; set; }

        [JsonProperty("content")]
        public ContentOverseasPackage Content { get; set; }

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

    public partial class ContentOverseasPackage
    {
        [JsonProperty("image")]
        public string Image { get; set; }
    }

    public partial class MediumBannerOverseas
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

    public partial class TopBannersOverseasPackage
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

}
