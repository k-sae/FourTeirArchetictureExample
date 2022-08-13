using FourTierArchitectureExample.Domain.Notifications.Models;
using FourTierArchitectureExample.Domain.Users.Models;

namespace FourTierArchitectureExample.Domain.Notifications.Services;

public interface INotificationService
{
    public  Task<Notification> CreateNotificationForUser(User user, Notifications.Models.Notification notification);
}
public class NotificationService : INotificationService
{
    
    public Task<Notification> CreateNotificationForUser(User user, Notifications.Models.Notification notification)
    {
        throw new NotImplementedException();
    }
}