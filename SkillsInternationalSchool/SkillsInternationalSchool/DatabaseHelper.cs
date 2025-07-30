using System;
using System.Data.SQLite;

namespace SkillsInternationalSchool
{
    public class DatabaseHelper
    {
        private static string connectionString = "Data Source=Student.sqlite;Version=3;";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        public static void InitializeDatabase()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Registration (
                        regNo INTEGER PRIMARY KEY AUTOINCREMENT,
                        firstName VARCHAR(50),
                        lastName VARCHAR(50),
                        dateOfBirth DATETIME,
                        gender VARCHAR(50),
                        address VARCHAR(50),
                        email VARCHAR(50),
                        mobilePhone INTEGER,
                        homePhone INTEGER,
                        parentName VARCHAR(50),
                        nic VARCHAR(50),
                        contactNo INTEGER
                    )";
                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
