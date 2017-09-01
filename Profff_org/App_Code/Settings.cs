using System.Configuration;

namespace Profff_org
{
    public static class Settings
    {

        #region SMTP - MAIL

        public static string MailFrom
        {
            get
            {
                return ConfigurationManager.AppSettings["MailFrom"];
            }
        }

        public static string MailTo
        {
            get
            {
                return ConfigurationManager.AppSettings["MailTo"];
            }
        }

        public static string SmtpServer
        {
            get
            {
                return ConfigurationManager.AppSettings["SmtpServer"];
            }
        }

        public static string MailUsername
        {
            get
            {
                return  ConfigurationManager.AppSettings["MailUsername"];
            }
        }

        public static string MailPassword
        {
            get
            {
                return ConfigurationManager.AppSettings["MailPassword"];
            }
        }

        #endregion

    }
}