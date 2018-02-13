using FirstCentral.Data.Entities.Focus;
using FirstCentral.Settings.FocusSettings;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;

namespace FirstCentral.Data.FocusData
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DatafixContext : DbContext
    {
        public DatafixContext()
            : base(Config.DatafixConnectionString)
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        /// <summary>
        /// Calls Stored Procedure named in the config as GET_Policy_ByPolicyKey
        /// </summary>
        /// <param name="policyKey"></param>
        /// <returns></returns>
        public virtual PolicyEntity GetPolicyByPolicyKey(string policyKey)
        {
            try
            {
                var policyKeyParam = new SqlParameter("@PolicyKey", policyKey);
                var toReturn = Database.SqlQuery<PolicyEntity>(Config.GetPolicyByPolicyKey, policyKeyParam).FirstOrDefault();
                return toReturn;
            }
            catch(SqlException sql)
            {
                throw sql;
            }
        }
    }
}
