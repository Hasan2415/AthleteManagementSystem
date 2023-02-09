namespace AthleteManagementSystem.Framework.Domain.Data
{
    public interface UnitOfWork
    {
        public Task Complete();
    }
}
