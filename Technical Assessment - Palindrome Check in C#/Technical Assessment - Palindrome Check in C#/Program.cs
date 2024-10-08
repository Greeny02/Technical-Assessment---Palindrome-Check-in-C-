namespace Technical_Assessment___Palindrome_Check_in_C_;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello, please enter a word: ");
        string word = Console.ReadLine();

        List<char> wordList = new List<char>();

        foreach (char item in word)
        {
            wordList.Add(item);
        }

        //foreach (var item in wordList)
        //{
        //    Console.WriteLine(item);
        //}

        Console.Write(word.Length);
        string reverseWord = "";
        for (int i = word.Length; i > 0; i--)
        {
            Console.Write(wordList[i - 1]);
            reverseWord += wordList[i - 1];
        }

        Console.WriteLine(reverseWord);

        //if(reverseWord == word)
        //{
        //    Console.WriteLine($"{word} is a Palindrome");
        //}
        //else
        //{
        //    Console.WriteLine($"{word} is not a Palindrome");
        //}
    }
}
