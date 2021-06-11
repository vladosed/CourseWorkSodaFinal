using System;


namespace CourseWorkSoda
{
    class Carriage
    {
        PlaceInTheTrain[] places;
        int carriageIndex = 0;
        private const int placesInBasis = 24;// макс.количество стандарт
        private const int placesInPlatscart = 48;// макс.количество плацккарт
        private const int placesInCoupe = 36;// макс.количество купе

        public bool FreePlace(int numPlace)
        {
            return places[numPlace].Passenger == String.Empty;
        }

        public void OnPlace(int numPlace, string passanger)
        {
            places[numPlace].Passenger = passanger;
        }
        /// <summary>
        /// Заполнение вагонов пасcажирами в зависимости от type
        /// </summary>
        public Carriage(int type)
        {
            carriageIndex = type;
            if (type == 0)
            {
                places = new PlaceInTheTrain[placesInBasis];
                for (var i = 0; i < placesInBasis; i++)
                {
                    places[i] = new PlaceInTheTrain();
                }
                //places[0].Passenger = "aaa";
            }
            if (type == 1)
            {
                places = new PlaceInTheTrain[placesInPlatscart];
                for (var i = 0; i < placesInPlatscart; i++)
                {
                    places[i] = new PlaceInTheTrain();
                }
            }
            if (type == 2)
            {
                places = new PlaceInTheTrain[placesInCoupe];
                for (var i = 0; i < placesInCoupe; i++)
                {
                    places[i] = new PlaceInTheTrain();
                }
            }
        }

    }

}
