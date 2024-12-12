using AutoMapper;
using ProjectN.Models;
using ProjectN.Parameter;
using ProjectN.Service.Dtos.Info;
using ProjectN.Service.Dtos.ResultModel;

namespace ProjectN.Mappings
{
    public class ControllerMappings: Profile
    {
        public ControllerMappings()
        {
            // Parameter -> Info
            this.CreateMap<CardParameter, CardInfo>();
            this.CreateMap<CardSearchParameter, CardSearchInfo>();

            // ResultModel -> ViewModel
            this.CreateMap<CardResultModel, CardViewModel>();
        }
    }
}
