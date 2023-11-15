using System.Text;

namespace Program
{
    public static class StringReverseService
    {
        public static string Reverse(string line)
        {
            if (string.IsNullOrEmpty(line))
            {
                return line;
            }
            var builder = new StringBuilder();
            var words = line.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                builder.Append(ReverseWord(words[i]));
                builder.Append(' ');
            }
            return builder.ToString();

        }
        private static string ReverseWord(string word)
        {
            var list = new List<char>();
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLetter(word[i]))
                {
                    list.Insert(0, word[i]);
                }
            }

            for (int i = 0; i < word.Length; i++)
            {
                if (!char.IsLetter(word[i]))
                {
                    list.Insert(i, word[i]);
                }
            }

            return string.Join("", list.ToArray());
        }
    }
}
