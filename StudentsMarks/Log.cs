using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Win32;

namespace StudentsMarks
{   
    

    class Log:INterface
    {
        List<string> LoG = new List<string>();
        public delegate string Log_();
        private readonly string Path;

        bool INterface.LoG(string text)
        {
            var open = File.Open(Environment.CurrentDirectory, FileMode.Create);

            LoG.Add(text);

            return true;
        }
    }
}
