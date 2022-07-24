using OceanLibrary.Ocean.CellTypes.Structs;
using OceanLibrary.Ocean.OceanInterfaces;

namespace OceanLibrary.Ocean.CellTypes
{
    public class Prey : Cell
    {
        #region Consts
        private const int TimeToReproduceDefault = 6;
        #endregion

        #region Fields
        protected int _timeToReproduce; // the number of iterations after which the prey reproduces
        #endregion

        #region Ctors
        public Prey(Coordinate coordinate, IOcean ocean) : base(coordinate, ocean)
        {
            _image = Enums.CellType.Prey;
            _timeToReproduce = TimeToReproduceDefault;
        }
        #endregion

        #region Properties
        public override Enums.CellType CellType => _image;
        #endregion

        #region Methods
        protected override Cell Reproduce(Coordinate coordinate)
        {
            if (coordinate != Offset)
            {
                _owner.NumPrey = _owner.NumPrey + 1;
            }

            return new Prey(coordinate, _owner);
        }

        public override void Process()
        {
            Coordinate toCoord = _owner.GetEmptyNeighborCoord(Offset);

            if (--_timeToReproduce <= 0)
            {
                Cell redproducedCell = Reproduce(toCoord);
                _timeToReproduce = TimeToReproduceDefault;

                _owner[toCoord] = redproducedCell;
            }
            else
            {
                _owner.MoveFrom(Offset, toCoord);
            }
        }
        #endregion
    }
}
