namespace Technical_Assessment___Palindrome_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Hello, please enter a word: ");
                string word = Console.ReadLine();

                //Creates list of individual letters within the word
                List<char> wordList = new List<char>();
                foreach (char item in word)
                {
                    wordList.Add(item);
                }

                //Goes through the list in reverse and adds it to the new reverseWord string
                string reverseWord = "";
                for (int i = word.Length; i > 0; i--)
                {
                    reverseWord += wordList[i - 1];
                }

                //Validates whether the reversed word is equal to the original word
                if (reverseWord == word)
                {
                    Console.WriteLine($"{word} is a Palindrome");
                }
                else
                {
                    Console.WriteLine($"{word} is not a Palindrome");
                }
            }
        }
    }
}
