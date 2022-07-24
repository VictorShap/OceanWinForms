using OceanWinForms.Controller.Delegates;

namespace OceanWinForms.UI.OceanViewerInterfaces
{
    public interface IOceanLaunch
    {
        AutoResetEvent AutoResetEvent { get; }

        event OceanRemoveEventHandler OceanSimulationFinished;

        event OceanRemoveEventHandler OceanHasBeenDeleted;

        event OceanUserSuspendEventHandler OceanHasBeenPaused;

        event OceanUserSuspendEventHandler OceanHasBeenResumed;

        void DisplayValidationMessage(bool wasFormatException);

        Task Launch();
    }
}
