namespace GermanEnglishDict;

public class Vocabulary
{
    private Taschenrechner<string, string> Taschenrechner = new();
    private Random r = new Random();

    /// <summary>
    /// Autor: Marcel Kainz
    ///         SEW 2CHIT 22.5.2024
    /// This Method loads content from a csv file into a dictionary<br/>
    /// The following format is required:<br/>
    /// </summary>
    /// <param name="file">Der Filename</param>
    
    public string GetRandomWord()
    {
        int x = r.Next(0, DE.Count);
    }

    public bool CheckWord(string word, string answer)
    {
        int y = 
    }
}