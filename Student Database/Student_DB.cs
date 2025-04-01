using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace Student_Database
{
    public static class Student_DB
    {
        private static readonly string ConnectionString = "Data Source=Student_Database.db;Version=3;";

        public static Student GetStudent(int studentId)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string query = @"
                    SELECT Stud_ID, STUD_FIRST_NM, STUD_LAST_NM, STUD_ADDR_TXT, 
                           STUD_CITY_NM, STUD_ST_CD, STUD_ZIP_CD, STUD_MAJOR_CD, STUD_GPA, IsDeleted
                    FROM Student_MSTR
                    WHERE Stud_ID = @StudentId AND IsDeleted = 0";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentId", studentId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Student
                            {
                                StudentId = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                Address = reader.GetString(3),
                                City = reader.GetString(4),
                                StateCode = reader.GetString(5),
                                ZipCode = reader.GetInt32(6),
                                MajorCode = reader.GetString(7),
                                GPA = reader.GetFloat(8),
                                IsDeleted = reader.GetInt32(9) == 1
                            };
                        }
                        return null;
                    }
                }
            }
        }

        public static bool AddStudent(Student student)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string query = @"
                    INSERT INTO Student_MSTR (STUD_FIRST_NM, STUD_LAST_NM, STUD_ADDR_TXT, STUD_CITY_NM, STUD_ST_CD, STUD_ZIP_CD, STUD_MAJOR_CD, STUD_GPA, IsDeleted)
                    VALUES (@FirstName, @LastName, @Address, @City, @StateCode, @ZipCode, @MajorCode, @GPA, @IsDeleted)";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", student.LastName);
                    cmd.Parameters.AddWithValue("@Address", student.Address);
                    cmd.Parameters.AddWithValue("@City", student.City);
                    cmd.Parameters.AddWithValue("@StateCode", student.StateCode);
                    cmd.Parameters.AddWithValue("@ZipCode", student.ZipCode);
                    cmd.Parameters.AddWithValue("@MajorCode", student.MajorCode);
                    cmd.Parameters.AddWithValue("@GPA", student.GPA);
                    cmd.Parameters.AddWithValue("@IsDeleted", student.IsDeleted ? 1 : 0);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool UpdateStudent(Student student)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string query = @"
                    UPDATE Student_MSTR
                    SET STUD_FIRST_NM = @FirstName, STUD_LAST_NM = @LastName, STUD_ADDR_TXT = @Address, 
                        STUD_CITY_NM = @City, STUD_ST_CD = @StateCode, STUD_ZIP_CD = @ZipCode, 
                        STUD_MAJOR_CD = @MajorCode, STUD_GPA = @GPA, IsDeleted = @IsDeleted
                    WHERE Stud_ID = @StudentId";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentId", student.StudentId);
                    cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", student.LastName);
                    cmd.Parameters.AddWithValue("@Address", student.Address);
                    cmd.Parameters.AddWithValue("@City", student.City);
                    cmd.Parameters.AddWithValue("@StateCode", student.StateCode);
                    cmd.Parameters.AddWithValue("@ZipCode", student.ZipCode);
                    cmd.Parameters.AddWithValue("@MajorCode", student.MajorCode);
                    cmd.Parameters.AddWithValue("@GPA", student.GPA);
                    cmd.Parameters.AddWithValue("@IsDeleted", student.IsDeleted ? 1 : 0);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}