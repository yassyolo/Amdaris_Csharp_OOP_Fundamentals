using Assessment10.Email;
using Assessment10.Loggers;

namespace Assessment10.Facade
{
    internal class LogAndSendEmailFacade
    {
        private List<ILogger> _loggers;
        private IEmailService _emailService;

        public LogAndSendEmailFacade(List<ILogger> loggers, IEmailService emailService)
        {
            _loggers = loggers;
            _emailService = emailService;
        }

        public void LogAndSendEmail(string message, string to, string subject)
        {
            _loggers.ForEach(logger => logger.Log(message));
            _emailService.SendEmail(to, subject);
        }
    }
}
