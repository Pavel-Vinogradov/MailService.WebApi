namespace MailService.WebApi.Settings
{
    public interface IMailSettings
    {
        public string Mail { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }

        public string VacanciesMail { get; set; }

        public string CallBackMail { get; set; }
    }
}
