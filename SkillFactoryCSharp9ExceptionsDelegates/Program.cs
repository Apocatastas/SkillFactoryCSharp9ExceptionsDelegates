namespace ExceptionsDelegates

{
    class Program
    {
        static void Main(string[] args)
        {

            Exception exception = new Exception();
            exception.Data.Add("Создано: ", DateTime.Now);
        }
    }
}