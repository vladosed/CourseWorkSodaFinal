using System;
namespace CourseWorkSoda
{
    class PlaceInTheTrain
    {
        int place;
        public string Passenger { get; set; }
        /// <summary>
        /// Инициализация нового места для пассажира
        /// </summary>
        public PlaceInTheTrain()
        {
            place = 0;
            Passenger = String.Empty;
        }

    }

}
