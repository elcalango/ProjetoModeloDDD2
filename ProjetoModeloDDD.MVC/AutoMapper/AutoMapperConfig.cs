using AutoMapper; 

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappins()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }
}