using Microsoft.Extensions.Configuration;

namespace MailService.WebApi.Settings
{
    public class MailSettings : IMailSettings
    {
        public string Mail { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }

        public string VacanciesMail { get; set; }

        public string CallBackMail { get; set; }

        public MailSettings(IConfiguration configuration)
        {
            Mail = configuration.GetSection("MailSettings:Mail").Value;
            Login = configuration.GetSection("MailSettings:Login").Value;
            Password = configuration.GetSection("MailSettings:Password").Value;
            Host = configuration.GetSection("MailSettings:Host").Value;
            Port = int.Parse(configuration.GetSection("MailSettings:Port").Value);
            VacanciesMail = configuration.GetSection("MailSettings:VacanciesMail").Value;
            CallBackMail = configuration.GetSection("MailSettings:CallBackMail").Value;
        }
    }
}