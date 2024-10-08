﻿using AutoMapper;
using EventBus.Messages.Events;
using Ordering.Application.Features.Commands.CheckoutOrder;

namespace Ordering.API.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CheckoutOrderCommand, BasketCheckoutEvent>().ReverseMap();
        }
    }
}
