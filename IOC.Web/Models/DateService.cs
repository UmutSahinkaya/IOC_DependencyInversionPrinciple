
namespace IOC.Web.Models;

public class DateService : ISingletonDateService, IScopedDateService, ITransientDateService
{
    private readonly ILogger<DateService> _logger;

    public DateService(ILogger<DateService> logger)
    {
        _logger = logger;
        _logger.LogWarning("DateService ctor'a girdi.");
    }

    public DateTime GetDateTime { get; } = DateTime.Now;
}
