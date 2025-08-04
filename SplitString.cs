namespace Algoritm
{
    public class SplitString
    {
        public static List<string> Solution(string str)
        {
            if (str.Length%2!=0)
            {
                str+="_";
            }
            List<string> result = new List<string>();
            int i = 0;

            while (i < str.Length) 
            {
                result.Add(str.Substring(i,2));
                i += 2;
            }
            return result;
        }
    }
}
