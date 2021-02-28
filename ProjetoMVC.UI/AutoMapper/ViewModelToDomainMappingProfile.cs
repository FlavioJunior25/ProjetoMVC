using AutoMapper;
using ProjetoMVC.Domain.Entities;
using ProjetoMVC.UI.ViewModels;

namespace ProjetoMVC.UI.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {

        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Cliente, ClienteViewModel>();
        }
    }
}