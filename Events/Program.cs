namespace Events
{
    internal class Prograam
    {
        static void Main(string[] args)
        {
            Timer timer = new();
            Clock clock = new();

            timer.TimeChangeEvent += clock.Parsetime;

            timer.Start();
        }
    }
}

//Задание
/*
 * Два класса
 * Таймер
 * Часы
 * 
 * В таймере метод Start()
 * Старт с циклом от 0 до 10000
 * Еще должен быть Sleep(1000)
 * Отправить сколько прошло времени
 * 
 * В часах метод, который парсит данные таймера
 * Получает на вход значения, например сколько прошло минут (60/n) и секунд
 * Еще добавить вывод на экрана час
 */
