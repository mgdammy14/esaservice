using ApiRepositories.General;

namespace ApiUnitOfWork.General
{
    public interface IUnitOfWork
    {
        public IQueryRepository IQuery { get; set; }
        public ICommandRepository ICommand { get; set; }
    }
}
