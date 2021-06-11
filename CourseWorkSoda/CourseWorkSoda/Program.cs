using System;

namespace CourseWorkSoda
{
    class Program
    {
        static TrainModel train;
        private static int numVagon = 0;
        private static int placeNumber = 0;
        private static string passangerName = default(string);
        /// <summary>
        /// Инициализирует начало вычислений
        /// </summary>
        static void Main(string[] args)
        {
            string selectTrain = default(string);
            Console.Write(">Предже чем заказать место в поезде, пожалуйста, " +
                 "выберите класс пассажирского поезда из списка ниже:\n");
            Console.WriteLine(@"Поезд класса стандарт - для выбора нажмите ""1""или ""с""(стандарт) или""s""(standart).");
            Console.WriteLine(@"Поезд комфорт-класса - для выбора нажмите ""2"" или ""к""(комфорт) или ""c""(comfort).");
            Console.WriteLine(@"Поезд премиум-класса - для выбора нажмите ""3"" или ""п""(премиум) или ""p""(premium).");
        label1:
            selectTrain = Console.ReadLine();
            switch (selectTrain)
            {
                case "1":
                case "s":
                case "standart":
                case "с":
                case "стандарт":
                    {
                        Console.Clear();
                        train = new TrainModel(5, 3, 2);// формирование поезда класса стандарт
                        Console.Write("__________________________________\n");
                        Console.Write(">Вы выбрали поезд класса стандарт!\n");
                        Console.WriteLine("[ Количество вагонов в поезде: " + train.TrainLength + " ]");
                        Console.Write("__________________________________\n");
                        do
                        {
                            InputData();
                        } while (passangerName != String.Empty);
                        break;
                    }
                case "2":
                case "c":
                case "comfort":
                case "к":
                case "комфорт":
                    {
                        Console.Clear();
                        train = new TrainModel(2, 5, 3);// формирование поезда комфорт-класса
                        Console.Write("__________________________________\n");
                        Console.Write(">Вы выбрали поезд комфорт-класса!\n");
                        Console.WriteLine("[ Количество вагонов в поезде: " + train.TrainLength + " ]");
                        Console.Write("__________________________________\n");
                        do
                        {
                            InputData();
                        } while (passangerName != String.Empty);
                        break;
                    }
                case "3":
                case "p":
                case "premium":
                case "п":
                case "премиум":
                    {
                        Console.Clear();
                        train = new TrainModel(0, 4, 4);// формирование поезда премиум-класса
                        Console.Write("__________________________________\n");
                        Console.Write("Вы выбрали поезд премиум-класса!\n");
                        Console.WriteLine("[ Количество вагонов в поезде: " + train.TrainLength + " ]");
                        Console.Write("__________________________________\n");
                        do
                        {
                            InputData();
                        } while (passangerName != String.Empty);
                        break;
                    }
                default:
                    { Console.Write("Ошибка!\nПовторите ввод: "); goto label1; }
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Предоставляет стандартный интерфейс для регистрации пассажира
        /// </summary>
        public static void InputData()
        {
            Console.Write(">Укажите номер вагона-> ");
            numVagon = Convert.ToInt32(Console.ReadLine());
            Console.Write(">Выберите номер места из доступных-> ");
            placeNumber = Convert.ToInt32(Console.ReadLine());
            if (train.FreePlace(numVagon, placeNumber))
            {
                Console.Write(">Введите вашу фамилию-> ");
                passangerName = Console.ReadLine();
                train.OnPlace(numVagon, placeNumber, passangerName);
                Console.WriteLine("{0}, ваше место в вагоне готово!", passangerName);
                Console.Write("__________________________________\n");
            }
        }
    }

}
