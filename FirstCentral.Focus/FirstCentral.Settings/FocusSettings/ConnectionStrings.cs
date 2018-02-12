using System.Configuration;

namespace FirstCentral.Settings.FocusSettings
{
    public static class ConnectionStrings
    {
        public static string DefaultConnectionString
        {
            get
            {
                var defaultConnection = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
                return defaultConnection;
            }
        }
    }
}
