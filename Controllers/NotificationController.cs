using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotificationApi.Services.NotificationService;

namespace NotificationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpGet]
        public async Task<ActionResult<List<NotificationModel>>> GetAllData()
        {
            var result = await _notificationService.GetAllData();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<NotificationModel>>> AddData (NotificationModel data)
        {
            var result = await _notificationService.AddData(data);
            return Ok(result);
        }

    }
}
