using System.Configuration;

namespace FirstCentral.Settings.FocusSettings
{
    public static class StoredProcs
    {
        public static string GetPolicyByPolicyKey
        {
            get
            {
                var getByPolicyKey = ConfigurationManager.AppSettings["GET_Policy_ByPolicyKey"];
                return getByPolicyKey;
            }
        }
    }
}
