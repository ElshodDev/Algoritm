
namespace Algoritm
{
    public class FirstOutEnd
    {
        public static string PigIt(string str)
        {
            string[] strings=str.Split(' ');

            for(int i=0; i<strings.Length; i++)
            {
                strings[i]=TransformWord(strings[i]);
            }
            return string.Join(" ", strings);
        }

        private static string TransformWord(string strings)
        {
            if (strings.Length <=1) return strings;
            return strings.Substring(1)+strings[0]+"ay";
        }
    }
}
