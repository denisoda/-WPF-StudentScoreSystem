using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;

namespace StudentsMarks
{
    abstract class Student
    {
        public abstract string Show(List<string> students);
    }
}
