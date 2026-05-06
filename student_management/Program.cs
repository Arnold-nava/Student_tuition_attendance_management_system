namespace student_management
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            Application.Run(new student_management.forms.Auth.Login());
=======

            Application.Run(new student_management.forms.student.StudentDashBoardForm());
            
>>>>>>> 0cf1ddb0df252d80de5fc991beffb7f57d224ab0
        }
    }
}