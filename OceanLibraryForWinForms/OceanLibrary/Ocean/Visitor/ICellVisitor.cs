using OceanLibrary.Ocean.CellTypes;

namespace OceanLibrary.Ocean.Visitor
{
    public interface ICellVisitor
    {
        void Visit(Cell cell);
    }
}
