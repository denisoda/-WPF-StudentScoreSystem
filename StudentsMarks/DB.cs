using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows;
using System.Threading;



namespace StudentsMarks
{
    

    public abstract class Database
    {
        private static readonly string Path = $"Data Source = {System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\DB\Students.db")}";
        private static SQLiteConnection _db = new SQLiteConnection(Path);
        private static readonly List<string> StudentsL = new List<string>();


        public static List<string> StudentsReturn(string Comand)
        {
            try
            {
                    _db = new SQLiteConnection(Path);
                
                    if ((_db.State & ConnectionState.Open) == 0)
                    {
                        _db.Open();
                    }

                    using (var cmd = new SQLiteCommand(Comand, _db))
                    {
                        using (var rdr = cmd.ExecuteReader())
                        {   
                            StudentsL.Clear();
                            
                            
                            
                            while (rdr.Read())
                            {
                                StudentsL.Add($"ID: {rdr[0]} Name: {rdr[1]} {rdr[2]} Average Score: {rdr[3]} ");
                            }
                            return StudentsL;
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
