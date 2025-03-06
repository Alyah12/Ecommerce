namespace Aplication.Notification;

public class NotificationMessageError
{
    public NotificationMessageError(string message, string? field = null, string code = "VALIDATION_ERROR")
    {
        Message = message;
        Field = field;
        Code = code;
    }

    public string Message { get; set; }
    public string? Field { get; set; }
    public string Code { get; set; }
}