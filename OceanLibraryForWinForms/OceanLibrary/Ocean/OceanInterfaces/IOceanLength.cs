namespace OceanLibrary.Ocean.OceanInterfaces
{
    public interface IOceanLength : IOceanIndexer
    {
        int NumColumns { get; }
        int NumRows { get; }
    }
}
