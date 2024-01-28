using AutoMapper;
using ConcertBooking.UI.ViewModels.ConvertViewModel;
using ConcertBooking.UI.ViewModels.VenueViewModel;
using ConcertBooking.Entities;

namespace ConcertBooking.UI.Mapper
{
    public class AutoMapperProfile :  Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Venue, VenueViewModel>();
            CreateMap<CreateVenueViewModel, Venue>();
            CreateMap<VenueViewModel, Venue>();

            CreateMap<Concert, ConcertViewModel>();
            CreateMap<CreateConcertViewModel, Concert>();
            CreateMap<ConcertViewModel, Concert>()
                .ForMember(dest=>dest.ID,opt=>opt.MapFrom(src=>src.VenueID));
        }
    }
}