namespace FirstCentral.Data.FocusData
{
    /// <summary>
    /// Repository
    /// </summary>
    public class Repository : IRepository
    {
        /// <summary>
        /// 
        /// </summary>
        public Repository() {}

        /// <summary>
        /// Application Db for accounts, etc
        /// </summary>
        private ApplicationDbContext _applicationDbContext;
        public ApplicationDbContext ApplicationDbContext => _applicationDbContext ?? (_applicationDbContext = new ApplicationDbContext());

        /// <summary>
        /// Datafix Db which I will be using for this demo
        /// </summary>
        private DatafixContext _datafixContext;
        public DatafixContext DatafixContext => _datafixContext ?? (_datafixContext = new DatafixContext());
    }
}
