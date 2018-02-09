using System.Configuration;

namespace FirstCentral.Settings.FocusSettings
{
    public static class ConnectionStrings
    {
        public static string DefaultConnectionString { get { return ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString(); } }
    }
}
