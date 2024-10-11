namespace ExceptionsDelegates

{
    class Program

    /// <summary>
    ///Создайте консольное решение, в котором реализуйте конструкцию Try/Catch/Finally <summary>
    /// для обработки исключения ArgumentOutOfRangeException.
    /// В случае исключения отобразите в консоль сообщение об ошибке.
    /// </summary>

    {
        static void Main(string[] args)
        {
            var list = new List<string>();
            try
            {
                Console.WriteLine(list[0]);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("это уже эребор");
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}