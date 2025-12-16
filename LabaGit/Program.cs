using System;

namespace LabaGit 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-----ЗАПУСК ТРЕКЕРА КРОКІВ-----");

            try
            {
                int myGoal = 5000;
                var tracker = new Tracker(myGoal);
                Console.WriteLine($"\n1. Трекер створено. Ціль на день: {tracker.DailyK} кроків.");

                int morningWalk = 2000;
                Console.WriteLine($"\n-> Ранкову прогулянку почати: +{morningWalk} кроків.");
                tracker.AddSteps(morningWalk);
                PrintStatus(tracker);

                int dayWalk = 2500;
                Console.WriteLine($"\n-> Денну активність: +{dayWalk} кроків.");
                tracker.AddSteps(dayWalk);
                PrintStatus(tracker);

                int eveningWalk = 600;
                Console.WriteLine($"\n-> Вечірню прогулянку: +{eveningWalk} кроків.");
                tracker.AddSteps(eveningWalk);
                PrintStatus(tracker);

                Console.WriteLine("\n-> Настав новий день. Скид лічильник...");
                tracker.ResetDay();
                Console.WriteLine($"Кроків після скидання: {tracker.StepsToday_A}");

                //Console.WriteLine("\n Спроба створити трекер з від'ємною ціллю:");
                //var badTracker = new Tracker(-100);
            }
            catch (ArgumentException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"ПОМИЛКА: {ex.Message}");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка невідома: {ex.Message}");
            }

            Console.WriteLine("\nПрограма завершена!");
        }

        static void PrintStatus(Tracker t)
        {
            Console.Write($"   Поточні кроки: {t.StepsToday_A} | ");
            Console.Write($"Прогрес: {t.GetProgress()}% | ");

            if (t.IsGoalReached)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ціль виконана!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Треба ще походити...");
            }
            Console.ResetColor();
        }
    }
}
