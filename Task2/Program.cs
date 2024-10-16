using System;
using System.Text.RegularExpressions;

namespace ExceptionsDelegates
{
    /// <summary>
    /// ✓ Создайте консольное приложение, в котором будет происходить сортировка списка фамилий из пяти человек.
    ///   Сортировка должна происходить при помощи события.
    /// ✓ Сортировка происходит при введении пользователем либо числа 1 (А-Я), либо числа 2 (Я-А).
    /// ✓ Дополнительно реализуйте проверку введённых данных от пользователя
    ///   через конструкцию TryCatchFinally с использованием собственного типа исключения.
    /// </summary>

    class Program
    {
        public static string[] GetList()
        {
            string pattern = "^[А-Я][a-яё]*$";
            string[] strs = new string[5];

            Console.WriteLine("Введите список из пяти фамилий");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Введите фамилию №{0}:\r\n    ", i + 1);

                try
                {
                    strs[i] = Console.ReadLine();
                    if (!Regex.IsMatch(strs[i], pattern)) { throw new ArgumentOutOfRangeException("Ввод не похож на фамилию, попробуйте ещё раз"); }
                    else if (strs[i] == "Иванов") {throw new IvanovException("Мне не нравится фамилия Иванов, я её выбрасываю!"); }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    i--;
                }
             }
            return strs;
        }

        public static byte GetParam()
        {
            byte p = 0;

            try
            {

            }
            catch (Exception exp)
            {
                Console.WriteLine("Нам нужно значение 1 или 2");
            }
            finally
            {

            }

            return p;
        }

        static void PrintLastNames(string[] lastNameList, byte param)
        {
            if (param == 1)
            {
                foreach (string item in lastNameList.OrderDescending())
                {
                    Console.WriteLine(item);
                }
            }
            else if (param == 2)
            {
                foreach (string item in lastNameList.OrderBy(x => x))
                {
                    Console.WriteLine(item);
                }
            }
        }
       

        static void Main(string[] args)
        {
            byte param = 0;
            string[] lastNameList = GetList();
            param = GetParam();
            PrintLastNames(lastNameList, param);
            Console.Read();
        }
    }
}