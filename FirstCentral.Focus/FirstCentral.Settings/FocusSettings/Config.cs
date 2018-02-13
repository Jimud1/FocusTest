namespace FirstCentral.Settings.FocusSettings
{
    public static class Config
    {
        public static string DefaultConnectionString
        {
            get
            {
                return ConnectionStrings.DefaultConnectionString;
            }
        }

        public static string DatafixConnectionString
        {
            get
            {
                return ConnectionStrings.DatafixConnectionString;
            }
        }
        public static string GetPolicyByPolicyKey
        {
            get
            {
                return StoredProcs.GetPolicyByPolicyKey;
            }
        }
    }
}
