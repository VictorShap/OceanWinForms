using OceanLibrary.Ocean.CellTypes.Structs;
using OceanLibrary.Ocean.OceanInterfaces;

namespace OceanLibrary.Ocean.CellTypes
{
    public class Obstacle : Cell
    {
        #region Ctors
        public Obstacle(Coordinate coordinate, IOcean ocean) : base(coordinate, ocean)
        {
            _image = Enums.CellType.Obstacle;
        }
        #endregion

        #region Properties
        public override Enums.CellType CellType => _image;
        #endregion

        #region Methods
        public override void Process()
        {

        }

        protected override Cell Reproduce(Coordinate coordinate)
        {
            return this;
        }
        #endregion
    }
}
