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
        private int _preyEaten;
        protected int _timeToFeed; // the number of iterations after which the predator dies
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
        public override void Process()
        {
            if (_preyEaten == 2)
            {
                _owner.NumPredators--;
                _owner.NumKillerWhales++;
                _owner[Offset] = new KillerWhale(Offset, _owner);

                return;
            }
            else if (--_timeToFeed <= 0)
            {
                _owner.NumPredators = _owner.NumPredators - 1;
                _owner[Offset] = null;
            }
            else
            {
                ProcessForChild();
            }
        }

        protected void ProcessForChild()
        {
            Coordinate toCoordinate;

            toCoordinate = _owner.GetNeighborPreyCoord(Offset);

            if (toCoordinate != Offset)
            {
                _owner.NumPrey = _owner.NumPrey - 1;
                _timeToFeed = TimeToFeedDefault;
                _timeToReproduce = _timeToReproduce - 1;
                _preyEaten++;

                _owner.MoveFrom(Offset, toCoordinate);
            }
            else
            {
                base.Process();
            }
        }

        protected override Cell Reproduce(Coordinate coordinate)
        {
            if (coordinate != Offset)
            {
                _owner.NumPredators = _owner.NumPredators + 1;
            }

            return new Predator(coordinate, _owner);
        }
        #endregion
    }
}
