using System.Text.RegularExpressions;
using System.Windows.Navigation;

namespace StudentsMarks
{
    public static class _Name
    {
        private static readonly string pattern = @"([A-Z]+[a-z]+\s+[A-Z]+[a-z]+)";
        private static readonly Regex R = new Regex(pattern);
        public static bool RegCheckNameCheck(string name)
        {
            return R.Match(name).Success;
        }
    }
}
