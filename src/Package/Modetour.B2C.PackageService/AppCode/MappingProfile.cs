using AutoMapper;
using Modetour.B2C.Entity.Package;
using Modetour.B2C.Entity.Package.Package.Json;
using Modetour.B2C.Entity.Package.Package.PackageXml;
using Modetour.B2C.Entity.Package.Package.TravelCore;
using Modetour.B2C.Entity.Package.TravelCore;
using Modetour.Configs.DB;
using ModetourB2C.Dac.Model.MODEWARE3;
using ModetourB2C.Dac.Model.MODEWARE3.Package;
using ModetourB2C.Dac.Model.MODEWEB3;
using ModetourB2C.Dac.Model.NEWEAGLE3;

namespace Modetour.B2C.Package.AppCode
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region package mapping

            CreateMap<WSP_S_ScheduleTable.Result1, ProductPriceViewModel>();
            CreateMap<WSP_S_ScheduleTable.Result1, ProductPriceViewModel>().ReverseMap();

            CreateMap<WSP_S_ScheduleTable.Result1, TravelScheduleViewModel>();
            CreateMap<WSP_S_ScheduleTable.Result1, TravelScheduleViewModel>().ReverseMap();

            CreateMap<WSP_S_ScheduleTable.Result1, ProductInfoViewModel>();
            CreateMap<WSP_S_ScheduleTable.Result1, ProductInfoViewModel>().ReverseMap();

            CreateMap<WSP_S_ScheduleTable.Result1, MeetingPlaceViewModel>();
            CreateMap<WSP_S_ScheduleTable.Result1, MeetingPlaceViewModel>().ReverseMap();

            CreateMap<WSP_S_ScheduleTable.Result4, PlaceViewModel>();
            CreateMap<WSP_S_ScheduleTable.Result4, PlaceViewModel>().ReverseMap();

            CreateMap<WSP_S_CMN_GroupReservationFinish.Result4, ProductReservationData>();
            CreateMap<WSP_S_CMN_GroupReservationFinish.Result4, ProductReservationData>().ReverseMap();

            CreateMap<WSP_S_CMN_GroupReservationFinish.Result5, ProductReservationData>();
            CreateMap<WSP_S_CMN_GroupReservationFinish.Result5, ProductReservationData>().ReverseMap();

            CreateMap<WSP_S_CMN_GroupReservationFinish.Result1, OrderReservationData>();
            CreateMap<WSP_S_CMN_GroupReservationFinish.Result1, OrderReservationData>().ReverseMap();

            CreateMap<WSP_S_CMN_TravelReview_List.Result1, ReiviewItem>();
            CreateMap<WSP_S_CMN_TravelReview_List.Result1, ReiviewItem>().ReverseMap();


            CreateMap<WSP_S_CMN_GroupReservationFinish.Result2, SubscriberData>();
            CreateMap<WSP_S_CMN_GroupReservationFinish.Result2, SubscriberData>().ReverseMap();

            CreateMap<WSP_S_CMN_GroupReservationFinish.Result5, SangPumData>();
            CreateMap<WSP_S_CMN_GroupReservationFinish.Result5, SangPumData>().ReverseMap();

            CreateMap<WSP_S_CMN_GroupReservationFinish.Result6, InChargeData>();
            CreateMap<WSP_S_CMN_GroupReservationFinish.Result6, InChargeData>().ReverseMap();

            CreateMap<WSP_S_CMN_GroupReservationFinish.Result6, InChargeData>();
            CreateMap<WSP_S_CMN_GroupReservationFinish.Result6, InChargeData>().ReverseMap();

            CreateMap<USP_S_Sale_MemberInfo_01.Result1, MileageTourInfoWithNoPTId>();
            CreateMap<USP_S_Sale_MemberInfo_01.Result1, MileageTourInfoWithNoPTId>().ReverseMap();

            CreateMap<USP_S_Sale_MemberInfo_01.Result2, MileageTourInfoWithPTId>();
            CreateMap<USP_S_Sale_MemberInfo_01.Result2, MileageTourInfoWithPTId>().ReverseMap();

            CreateMap<IEnumerable<WSP_S_CMN_GroupList.Result3>, IEnumerable<GroupItem>>();
            CreateMap<IEnumerable<WSP_S_CMN_GroupList.Result3>, IEnumerable<GroupItem>>().ReverseMap();

            CreateMap<WSP_S_ScheduleTable_GuideInfo.Result, GuildInfoModel>();
            CreateMap<WSP_S_ScheduleTable_GuideInfo.Result, GuildInfoModel>().ReverseMap();
          

            CreateMap<PlaceModel.Result, TourScheduleItemModel>();

            CreateMap<WSP_S_EachCountry_ExchangeRate.Result, UsdExchange>();
            #endregion
        }
    }
}
