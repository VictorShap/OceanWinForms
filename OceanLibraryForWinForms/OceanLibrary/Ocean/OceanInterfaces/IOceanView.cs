namespace OceanLibrary.Ocean.OceanInterfaces
{
    public interface IOceanView : IOceanNumberOfAllObjects, IOceanLength
    {
        int CurrentIteration { get; }
        
        void Run();
    }
}
