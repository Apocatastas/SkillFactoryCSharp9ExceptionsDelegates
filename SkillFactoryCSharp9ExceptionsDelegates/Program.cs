namespace ExceptionsDelegates

{
    class Program

    /// <summary>
    ///Создайте консольное решение, в котором реализуйте конструкцию Try/Catch/Finally
    ///для обработки исключения RankException. В случае исключения отобразите в консоль
    ///тип исключения (через метод GetType()).
    /// </summary>

    {
        static void Main(string[] args)
        {
            try
            {
                throw new RankException("Попався ранк эксепшен");
            }

            catch (RankException ex)
            {
                Console.WriteLine(ex.GetType());
            }

            finally
            {
                Console.Read();
            }
        }
    }
}