namespace AthleteManagementSystem.Framework.Domain.ApplicationServices
{
    public interface CommandHandler<TCommand>
    {
        Task Handle(TCommand command);
    }
}
