using System.Text;
using System.Xml;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private List<int> _generatedNumbers = new List<int>();

    public Scripture (Reference reference, string text) {
        
        _reference = reference;
        string[] words = text.Trim().Split(" ");

        foreach (string wrd in words)
        {
            Word word = new Word(text: wrd);
            _words.Add(word);
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        int wordsLength = _words.Count();
        int rndmNumber = 0;
        Random random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            if (_generatedNumbers.Count() < wordsLength)
            {       
                do
                {
                    rndmNumber = random.Next(0, wordsLength);
                } while(_generatedNumbers.Contains(rndmNumber));
                _generatedNumbers.Add(rndmNumber);
            } else
            {
                rndmNumber = random.Next(0, wordsLength);
            }
            
            Word selectedWord = _words[rndmNumber];
            selectedWord.Hide();
        }
        
    }

    public string GetDisplayText()
    {
        string scripture = "";

        Console.Write($"{_reference.GetDisplayText()} ");
        foreach (Word word in _words)
        {
            string wordText = word.GetDisplayText();
            scripture = scripture + $"{wordText} ";
        }
        return scripture;
    }

    public bool IsCompletelyHidden()
    {
        bool completelyHidden = false;

        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                completelyHidden = true;
            } else
            {
                return false;
            }
        }

        return completelyHidden;
    }
}