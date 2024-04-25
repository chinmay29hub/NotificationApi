namespace NotificationApi.Services.NotificationService
{
    public interface INotificationService
    {
        Task<List<NotificationModel>> GetAllData();
        Task<List<NotificationModel>> AddData(NotificationModel data);
    }
}
