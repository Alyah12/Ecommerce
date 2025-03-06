namespace Aplication.Notification;

public interface INotificationError
{
    void Handle (NotificationMessageError notificationError);
    List<NotificationMessageError> GetNotifications();
    bool HasNotifications();
}