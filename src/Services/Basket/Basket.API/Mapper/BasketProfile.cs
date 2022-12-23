using AutoMapper;
using Basket.API.Entities;
using EventBus.Messages.Events;
using System.Runtime.ConstrainedExecution;

namespace Basket.API.Mapper
{
    public class BasketProfile : Profile
    {
        public BasketProfile()
        {
            CreateMap<BasketCheckout, BasketCheckoutEvent>().ReverseMap();
        }
    }
}
