using OceanLibrary.Ocean.CellTypes;
using OceanLibrary.Ocean.CellTypes.Structs;

namespace OceanLibrary.Ocean.OceanInterfaces
{
    public interface IOceanIndexer
    {
        Cell this[int x, int y] { get; }

        Cell this[Coordinate coordinate] { set; }
    }
}
