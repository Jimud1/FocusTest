using FirstCentral.Data.Entities.Focus;
using FirstCentral.Settings.FocusSettings;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;

namespace FirstCentral.Data.FocusData
{
    public partial class DatafixContext : DbContext
    {
        public DatafixContext()
            : base(Config.DatafixConnectionString)
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public virtual PolicyEntity Datafix_Policy_GET(string policyKey)
        {
            var policyKeyParam = new SqlParameter("PolicyKey", policyKey);
            var toReturn = Database.SqlQuery<PolicyEntity>("Datafix_Policy_GET @PolicyKey", policyKeyParam).FirstOrDefault();
            return toReturn;
        }
    }
}
