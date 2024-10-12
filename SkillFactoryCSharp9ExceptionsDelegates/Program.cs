namespace ExceptionsDelegates

{
    /// <summary>
    /// Создайте консольное приложение, в котором есть функция,
    /// принимающая на вход два числа int, и возвращающая результат
    /// int вычитания второго числа из первого. Вызовите эту функцию
    /// в классе Main при помощи делегата и отобразите результат в консольном сообщении.
    /// </summary>
    
    public class Program
    {
        public delegate int Substraction(int a, int b);
        static void Main(string[] args)
        {
            Substraction substraction = Substract;
            Console.Write(substraction.Invoke(11, 10));
            Console.ReadKey();
        }

        static int Substract(int a, int b)
        {
            Console.Write("Результат вычитания: {0} - {1} = ", a, b);
            return a - b;
        }
    }
}