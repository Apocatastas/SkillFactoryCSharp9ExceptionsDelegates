using System;

namespace ExceptionsDelegates

{
    /// <summary>
    /// Существует консольное решение, которое выводит случайное целое число
    /// в диапазоне от 0 до 100 и отображает результат в консольное сообщение:
    /// </summary>
    class Program
    {
        delegate int RandomNumberDelegate();
        static void Main(string[] args)
        {
            RandomNumberDelegate randomNumberDelegate = delegate
            {
                return new Random().Next(0, 100);
            };
            
            int result = randomNumberDelegate.Invoke();
            Console.WriteLine(result);
            Console.Read();
        }
    }
}