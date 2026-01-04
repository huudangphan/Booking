using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Entity.Package
{
    public class ProductPriceViewModel
    {
        /// <summary>
        /// 판매가_어른
        /// </summary>
        public int SellingPrice_Adult { get; set; }
        public int SellingPrice_Toddler { get; set; }

        public int SellingPrice_Land { get; set; }
        public long AddFare_SingleRoom { get; set; }
        /// <summary>
        /// 판매가_소아N
        /// </summary>
        public int SellingPrice_Kid_N { get; set; }
        /// <summary>
        /// 판매가_소아E
        /// </summary>
        public int SellingPrice_Kid_E { get; set; }
        /// <summary>
        /// 유류할증료_어른
        /// </summary>
        public long FuelSurchargeFee_Adult { get; set; }
        /// <summary>
        /// 유류할증료_소아N
        /// </summary>
        public long FuelSurchargeFee_Kid_N { get; set; }
        /// <summary>
        /// 유류할증료_소아E
        /// </summary>
        public long FuelSurchargeFee_Kid_E { get; set; }
        /// <summary>
        /// 유류할증료_유아
        /// </summary>
        public long FuelSurchargeFee_Toddler { get; set; }
        /// <summary>
        /// 제세공과금_어른
        /// </summary>
        public long PublicFacilitiesTax_Adult { get; set; }
        /// <summary>
        /// 제세공과금_소아N
        /// </summary>
        public long PublicFacilitiesTax_Kid_N { get; set; }
        /// <summary>
        /// 제세공과금_소아E
        /// </summary>
        public long PublicFacilitiesTax_Kid_E { get; set; }
        /// <summary>
        /// 제세공과금_유아
        /// </summary>
        public long PublicFacilitiesTax_Toddler { get; set; }

        /// <summary>
        /// 현지필수경비여부
        /// </summary>
        public string LocalRequiredExpenseOrNot { get; set; }
        /// <summary>
        /// 현지필수경비
        /// </summary>
        public long LocalRequiredExpense { get; set; }
    }
}
