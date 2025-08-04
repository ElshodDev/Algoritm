namespace Algoritm
{
    public class Opstrings
    {
        public static string VertMirror(string strng)
        {
            string[] lines = strng.Split('\n');
            var reversedlines=lines.Select(line=>
            new string(line.Reverse().ToArray().ToArray()));
            return string.Join("\n", reversedlines);
        }
        public static string HorMirror(string strng)
        {
            string[] goriz=strng.Split("\n").Reverse().ToArray();
            return string.Join("\n", goriz);

        }
        public static string Oper(Func<string, string> fct, string s)
        {
            return fct(s);
        }
    }
}
