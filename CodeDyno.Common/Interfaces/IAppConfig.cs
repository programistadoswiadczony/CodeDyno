using CodeDyno.Common.Configuration;

namespace CodeDyno.Common.Interfaces
{
    public interface IAppConfig
    {
        IRepositoryConfig RepositoryConfig { get; }
        IDatabaseConfig DatabaseConfig { get; }
    }
}