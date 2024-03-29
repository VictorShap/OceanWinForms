﻿using OceanLibrary.Ocean.CellTypes.Structs;
using OceanLibrary.Ocean.OceanInterfaces;

namespace OceanLibrary.Util
{
    internal class RandomNumberGenerator
    {
        #region Readonly
        private readonly Random _random; // field for generating random numbers
        private readonly IOceanLength _ocean; // field for interacting with the ocean
        #endregion

        #region Ctors
        public RandomNumberGenerator(IOceanLength ocean)
        {
            _random = new Random();
            _ocean = ocean;
        }
        #endregion

        #region Properties
        public Random Random { get { return _random; } }
        #endregion

        #region Methods
        public Coordinate GetEmptyCellCoord()
        {
            int x, y;

            do
            {
                x = _random.Next(0, _ocean.NumRows);
                y = _random.Next(0, _ocean.NumColumns);
            }
            while (_ocean[x, y] != null);

            return new Coordinate(x, y);
        }
        #endregion
    }
}
