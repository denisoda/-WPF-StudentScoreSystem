using System.Text.RegularExpressions;
using System.Windows.Navigation;

namespace StudentsMarks
{
    internal class Name:IName
    {
        private static string pattern = @"([A-Z]+[a-z]+\s+[A-Z]+[a-z]+)";
        private readonly Regex _r = new Regex(pattern);

        bool IName.RegCheck(string name)
        {
            return _r.Match(name).Success;
        }
    }
}
