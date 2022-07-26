using OceanLibrary.Ocean.CellTypes.Structs;
using OceanLibrary.Ocean.OceanInterfaces;

namespace OceanLibrary.Ocean.CellTypes
{
    public class KillerWhale : Predator
    {
        #region Consts
        private const int TimeToFeedDefault = 9;
        private const int TimeToReproduceDefault = 12;
        #endregion

        #region Ctors
        public KillerWhale(Coordinate coordinate, IOcean ocean) : base(coordinate, ocean)
        {
            _image = Enums.CellType.KillerWhale;
            _timeToFeed = TimeToFeedDefault;
            _timeToReproduce = TimeToReproduceDefault;
        }
        #endregion

        #region Properties
        public override Enums.CellType CellType => _image;
        #endregion

        #region Methods
        public override void Process()
        {
            Coordinate toCoordinate;

            if (--_timeToFeed <= 0)
            {
                _owner.NumKillerWhales = _owner.NumKillerWhales - 1;
                _owner[Offset] = null;
            }
            else
            {
                toCoordinate = _owner.GetNeighborPredatorCoord(Offset);

                if (toCoordinate != Offset)
                {
                    _owner.NumPredators = _owner.NumPredators - 1;
                    _timeToFeed = TimeToFeedDefault;
                    _timeToReproduce = _timeToReproduce - 1;

                    _owner.MoveFrom(Offset, toCoordinate);
                }
                else
                {
                    base.ProcessForChild();
                }
            }
        }

        protected override Cell Reproduce(Coordinate coordinate)
        {
            if (coordinate != Offset)
            {
                _owner.NumKillerWhales = _owner.NumKillerWhales + 1;
            }

            return new KillerWhale(coordinate, _owner);
        }
        #endregion
    }
}
