using ApiRepositories.General;
using ApiUnitOfWork.General;

namespace ApiDataAccess.General
{
    public class UnitOfWork : IUnitOfWork
    {
        public IQueryRepository IQuery { get; set; }
        public ICommandRepository ICommand { get; set; }
        public UnitOfWork(string connectionString) 
        {
            IQuery = new QueryRepository(connectionString);
            ICommand = new CommandRepository(connectionString);
        }
    }
}
