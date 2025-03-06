namespace Aplication.Notification;

/// <summary>
/// Provides an implementation of the <see cref="INotificationError"/> interface
/// that stores and retrieves notification errors.
/// </summary>
public class NotificationError : INotificationError
{
    /// <summary>
    /// A list holding all notification errors.
    /// </summary>
    private readonly List<NotificationMessageError> _notifications = new();

    /// <summary>
    /// Adds a notification error to the internal list.
    /// </summary>
    /// <param name="notification">The notification error to be added.</param>
    public void Handle(NotificationMessageError notification)
    {
        _notifications.Add(notification);
    }

    /// <summary>
    /// Retrieves all notification errors stored in the internal list.
    /// </summary>
    /// <returns>A list of <see cref="NotificationMessageError"/> objects representing the errors.</returns>
    public List<NotificationMessageError> GetNotifications()
    {
        return _notifications;
    }

    /// <summary>
    /// Checks if any notification errors are stored.
    /// </summary>
    /// <returns><c>true</c> if at least one notification error exists; otherwise, <c>false</c>.</returns>
    public bool HasNotifications()
    {
        return _notifications.Count > 0;
    }
}