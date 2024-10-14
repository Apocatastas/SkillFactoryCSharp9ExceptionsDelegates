using System;

namespace ExceptionsDelegates
{
    /// <summary>
    /// ✓ Создайте свой тип исключения.
    /// ✓ Сделайте массив из пяти различных видов исключений, включая собственный тип исключения.
    /// ✓ Реализуйте конструкцию TryCatchFinally, в которой будет итерация на каждый тип исключения
    ///     (блок finally по желанию).
    ///     В блоке catch выведите в консольном сообщении текст исключения.
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            int iterator = 0;
            DivideByZeroException ex0 = new DivideByZeroException();
            ArgumentOutOfRangeException ex1 = new ArgumentOutOfRangeException();
            IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
            NullReferenceException ex3 = new NullReferenceException();
            PaulException p = new PaulException("Мне не нравится имя Павел!");

            Exception[] exceptions = new Exception[5] { ex0, ex1, ex2, ex3, p };

            foreach (Exception e in exceptions)
            {
                try
                {
                    iterator++;
                    throw e;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.Read();
        }
    }
}