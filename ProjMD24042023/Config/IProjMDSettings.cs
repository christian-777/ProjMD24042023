namespace ProjMD24042023.Config
{
    public interface IProjMDSettings
    {
        string ClientCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
