
public class TextData
{
    private string FileName ;
    private string Text ;
    private int NumberOfVowels ;
    private int NumberOfConsonants ;
    private int NumberOfLetters ;
    private int NumberOfSentences ;
    private string LongestWord ;

    public TextData(string fileName, string text)
    {
        FileName = fileName;
        Text = text;
        NumberOfVowels = getNumberOfVowels(Text);
        NumberOfConsonants = getNumberOfConsonants(Text);
        NumberOfLetters = getNumberOfLetters(Text);
        NumberOfSentences = getNumberOfSentences(Text);
        LongestWord = getLongestWord(Text);
    }

    public string fileName()=>FileName;
    public string getText()=>Text;
    private int getNumberOfVowels(string text)
    {
        return text.Count(c => "AEIOUaeiou".Contains(c));
    }

    private int getNumberOfConsonants(string text)
    {
        return text.Count(c => "BCDFGHJKLMNPQRSTVWXYZbcdfghjklmnpqrstvwxyz".Contains(c));
    }
    private int getNumberOfLetters(string text)
    {
        return text.Count(c => "BCDFGHJKLMNPQRSTVWXYZbcdfghjklmnpqrstvwxyzAEIOUaeiou".Contains(c));
    }
    private int getNumberOfSentences(string text)
    {
        return text.Count(c => ".!?".Contains(c));
    }

    private string getLongestWord(string text)
    {
        string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        return words.OrderByDescending(word => word.Length).FirstOrDefault();
    }

    public override string ToString()
    {
        return $"File Name: {FileName}\n" +
               $"Text: {Text}\n" +
               $"Number of Vowels: {NumberOfVowels}\n" +
               $"Number of Consonants: {NumberOfConsonants}\n" +
               $"Number of Letters: {NumberOfLetters}\n" +
               $"Number of Sentences: {NumberOfSentences}\n" +
               $"Longest Word: {LongestWord}";
    }
}
