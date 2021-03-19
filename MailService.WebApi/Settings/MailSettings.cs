using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace MailService.WebApi.Settings
{
    public class MailSettings
    {
        public string Mail { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        
        public  string VacanciesMail { get; set; }
        
        public  string CallBackMail { get; set; }
    }
}