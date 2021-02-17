using DesconstruindoImaginariosAPI.Data;
using DesconstruindoImaginariosAPI.Repository.Abstract;>
using System.Reflection;

namespace DesconstruindoImaginariosAPI.Repository.Concrete
{
    public class ModuleRepository : RepositoryBase<Module>, IModuleRepository
    {
        public ModuleRepository(DataContext context) : base(context) { }
    }
}
