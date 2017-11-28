using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows;
using System.Windows.Documents;

namespace StudentsMarks
{
    internal class Database
    {
        static readonly string Path = $"Data Source = {System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\DB\Students.db")}";
        static SQLiteConnection Db = new SQLiteConnection(Path);
        private static List<string> StudentsL = new List<string>();

        public static List<string> StudentsReturn(string command = @"SELECT * FROM Names")
        {
            try
            {
                using (Db)
                {
                    Db.Open();
                    var commandText = string.Format(command);
                    using (var cmd = new SQLiteCommand(commandText, Db))
                    {
                        using (var rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                StudentsL.Add($"ID: {rdr[0]} Name: {rdr[1]} {rdr[2]}");
                            }
                            Db.Close();

                            return StudentsL;
                        }
                            
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }

        }
    }
}
