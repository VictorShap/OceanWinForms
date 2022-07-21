using OceanWinForms.Controller.Delegates;

namespace OceanWinForms.UI.OceanViewerInterfaces
{
    public interface IOceanLaunch
    {
        AutoResetEvent AutoResetEvent { get; }

        event OceanSimulationEventHandler OceanSimulationFinished;

        event OceanSimulationEventHandler OceanHasBeenDeleted;

        event OceanSimulationEventHandler OceanHasBeenPaused;

        event OceanSimulationEventHandler OceanHasBeenResumed;

        void DisplayValidationMessage(bool wasFormatException);

        Task Launch();
    }
}
