using System.Reflection;

namespace PersonalRecord.Domain
{
    public static class DatabaseHelper
    {
        public static string GetDatabasePath()
        {
            var runningDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var databasePath = Path.Combine(runningDirectory, "PersonalRecord.db");
            return databasePath;
        }
    }
}
