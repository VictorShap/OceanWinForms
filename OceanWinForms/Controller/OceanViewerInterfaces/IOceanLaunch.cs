namespace OceanWinForms.UI.OceanViewerInterfaces
{
    public interface IOceanLaunch
    {
        AutoResetEvent AutoResetEvent { get; }

        bool IsDone { get; }

        void DisplayValidationMessage(bool wasFormatException);

        Task Launch();
    }
}
