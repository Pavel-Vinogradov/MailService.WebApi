using MailService.WebApi.Models;
using MailService.WebApi.Services;
using MailService.WebApi.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace MailService.WebApi.Controllers
{
    [Route("action/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        private readonly IMailService _mailService;
        private readonly IMailSettings _mailSettings;
        private readonly ILogger<MailController> _logger;

        public MailController(
        IMailService mailService,
        IMailSettings mailSettings,
        ILogger<MailController> logger)
        {
            _mailService = mailService;
            _mailSettings = mailSettings;
            _logger = logger;
        }

        [HttpGet("test")]
        public async Task<IActionResult> Test()
        {

            return Ok("Привет");
        }
        
        [HttpPost("send")]
        public async Task<IActionResult> SendMail([FromBody] MailRequest request)
        {
            
            try
            {
                request.ToEmail = _mailSettings.VacanciesMail;
                await _mailService.SendEmailAsync(request);
               
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return StatusCode(500);
            }
        }

        [HttpPost("sendCallBack")]
        public async Task<IActionResult> SendCallBackMail([FromForm] MailRequest request)
        {
            
            try
            {
                request.ToEmail = _mailSettings.CallBackMail;
                await _mailService.SendEmailAsync(request);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return StatusCode(500);
            }
        }

    }
}