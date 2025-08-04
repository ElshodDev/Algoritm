namespace Algoritm
{
    public partial class InWordsFind
    {
        private static string[] QueryFind(string query, string[] words)
        {
            List<string> result = new List<string>();

            foreach (string word in words)
            {
                if (word.ToLower().Contains(query.ToLower()))
                {
                    result.Add(word);
                }
            }
            if (result.Count == 0)
            {
                return new string[] { "Empty" };
            }
            return result.ToArray();
        }
    }
}
