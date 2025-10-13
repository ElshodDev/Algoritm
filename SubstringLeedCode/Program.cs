class SubstringLeedCode
{
		static void Main(string[] args)
		{
			string s = "abcabcbb";
			int left = 0;
			int right = 0;
			int maxLength = 0;
			Dictionary<char, int> map = new Dictionary<char, int>();
			while (right < s.Length)
			{
				if (map.ContainsKey(s[right]))
				{
					left = Math.Max(map[s[right]] + 1, left);
				}
				map[s[right]] = right;
				maxLength = Math.Max(maxLength, right - left + 1);
				right++;
			}
			Console.WriteLine(maxLength);
		}
}