using System;
using ExceptionsDelegates;

namespace Task2
{
    /// Делегат для события сортировки
    public delegate void Sort();

    public class MyEventHandler
    {
        public MyEventHandler()
        {
        }

        /// <summary>
        /// Событие нажатия кнопки сортировки
        /// </summary>
        public event Sort SortKeyPressed;

        protected virtual void OnKeyPressed()
        {
            SortKeyPressed?.Invoke();
        }

        public void StartListening()
        {
            Console.WriteLine("Ожидаем выбор способа сортировки 1 (А-Я) или 2 (Я-А)");
            OnKeyPressed();
        }
    }
}

