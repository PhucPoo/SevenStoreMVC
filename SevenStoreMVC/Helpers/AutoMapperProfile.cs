using AutoMapper;
using SevenStoreMVC.Data;
using SevenStoreMVC.ViewModels;

namespace SevenStoreMVC.Helpers
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<RegisterVM, KhachHang>().ForMember(kh => kh.HoTen, option => option.MapFrom(RegisterVM => RegisterVM.HoTen)).ReverseMap();
        }
    }
}
