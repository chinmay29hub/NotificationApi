using Microsoft.EntityFrameworkCore;

namespace NotificationApi.Services.NotificationService
{
    public class NotificationService : INotificationService
    {
        private readonly DataContext _context;

        public NotificationService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<NotificationModel>> GetAllData ()
        {
            return await _context.NotificationData.ToListAsync();
        }

        public async Task<List<NotificationModel>> AddData(NotificationModel data)
        {
            _context.NotificationData.Add(data);
            await _context.SaveChangesAsync();

            return await _context.NotificationData.ToListAsync();
        }
    }
}
