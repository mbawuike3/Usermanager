
using UserEmailService.Models;

namespace UserEmailService.Services
{
    public interface IEmailService
    {
        void SendEmail(Message message);
    }
}
