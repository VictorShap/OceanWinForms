using OceanLibrary.Ocean.CellTypes.Structs;

namespace OceanLibrary.Ocean.OceanInterfaces
{
    public interface IOcean : IOceanNumberOfAllObjects
    {
        Coordinate GetNeighborPreyCoord(Coordinate currentCoordinate);

        Coordinate GetEmptyNeighborCoord(Coordinate currentCoordinate);

        Coordinate GetNeighborPredatorCoord(Coordinate currentCoordinate);

        void MoveFrom(Coordinate from, Coordinate to);
    }
}
