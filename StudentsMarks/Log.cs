using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Win32;

namespace StudentsMarks
{   
    

    class Log:ILog
    {   List<string> LoG = new List<string>();
        public delegate string Log_(string text);
        private readonly string Path;

        bool ILog.Log(Log_ text)
        {
            var open = File.Open(Environment.CurrentDirectory, FileMode.Create);

            LoG.Add(text);

            return true;
        }
    }
}
