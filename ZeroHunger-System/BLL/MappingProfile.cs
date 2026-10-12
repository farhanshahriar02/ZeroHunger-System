using AutoMapper;
using BLL.Models;
using DAL.EF.Tables;

namespace BLL
{
    public class MappingProfile : Profile
    {
        public MappingProfile () { 
       
        CreateMap <Restaurant,RestaurantModel>().ReverseMap ();
            CreateMap<Employee, EmployeeModel>().ReverseMap();
            CreateMap<Distribution, DistributionModel>().ReverseMap();
            CreateMap<CollectRequest, CollectRequestModel>().ReverseMap();





        }

    }
}
