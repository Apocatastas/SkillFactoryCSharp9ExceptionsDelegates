namespace ExceptionsDelegates

{
    class Program
    {
        static void Main(string[] args)
        {

            Exception ex = new Exception("Exception something went wrong");
            ex.HelpLink = "https://github.com/Apocatastas/SkillFactoryCSharp9ExceptionsDelegates";
            throw ex;
        }
    }
}