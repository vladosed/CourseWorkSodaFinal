using System;
using System.Collections.Generic;

namespace CourseWorkSoda
{
    class TrainModel
    {
        List<Carriage> carriageCollection;
        private int trainLength = 0;
        public int TrainLength
        {
            get { return trainLength; }
        }
        private string[] carriageTypes = { "спальный вагон", "плацкартный вагон", "купейный вагон" };

        /// <summary>
        /// Проверяет наличие свободного места numPlace в вагоне numVagon
        /// </summary>
        public bool FreePlace(int numVagon, int numPlace)
        {
            return carriageCollection[numVagon].FreePlace(numPlace);
        }
        /// <summary>
        /// Заполняет место в вагоне поезда пассажиром
        /// </summary>
        public void OnPlace(int numVagon, int numPlace, string passanger)
        {
            carriageCollection[numVagon].OnPlace(numPlace, passanger);
        }
        /// <summary>
        /// Добавление в структуру поезда нового вагона типа type
        /// </summary>
        private void AddCarriage(int type)
        {
            byte indicator = 0;// реальный счетчик вагонов
            if (type == 0)
            {
                ++indicator;
                carriageCollection.Add(new Carriage(type));
                for (int k = 0; k <= indicator; k++)
                {
                    if (k == indicator)
                        Console.WriteLine("Добавлен {0} {1}.", k, carriageTypes[0]);
                }
            }
            if (type == 1)
            {
                ++indicator;
                carriageCollection.Add(new Carriage(type));
                for (int k = 0; k <= indicator; k++)
                {
                    if (k == indicator)
                        Console.WriteLine("Добавлено {0} {1}.", k, carriageTypes[1]);
                }
            }
            if (type == 2)
            {
                ++indicator;
                carriageCollection.Add(new Carriage(type));
                for (int k = 0; k <= indicator; k++)
                {
                    if (k == indicator)
                        Console.WriteLine("Добавлено {0} {1}.", k, carriageTypes[2]);
                }
            }
        }

        public TrainModel(int _common, int _platscart, int _coupe)
        {//конструктор класса
            carriageCollection = new List<Carriage>();
            trainLength += _common;
            for (var i = 1; i <= _common; i++) AddCarriage(0);
            trainLength += _platscart;
            for (var i = 1; i <= _platscart; i++) AddCarriage(1);
            trainLength += _coupe;
            for (var i = 1; i <= _coupe; i++) AddCarriage(2);
        }

    }

}
