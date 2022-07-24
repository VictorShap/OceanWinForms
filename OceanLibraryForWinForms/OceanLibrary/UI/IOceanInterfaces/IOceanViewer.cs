using OceanLibrary.Ocean.UI.Enums;

namespace OceanLibrary.UI.IOceanInterfaces
{
    public interface IOceanViewer
    {
        void RequestValueAndAssign(out int numIterations,out int numObstacles,out int numPredators,out int numPrey);

        void DisplayGameState(GameState gameState);

        void DisplayIteration();

        void DisplayValidationMessage(bool wasFormatException);
    }
}
