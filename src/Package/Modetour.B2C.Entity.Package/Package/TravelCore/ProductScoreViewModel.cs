using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Entity.Package
{
    public class ProductScoreViewModel
    {
        public List<string> SpecialBenefits { get; set; }
        public List<string> Sightseeings { get; set; }
        public List<string> Hotels { get; set; }
        public List<string> Meals { get; set; }
        public List<string> Golfs { get; set; }
        public string LeaderGuild { get; set; }
        public string LeaderGuildStatus { get; set; }
        public string LeaderStatus { get; set; }
        public string TourMile { get; set; }
        public string BusinessGuarantee { get; set; }
        public string TravelerInsuranceInfo { get; set; }
        public string ProductScore { get; set; } = "상품 핵심 포인트";
        public string SellingPrice { get; set; }
    }
}
