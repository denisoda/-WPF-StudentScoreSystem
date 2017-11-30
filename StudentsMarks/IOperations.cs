using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace StudentsMarks
{
    internal interface ILog
    {
        bool Log(Log.Log_ text);
    }
}
