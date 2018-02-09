namespace FirstCentral.Data.FocusData
{
    /// <summary>
    /// 
    /// </summary>
    public class Repository : IRepository
    {
        /// <summary>
        /// 
        /// </summary>
        public Repository()
        {
            //Lazy way will do for now
            _applicationDbContext = new ApplicationDbContext();
        }

        private ApplicationDbContext _applicationDbContext;
        public ApplicationDbContext ApplicationDbContext => _applicationDbContext;
    }
}
