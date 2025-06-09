namespace BarberBoss.Exception;

public abstract class BarberBossException(string message) : SystemException(message)
{
    public abstract int StatusCode { get; }
    public abstract List<string> GetErrors();
};
