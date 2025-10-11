public class deletePunctuationMarksText
{
		static void Main(string[] args)
		{
				string text = "Hello, World! This is a test: Does it work? Yes, it does.";
				char[] punctuationMarks = new char[] { '.', ',', '!', '?', ':', ';', '-', '_', '(', ')', '[', ']', '{', '}', '\'', '\"' };

				string result = RemovePunctuationMarks(text, punctuationMarks);
				Console.WriteLine(result);
		}

		static string RemovePunctuationMarks(string input, char[] punctuationMarks)
		{
				foreach (char mark in punctuationMarks)
				{
						input = input.Replace(mark.ToString(), string.Empty);
				}
				return input;
		}
}