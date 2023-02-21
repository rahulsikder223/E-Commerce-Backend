using Discount.Grpc.Entities;
using Discount.Grpc.Protos;
using AutoMapper;

namespace Discount.Grpc.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Coupon, CouponModel>().ReverseMap();
        }
    }
}
