namespace OceanWinForms.UI.OceanViewerInterfaces
{
    public interface IOceanLaunch
    {
        AutoResetEvent AutoResetEvent { get; }

        bool IsDone { get; }

        Task Launch();
    }
}
