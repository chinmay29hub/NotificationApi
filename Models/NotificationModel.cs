namespace NotificationApi.Models
{
    public class NotificationModel
    {
        public int Id { get; set; }
        public int Credits { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Place { get; set; } = string.Empty;
    }
}
