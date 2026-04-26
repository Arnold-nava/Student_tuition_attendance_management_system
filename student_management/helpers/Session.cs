namespace student_management.Helpers
{
    public class Session
    {
        public static int userId;
        public static int studentId;
        public static string username;
        public static string role;
        public static string fullName;
        public static string course;
        public static string year;
        public static string semester;
        public static string section;


        public static void Clear()
        {
            userId = 0;
            studentId = 0;
            username = "";
            role = "";
            fullName = "";
            course = "";
            year = "";
            semester = "";
            section = "";
        }
    }
}