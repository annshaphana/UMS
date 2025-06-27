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
using static System.Net.Mime.MediaTypeNames;
using WindowsFormsApp1.Models;
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
                        Username TEXT NOT NULL,
                        Password TEXT NOT NULL,
                        Role TEXT NOT NULL CHECK(Role IN ('Admin', 'Student', 'Teacher')),
                        IsActive INTEGER DEFAULT 1
                    ); ",

                    @"
                    INSERT OR IGNORE INTO Users (Username, Password, Role) VALUES ('Admin', '*', 'Admin');
                    ",

                    @"
                    CREATE TABLE IF NOT EXISTS Courses (
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Description TEXT
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
                        Address TEXT NOT NULL,
                        CourseID INTEGER,
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
                     CREATE TABLE IF NOT EXISTS Marks (
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        StudentId INTEGER,
                        SubjectId INTEGER,
                        Score INTEGER,
                        FOREIGN KEY(StudentId) REFERENCES Students(ID),
                        FOREIGN KEY(SubjectId) REFERENCES Subjects(ID)
                    );",
                


                    @"
                    CREATE TABLE IF NOT EXISTS Rooms(
                        RoomID INTEGER PRIMARY KEY AUTOINCREMENT,
                        RoomName TEXT NOT NULL,
                        RoomType TEXT NOT NULL
                    );",

                    @"
                  CREATE TABLE IF NOT EXISTS Timetable (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Day TEXT NOT NULL,
                        Subject TEXT NOT NULL,
                        Time TEXT NOT NULL,
                        Teacher TEXT NOT NULL
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
                        ID INTEGER PRIMARY KEY NOT NULL,
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
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

    }
    
    

}