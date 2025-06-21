using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1.Data
{
    public static class Migration
    {
        public static void CreateTables(string connectionString)
        {
            using (SQLiteConnection dbConn = new SQLiteConnection(connectionString))

            {
                dbConn.Open();

                // Enable foreign key constraints
                using (var pragma = new SQLiteCommand("PRAGMA foreign_keys = ON;", dbConn))
                {
                    pragma.ExecuteNonQuery();
                }

                string[] tableCommands = new string[]
                {
                    @"
                    CREATE TABLE IF NOT EXISTS Teachers(
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Address TEXT NOT NULL,
                        Phone TEXT NOT NULL
                    );",

                    @"
                    CREATE TABLE IF NOT EXISTS Users(
                        UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT NOT NULL UNIQUE,
                        Password TEXT NOT NULL,
                        Role TEXT NOT NULL CHECK(Role IN ('Admin', 'Student', 'Teacher')),
                        IsActive INTEGER DEFAULT 1
                    );",
                    @"
                    INSERT INTO Users (Username, Password, Role) VALUES ('Admin', '*', 'Admin')
                    ;",

                    @"
                    CREATE TABLE IF NOT EXISTS Courses(
                        CourseID INTEGER PRIMARY KEY AUTOINCREMENT,
                        CourseName TEXT NOT NULL
                    );",

                    @"
                    CREATE TABLE IF NOT EXISTS Subjects(
                        SubjectID INTEGER PRIMARY KEY AUTOINCREMENT,
                        SubjectName TEXT NOT NULL,
                        CourseID INTEGER NOT NULL,
                        FOREIGN KEY(CourseID) REFERENCES Courses(CourseID)
                    );",

                    @"
                    CREATE TABLE IF NOT EXISTS Students(
                        StudentID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        CourseID INTEGER NOT NULL,
                        FOREIGN KEY(CourseID) REFERENCES Courses(CourseID)
                    );",

                    @"
                    CREATE TABLE IF NOT EXISTS Exams(
                        ExamID INTEGER PRIMARY KEY AUTOINCREMENT,
                        ExamName TEXT NOT NULL,
                        SubjectID INTEGER NOT NULL,
                        FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID)
                    );",

                    @"
                    CREATE TABLE IF NOT EXISTS Marks(
                        MarkID INTEGER PRIMARY KEY AUTOINCREMENT,
                        StudentID INTEGER NOT NULL,
                        ExamID INTEGER NOT NULL,
                        Score INTEGER NOT NULL,
                        FOREIGN KEY(StudentID) REFERENCES Students(StudentID),
                        FOREIGN KEY(ExamID) REFERENCES Exams(ExamID)
                    );",

                    @"
                    CREATE TABLE IF NOT EXISTS Rooms(
                        RoomID INTEGER PRIMARY KEY AUTOINCREMENT,
                        RoomName TEXT NOT NULL,
                        RoomType TEXT NOT NULL
                    );",

                    @"
                    CREATE TABLE IF NOT EXISTS Timetables(
                        TimetableID INTEGER PRIMARY KEY AUTOINCREMENT,
                        SubjectID INTEGER NOT NULL,
                        TimeSlot TEXT NOT NULL,
                        RoomID INTEGER NOT NULL,
                        FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID),
                        FOREIGN KEY(RoomID) REFERENCES Rooms(RoomID)
                    );",

                    @"
                    CREATE TABLE IF NOT EXISTS Admin(
                        AdminID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Email TEXT NOT NULL UNIQUE,
                        Phone TEXT,
                        UserID INT NOT NULL,
                        FOREIGN KEY(UserID) REFERENCES Users(UserID)

                    );",
                    @"
                    CREATE TABLE IF NOT EXISTS StudentTeacher(
                        ID INTEGER PRIMARY NOT NULL,
                        StudentID INTEGER NOT NULL,
                        TeacherID INTEGER NOT NULL,
                        FOREIGN KEY(StudentID) REFERENCES Students(StudentID),
                        FOREIGN KEY(TeacherID) REFERENCES Teachers(Id)
                    );"
                };


                foreach (var command in tableCommands)
                {
                    using (var cmd = new SQLiteCommand(command, dbConn))
                    {
                        cmd.ExecuteNonQuery(); // ✅ Execute table creation
                    }
                }
            }
        }

    }
    
    

}