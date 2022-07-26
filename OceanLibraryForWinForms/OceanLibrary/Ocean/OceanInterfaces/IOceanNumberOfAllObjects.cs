namespace OceanLibrary.Ocean.OceanInterfaces
{
    public interface IOceanNumberOfAllObjects : IOceanIndexer
    {
        int NumObstacles { get; set; }
        int NumPredators { get; set; }
        int NumPrey { get; set; }
        int NumKillerWhales { get; set; }
    }
}
