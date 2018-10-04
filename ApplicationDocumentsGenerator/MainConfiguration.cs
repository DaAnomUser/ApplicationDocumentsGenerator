using System.Configuration;

namespace ApplicationDocumentsGenerator
{
    public class MainConfiguration
    {
        public static string SmtpServer
        {
            get
            {
                return ConfigurationManager.AppSettings[nameof(SmtpServer)];
            }
            set
            {
                ConfigurationManager.AppSettings[nameof(SmtpServer)] = value;
            }
        }

        public static string SmtpPort
        {
            get
            {
                return ConfigurationManager.AppSettings[nameof(SmtpPort)];
            }
            set
            {
                ConfigurationManager.AppSettings[nameof(SmtpPort)] = value;
            }
        }

        public static string SmtpUsername
        {
            get
            {
                return ConfigurationManager.AppSettings[nameof(SmtpUsername)];
            }
            set
            {
                ConfigurationManager.AppSettings[nameof(SmtpUsername)] = value;
            }
        }

        public static string SmtpPassword
        {
            get
            {
                return ConfigurationManager.AppSettings[nameof(SmtpPassword)];
            }
            set
            {
                ConfigurationManager.AppSettings[nameof(SmtpPassword)] = value;
            }
        }

        public static string ExcelColumnNameForEmailAddress
        {
            get
            {
                return ConfigurationManager.AppSettings[nameof(ExcelColumnNameForEmailAddress)];
            }
            set
            {
                ConfigurationManager.AppSettings[nameof(ExcelColumnNameForEmailAddress)] = value;
            }
        }
    }
}
