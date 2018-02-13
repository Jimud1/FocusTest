namespace FirstCentral.Data.FocusData
{
    public interface IRepository
    {
        ApplicationDbContext ApplicationDbContext { get; }
        DatafixContext DatafixContext { get; }
    }
}
