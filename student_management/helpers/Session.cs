namespace student_management.Helpers
{
    public static class Session
    {
        public static int userId;
        public static int studentDbId;
        public static int teacherDbId;

        public static string username;
        public static string role;
        public static string fullName;

        public static string studentNumber;
        public static string teacherNumber;

        public static int classId;
        public static string className;
        public static string gradeLevel;
        public static string section;

        public static void Clear()
        {
            userId = 0;
            studentDbId = 0;
            teacherDbId = 0;

            username = "";
            role = "";
            fullName = "";

            studentNumber = "";
            teacherNumber = "";

            classId = 0;
            className = "";
            gradeLevel = "";
            section = "";
        }
    }
}