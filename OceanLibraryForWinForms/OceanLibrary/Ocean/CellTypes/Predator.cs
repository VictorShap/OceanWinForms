using OceanLibrary.Ocean.CellTypes.Structs;
using OceanLibrary.Ocean.OceanInterfaces;

namespace OceanLibrary.Ocean.CellTypes
{
    public class Predator : Prey
    {
        #region Consts
        private const int TimeToFeedDefault = 6;
        #endregion

        #region Fields
        private int _timeToFeed; // the number of iterations after which the predator dies
        #endregion

        #region Ctors
        public Predator(Coordinate coordinate, IOcean ocean) : base(coordinate, ocean)
        {
            _image = Enums.CellType.Predator;
            _timeToFeed = TimeToFeedDefault;
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
                _owner.NumPredators = _owner.NumPredators + 1;
            }

            return new Predator(coordinate, _owner);
        }

        public override void Process()
        {
            Coordinate toCoordinate;

            if (--_timeToFeed <= 0)
            {
                _owner.NumPredators = _owner.NumPredators - 1;
                _owner[Offset] = null;
            }
            else
            {
                toCoordinate = _owner.GetNeighborPreyCoord(Offset);

                if (toCoordinate != Offset)
                {
                    _owner.NumPrey = _owner.NumPrey - 1;
                    _timeToFeed = TimeToFeedDefault;
                    _timeToReproduce = _timeToReproduce - 1;

                    _owner.MoveFrom(Offset, toCoordinate);
                }
                else
                {
                    base.Process();
                }
            }
        }
        #endregion
    }
}
