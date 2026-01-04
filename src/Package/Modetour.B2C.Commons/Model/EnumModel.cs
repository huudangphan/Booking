using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Commons.Model
{
    public class EnumModel
    {
        public enum RelatedProductFilter
        {
            /// <summary>
            /// lower_price
            /// </summary>
            lower_price,
            /// <summary>
            /// popular_same_region
            /// </summary>
            popular_same_region,
            /// <summary>
            /// departure_confirmed
            /// </summary>
            departure_confirmed,
            /// <summary>
            /// air_better
            /// </summary>
            air_better,
            /// <summary>
            /// hotel_better
            /// </summary>
            hotel_better,
            /// <summary>
            /// free_schedules
            /// </summary>
            free_schedules,
            /// <summary>
            /// tourist_spots
            /// </summary>
            tourist_spots,
            /// <summary>
            /// many_meals
            /// </summary>
            many_meals,
            /// <summary>
            /// hotel_style
            /// </summary>
            hotel_style,
            /// <summary>
            /// more_inclusions
            /// </summary>
            more_inclusions,
            /// <summary>
            /// short_schedule
            /// </summary>
            short_schedule,
            /// <summary>
            /// longer_schedule
            /// </summary
            longer_schedule,
            /// <summary>
            /// no_additional_charge
            /// </summary>
            no_additional_charge,
            /// <summary>
            /// additional_charge
            /// </summary>
            additional_charge,
        }
    }
}
